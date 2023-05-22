using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    
    /// <summary>
    ///     底層鍵盤方法
    /// </summary>
    public static class KeyboardNativeMethods
    {
        // Winuser.h 的值
        public const byte VK_SHIFT = 0x10;

        public const byte VK_CAPITAL = 0x14;
        public const byte VK_NUMLOCK = 0x90;
        public const byte VK_LSHIFT = 0xA0;
        public const byte VK_RSHIFT = 0xA1;
        public const byte VK_LCONTROL = 0xA2;
        public const byte VK_RCONTROL = 0xA3;
        public const byte VK_LMENU = 0xA4;
        public const byte VK_RMENU = 0xA5;
        public const byte VK_LWIN = 0x5B;
        public const byte VK_RWIN = 0x5C;
        public const byte VK_SCROLL = 0x91;

        public const byte VK_INSERT = 0x2D;

        // 可以單獨使用這些聚合, 而非 L 和 R
        public const byte VK_CONTROL = 0x11;

        public const byte VK_MENU = 0x12;

        public const byte VK_PACKET = 0xE7;

        //用於傳遞 Unicode 字符, 像是擊鍵一樣, VK_PACKET 鍵是用於非鍵盤輸入法的 32 位虛擬鍵值的低位字
        private static int lastVirtualKeyCode;

        private static int lastScanCode;
        private static byte[] lastKeyState = new byte[255];
        private static bool lastIsDead;

        /// <summary>
        ///     <para>
        ///         在事先不知道掃描碼的情況下, 使用當前鍵盤佈局將虛擬鍵轉換為其等效字符
        ///     </para>
        /// </summary>
        /// 
        /// <param name="virtualKeyCode">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name="fuState">
        ///     副狀態
        /// </param>
        /// 
        /// <param name="chars">
        ///     字節陣列
        /// </param>
        /// 
        /// <returns></returns>
        public static void TryGetCharFromKeyboardState(int virtualKeyCode, int fuState, out char[] chars)
        {
            var dwhkl = GetActiveKeyboard();
            var scanCode = MapVirtualKeyEx(virtualKeyCode, (int) MapType.MAPVK_VK_TO_VSC, dwhkl);
            TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, dwhkl, out chars);
        }

        /// <summary>
        ///     使用當前鍵盤佈局將虛擬鍵轉換為其等效字符
        /// </summary>
        /// 
        /// <param name="virtualKeyCode">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name="scanCode">
        ///     鍵盤掃描碼
        /// </param>
        /// 
        /// <param name="fuState">
        ///     副狀態
        /// </param>
        /// 
        /// <param name="chars">
        ///     字節陣列
        /// </param>
        /// 
        /// <returns></returns>
        internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState,
            out char[] chars)
        {
            var dwhkl = GetActiveKeyboard(); //get the active keyboard layout
            TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, dwhkl, out chars);
        }

        /// <summary>
        ///     使用指定的鍵盤佈局將虛擬鍵轉換為其等效字符
        /// </summary>
        /// 
        /// <param name="virtualKeyCode">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name="scanCode">
        ///     鍵盤掃描碼
        /// </param>
        /// 
        /// <param name="fuState">
        ///     副狀態
        /// </param>
        /// 
        /// <param name="dwhkl">
        ///     HKL
        /// </param>
        /// 
        /// <param name="chars">
        ///     字節陣列
        /// </param>
        /// 
        /// <returns></returns>
        internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState, IntPtr dwhkl,
            out char[] chars)
        {
            var pwszBuff = new StringBuilder(64);
            var keyboardState = KeyboardState.GetCurrent();
            var currentKeyboardState = keyboardState.GetNativeState();
            var isDead = false;

            if (keyboardState.IsDown(Keys.ShiftKey))
                currentKeyboardState[(byte) Keys.ShiftKey] = 0x80;

            if (keyboardState.IsToggled(Keys.CapsLock))
                currentKeyboardState[(byte) Keys.CapsLock] = 0x01;

            var relevantChars = ToUnicodeEx(virtualKeyCode, scanCode, currentKeyboardState, pwszBuff, pwszBuff.Capacity,
                fuState, dwhkl);

            switch (relevantChars)
            {
                case -1:
                    isDead = true;
                    ClearKeyboardBuffer(virtualKeyCode, scanCode, dwhkl);
                    chars = null;
                    break;

                case 0:
                    chars = null;
                    break;

                case 1:
                    if (pwszBuff.Length > 0) chars = new[] {pwszBuff[0]};
                    else chars = null;
                    break;

                // 兩個或更多 (只有其中兩個是相關的)
                default:
                    if (pwszBuff.Length > 1) chars = new[] {pwszBuff[0], pwszBuff[1]};
                    else chars = new[] {pwszBuff[0]};
                    break;
            }

            if (lastVirtualKeyCode != 0 && lastIsDead)
            {
                if (chars != null)
                {
                    var sbTemp = new StringBuilder(5);
                    ToUnicodeEx(lastVirtualKeyCode, lastScanCode, lastKeyState, sbTemp, sbTemp.Capacity, 0, dwhkl);
                    lastIsDead = false;
                    lastVirtualKeyCode = 0;
                }

                return;
            }

            lastScanCode = scanCode;
            lastVirtualKeyCode = virtualKeyCode;
            lastIsDead = isDead;
            lastKeyState = (byte[]) currentKeyboardState.Clone();
        }


        private static void ClearKeyboardBuffer(int vk, int sc, IntPtr hkl)
        {
            var sb = new StringBuilder(10);

            int rc;
            do
            {
                var lpKeyStateNull = new byte[255];
                rc = ToUnicodeEx(vk, sc, lpKeyStateNull, sb, sb.Capacity, 0, hkl);
            } while (rc < 0);
        }

        /// <summary>
        ///     <para>
        ///         獲取活動應用程序線程的輸入語言環境識別碼
        ///     </para>
        ///     <para>
        ///         將此與 ToUnicodeEx 和 MapVirtualKeyEx 結合使用使 Windows 能夠根據為應用程序指定的鍵盤佈局正確轉換鍵
        ///     </para>
        /// </summary>
        /// 
        /// <returns>HKL</returns>
        private static IntPtr GetActiveKeyboard()
        {
            var hActiveWnd = ThreadNativeMethods.GetForegroundWindow(); //handle to focused window
            var hCurrentWnd = ThreadNativeMethods.GetWindowThreadProcessId(hActiveWnd, out _);
            //thread of focused window
            return GetKeyboardLayout(hCurrentWnd); //get the layout identifier for the thread whose window is focused
        }

        /// <summary>
        ///     <para>
        ///         <see cref="ToAscii"/> 函數將指定的虛擬鍵代碼和鍵盤狀態轉換為相應的一個或多個字符
        ///     </para>
        ///     <para>
        ///         該函數使用鍵盤佈局句柄標識的輸入語言和物理鍵盤佈局來轉換代碼
        ///     </para>
        /// </summary>
        /// 
        /// <param name="uVirtKey">
        ///     <para>
        ///         [in] 指定要轉換的虛擬鍵碼
        ///     </para>
        /// </param>
        /// 
        /// <param name="uScanCode">
        ///     <para>
        ///         [in] 指定要轉換的鍵盤掃描碼 
        ///     </para>
        ///     <para>
        ///         如果鍵向上(未按下), 則設置此值的高位
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpbKeyState">
        ///     <para>
        ///         [in] 指向包含當前鍵盤狀態的 256 字節數組的指針
        ///     </para>
        ///     <para>
        ///         數組中的每個元素(字節)都包含一個鍵的狀態
        ///     </para>
        ///     <para>
        ///         如果設置了一個字節的高位, 則按鍵按下
        ///     </para>
        ///     <para>
        ///         如果設置了低位, 則表示該鍵已打開, 在這個函數中
        ///     </para>
        ///     <para>
        ///         只有 CAPS LOCK 鍵的切換位是相關的
        ///     </para>
        ///     <para>
        ///         NUM LOCK 和 SCROLL LOCK 鍵將被忽略
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpwTransKey">
        ///     <para>
        ///         [out] 指向接收已轉換字符的緩衝區的指針
        ///     </para>
        /// </param>
        /// 
        /// <param name="fuState">
        ///     <para>
        ///         [in] 指定菜單是否處於活動狀態, 如果菜單處於活動狀態, 此參數必須為 1; 否則為 0
        ///     </para>
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         如果指定的鍵是死鍵, 則返回值為負, 否則它是以下值之一
        ///     </para>
        ///     <list type="number">
        ///         <item>
        ///             0 指定的虛擬鍵對鍵盤的當前狀態沒有轉換
        ///         </item>
        ///         <item>
        ///             1 一個字符被複製到緩衝區
        ///         </item>
        ///         <item>
        ///             <para>
        ///                 2 兩個字符被複製到緩衝區, 當存儲在鍵盤佈局中的死鍵字符
        ///             </para>
        ///             <para>
        ///                 (重音或變音符號), 無法與指定的虛擬鍵組合以形成單個字符時, 通常會發生這種情況
        ///             </para>
        ///         </item>
        ///     </list>
        /// </returns>
        [Obsolete("Use ToUnicodeEx instead")]
        [DllImport("user32.dll")]
        public static extern int ToAscii(
            int uVirtKey,
            int uScanCode,
            byte[] lpbKeyState,
            byte[] lpwTransKey,
            int fuState);

        /// <summary>
        ///     將指定的虛擬鍵代碼和鍵盤狀態轉換為相應的 Unicode 字符
        /// </summary>
        /// 
        /// <param name="wVirtKey">
        ///     <para>
        ///         [in] 要轉換的虛擬鍵碼
        ///     </para>
        /// </param>
        /// 
        /// <param name="wScanCode">
        ///     <para>
        ///         [in] 要轉換的鍵盤掃描碼, 如果鍵向上, 則設置此值的高位
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpKeyState">
        ///     <para>
        ///         [in, optional] 指向包含當前鍵盤狀態的 256 字節數組的指針
        ///     </para>
        ///     <para>
        ///         數組中的每個元素(字節)都包含一個鍵的狀態
        ///     </para>
        ///     <para>
        ///         如果設置了一個字節的高位, 則key為down
        ///     </para>
        /// </param>
        /// 
        /// <param name="pwszBuff">
        ///     <para>
        ///         [out] 接收已轉換的 Unicode 字符或字符的緩衝區
        ///     </para>
        ///     <para>
        ///         但即使變量名稱表明它是空的或終止的, 也可能會返回此緩衝區而不以空終止
        ///     </para>
        /// </param>
        /// 
        /// <param name="cchBuff">
        ///     <para>
        ///         [in] <seealso href="pwszBuff"/> 參數指向的緩衝區的大小(以字符為單位)
        ///     </para>
        /// </param>
        /// 
        /// <param name="wFlags">
        ///     <para>
        ///         [in] 函數的行為, 如果設置了 0, 則菜單處於活動狀態, 1 到 31 保留
        ///     </para>
        /// </param>
        ///     
        /// <param name="dwhkl">
        ///     <para>
        ///         用於轉換指定代碼的輸入語言環境識別碼
        ///     </para>
        /// </param>
        /// 
        /// <returns>
        ///     -1 &lt;= return &lt;= n
        ///     <list type="bullet">
        ///         <item>
        ///             <para>
        ///                 -1    = 指定的虛擬鍵是死鍵字符(重音或變音符號)
        ///             </para>
        ///             <para>
        ///                 無論鍵盤佈局如何, 都會返回此值, 即使已鍵入多個字符並存儲在鍵盤狀態中也是如此
        ///             </para>
        ///             <para>
        ///                 即使使用 Unicode 鍵盤佈局, 該函數也會將死鍵字符的間距版本寫入 <see href="pwszBuff"/> 指定的緩衝區
        ///             </para>
        ///             <para>
        ///                 舉例, 函數寫入字符 SPACING ACUTE (0x00B4), 而不是字符 NON_SPACING ACUTE (0x0301)
        ///             </para>
        ///         </item>
        ///         <item>
        ///             <para>
        ///                 0    = 指定的虛擬鍵對鍵盤的當前狀態沒有轉換
        ///             </para>
        ///             <para>
        ///                 沒有任何內容寫入 <see href="pwszBuff"/> 指定的緩衝區
        ///             </para>
        ///         </item>
        ///         <item>
        ///             <para>
        ///                 1    = 一個字符被寫入 <see href="pwszBuff"/> 指定的緩衝區
        ///             </para>
        ///         </item>
        ///         <item>
        ///             <para>
        ///                 n    = 兩個或多個字符被寫入 <see href="pwszBuff"/> 指定的緩衝區
        ///             </para>
        ///             <para>
        ///                 最常見的原因是存儲在鍵盤佈局中的死鍵字符(重音或變音符號) 無法與指定的虛擬鍵組合形成單個字符
        ///             </para>
        ///             <para>
        ///                 但緩衝區可能包含比返回值指定的更多的字符
        ///             </para>
        ///             <para>
        ///                 發生這種情況時, 任何多餘的字符都是無效的, 請直接忽略
        ///             </para>
        ///             <para>
        ///                 
        ///             </para>
        ///         </item>
        ///     </list>
        /// </returns>
        [DllImport("user32.dll")]
        public static extern int ToUnicodeEx(int wVirtKey,
            int wScanCode,
            byte[] lpKeyState,
            [Out] [MarshalAs(UnmanagedType.LPWStr, SizeConst = 64)] StringBuilder pwszBuff,
            int cchBuff,
            int wFlags,
            IntPtr dwhkl);

        /// <summary>
        ///     <see cref="GetKeyboardState"/> 函數將 256 個虛擬鍵的狀態復製到指定緩衝區
        /// </summary>
        /// 
        /// <param name="pbKeyState">
        ///     [in] 指向包含鍵盤按鍵狀態的 256 字節數組的指針
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         如果函數成功, 則返回值非零
        ///     </para>
        ///     <para>
        ///         如果函數失敗, 則返回值為零
        ///     </para>
        ///     <para>
        ///         要獲取擴展錯誤信息, 請調用 GetLastError
        ///     </para>
        /// </returns>
        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        /// <summary>
        ///     <see cref="GetKeyState"/> 函數檢索指定虛擬鍵的狀態。狀態指定鍵是向上、向下還是切換
        ///     (開、關——每次按鍵時交替)
        /// </summary>
        /// 
        /// <param name="vKey">
        ///     <para>
        ///         [in] 指定一個虛擬鍵
        ///     </para>
        ///     <para>
        ///         如果所需的虛擬鍵是字母或數字(A 到 Z、a 到 z 或 0 到 9)
        ///     </para>
        ///     <para>
        ///         <see href="nVirtKey"/> 必須設置為該字符的 ASCII 值
        ///     </para>
        ///     <para>
        ///         對於其他鍵, 它必須是虛擬鍵碼
        ///     </para>
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         返回值指定指定虛擬鍵的狀態
        ///     </para>
        ///     <para>
        ///         如果高位為1, 則key為down; 否則key為up
        ///     </para>
        ///     <para>
        ///         如果低位為1, 則鍵做出切換一個鍵, 如 CAPS LOCK 鍵, 如果打開就會被切換
        ///     </para>
        ///     <para>
        ///         如果低位為0, 則該鍵關閉且未切換, 切換鍵時鍵盤上的切換鍵指示燈(如果有) 將亮起, 當鍵未切換時熄滅
        ///     </para>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int vKey);

        /// <summary>
        ///     將虛擬鍵碼轉換(映射) 為掃描碼或字符值, 或將掃描碼轉換為虛擬鍵碼
        /// </summary>
        /// 
        /// <param name="uCode">
        ///     [in] 鍵的虛擬鍵碼或掃描碼, 該值的解釋方式取決於 <see href="uMapType"/> 參數的值
        /// </param>
        /// 
        /// <param name="uMapType">
        ///     [in] 要執行的轉換, 這個參數的值取決於 <see href="uCode"/> 參數的值
        /// </param>
        /// 
        /// <param name="dwhkl">
        ///     [in] 用於轉換指定代碼的輸入語言環境識別碼
        /// </param>
        /// 
        /// <returns>
        ///     虛擬鍵碼或鍵盤掃描碼
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MapVirtualKeyEx(int uCode, int uMapType, IntPtr dwhkl);

        /// <summary>
        ///     將虛擬鍵碼轉換(映射) 為掃描碼或字符值, 或將掃描碼轉換為虛擬鍵碼
        /// </summary>
        /// 
        /// <param name="uCode">
        ///     [in] 鍵的虛擬鍵碼或掃描碼, 該值的解釋方式取決於 <see href="uMapType"/> 參數的值
        /// </param>
        /// 
        /// <param name="uMapType">
        ///     [in] 要執行的轉換, 這個參數的值取決於 <see href="uCode"/> 參數的值
        /// </param>
        /// 
        /// <returns>
        ///     虛擬鍵碼或鍵盤掃描碼
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MapVirtualKey(int uCode, int uMapType);

        /// <summary>
        ///     檢索指定線程的活動輸入區域設置識別碼 (以前稱鍵盤佈局)
        ///     如果 <see href="idThread"/> 參數為零, 則返回活動線程的輸入區域設置識別碼
        /// </summary>
        /// 
        /// <param name="dwLayout">
        ///     [in] 要查詢的線程的識別碼, 或者目前線程為 0
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         返回值是線程的輸入語言環境識別碼
        ///     </para>
        ///     <para>
        ///         低位字包含輸入語言的語言識別碼
        ///     </para>
        ///     <para>
        ///         高位字包含鍵盤物理佈局的設備句柄
        ///     </para>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayout(int dwLayout);

        /// <summary>
        ///     映射虛擬鍵 的 <see href="uCode"/> 類型
        ///     <para>給 <see cref="MapVirtualKeyEx"/>, <see cref="MapVirtualKey"/> 使用</para>
        /// </summary>
        public enum MapType
        {
            /// <summary>
            ///     <para>
            ///         uCode參數是一個虛擬鍵碼, 被轉換成掃描碼
            ///     </para>
            ///     <para>
            ///         如果是不區分左右鍵的虛擬鍵碼, 則返回左邊的掃描碼
            ///     </para>
            ///     <para>
            ///         如果轉換失敗, 該函數返回 0
            ///     </para>
            /// </summary>
            MAPVK_VK_TO_VSC,

            /// <summary>
            ///     <para>
            ///         uCode參數是一個掃描碼, 被翻譯成一個不區分左右鍵的虛擬鍵碼
            ///     </para>
            ///     <para>
            ///         如果轉換失敗, 該函數返回 0
            ///     </para>
            /// </summary>
            MAPVK_VSC_TO_VK,

            /// <summary>
            ///     <para>
            ///         uCode參數是一個虛擬鍵碼, 在返回值的低位字中被轉換成一個未移位的字符值
            ///     </para>
            ///     <para>
            ///         通過設置返回值的最高位來指示死鍵(變音符號)
            ///     </para>
            ///     <para>
            ///         如果轉換失敗, 該函數返回 0
            ///     </para>
            /// </summary>
            MAPVK_VK_TO_CHAR,

            /// <summary>
            ///     <para>
            ///         uCode參數是一個掃描碼, 被轉換成一個虛擬鍵碼, 用於區分左手鍵和右手鍵
            ///     </para>
            ///     <para>
            ///         如果沒有轉換, 該函數返回 0
            ///     </para>
            /// </summary>
            MAPVK_VSC_TO_VK_EX,

            /// <summary>
            ///     <para>
            ///         uCode參數是一個虛擬鍵碼，並被轉換為掃描碼
            ///     </para>
            ///     <para>
            ///         如果是不區分左右鍵的虛擬鍵碼, 則返回左手掃碼
            ///     </para>
            ///     <para>
            ///         如果掃描碼是擴展掃描碼, 則uCode值的高字節可以包含0xe0或0xe1來指定擴展掃描碼
            ///     </para>
            ///     <para>
            ///         如果沒有轉換, 該函數返回 0
            ///     </para>
            /// </summary>
            MAPVK_VK_TO_VSC_EX,
        }
    }
}