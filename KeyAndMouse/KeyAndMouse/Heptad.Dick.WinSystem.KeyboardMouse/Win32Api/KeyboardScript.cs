using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Heptad.Dick.WinSystem.KeyboardMouse.Code;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層鍵盤驅動事件
    /// </summary>
    public class KeyboardScript
    {
        /// <summary>
        ///     斷開鍵盤掃描碼
        ///     <para>
        ///         鍵盤掃描碼 + 0x80
        ///     </para>
        ///     <para>
        ///         也稱為 BreakCode
        ///     </para>
        ///     <para>
        ///         是對該鍵碼解除硬體設備的控制, 傳送後該鍵的功能將失效直到再次啟用
        ///     </para>
        /// </summary>
        public static byte GetBreakCode(ScanCode keys)
        {
            return (byte)((byte)keys + 0x80);
        }

        /// <summary>
        ///     發送鍵盤事件
        /// </summary>
        /// 
        /// <param name="bVk" >
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name= "bScan" >
        ///     鍵盤掃描碼
        /// </param>
        /// 
        /// <param name= "dwFlags" >
        ///     請參照 <see cref="keyFlags"/>
        /// </param>
        /// 
        /// <param name= "dwExtraInfo">
        ///     與鍵盤相關的附加數據 (建議設置0)
        /// </param>
        [DllImport("user32.dll", EntryPoint = "keybd_event", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int SetWindowsHookEx(
            int idHook,
            HookProc lpfn,
            IntPtr hMod,
            int dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
             CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(
            int idHook,
            int nCode,
            int wParam,
            IntPtr lParam);

        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);

        [DllImport("user32")]
        public static extern int ToAscii(
            int uVirtKey,
            int uScanCode,
            byte[] lpbKeyState,
            byte[] lpwTransKey,
            int fuState);

        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int vKey);

        /// <summary>
        ///     將字符轉換為當前鍵盤對應的虛擬鍵代碼和 shift 狀態
        /// </summary>
        /// 
        /// <param name="ch">
        ///     要轉換為虛擬鍵代碼的字符
        /// </param>
        /// 
        /// <returns>
        ///     如果函數成功, 返回值的低位字節包含虛擬鍵碼, 高位字節包含移位狀態, 可以是以下標誌位的組合
        ///     <para>
        ///         1 = 	按下任一 SHIFT 鍵
        ///     </para>
        ///     <para>
        ///         2 =     按下任一 CTRL 鍵
        ///     </para>
        ///     <para>
        ///         4 =     按下任一 ALT 鍵
        ///     </para>
        ///     <para>
        ///         8 = 	半格鍵被按下
        ///     </para>
        ///     <para>
        ///         16 =    保留（由鍵盤佈局驅動程序定義）
        ///     </para>
        ///     <para>
        ///         32 =    保留（由鍵盤佈局驅動程序定義）
        ///     </para>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern short VkKeyScan(char ch);

        public static void keyBackground(IntPtr hWnd, byte virtualcode, byte scancode)
		{

		}

        /// <summary>
        ///     按下或鬆開按鍵
        /// </summary>
        /// 
        /// <param name="keyName">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name="ScanCode">
        ///     鍵盤掃描碼
        /// </param>
        /// 
        /// <param name="IsDown">
        ///     <list type="bullet">
        ///         <item>
        ///             <description>0 - 按下</description>
        ///         </item>
        ///         <item>
        ///             <description>2 - 鬆開</description>
        ///         </item>
        ///     </list>
        /// </param>
        public static void keyInput(byte keyName, byte ScanCode = 0, int IsDown = 0)
        {
            keybd_event(keyName, ScanCode, IsDown, 0);
        }

        /// <summary>
        ///     按下多個按鍵並鬆開
        /// </summary>
        /// 
        /// <param name="keyNames">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <param name="ScanCodes">
        ///     鍵盤掃描碼
        /// </param>
        public static void keyPress(byte[] keyNames, byte[] ScanCodes = null)
        {
            if (ScanCodes == null)
            {
                ScanCodes = new byte[keyNames.Length];
                for (int i = 0; i < ScanCodes.Length; i++)
                {
                    ScanCodes[i] = 0;
                }
            }
            for (int i = 0; i < keyNames.Length; i++)
            {
                keybd_event(keyNames[i], ScanCodes[i], 0, 0);
            }
            for (int i = 0; i < keyNames.Length; i++)
            {
                keybd_event(keyNames[i], ScanCodes[i], 2, 0);
            }
        }

        /// <summary>
        ///     字符串執行鍵盤操作
        /// </summary>
        /// 
        /// <param name="str">
        ///     字符串
        /// </param>
        public static void keyStringInput(string str)
        {
            foreach (char i in str)
            {
                if (Keychars.DO.ContainsKey(i))
                {
                    switch (Keychars.DO[i][2])
                    {
                        case 0:
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 0, 0);
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 2, 0);
                            break;
                        case 1:
                            keybd_event(Keycode.L_SHIFT.virtualcode, Keycode.L_SHIFT.scancode, 0, 0);
                            keybd_event(Keycode.L_SHIFT.virtualcode, Keycode.L_SHIFT.scancode, 2, 0);
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 0, 0);
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 2, 0);
                            keybd_event(Keycode.L_SHIFT.virtualcode, Keycode.L_SHIFT.scancode, 0, 0);
                            keybd_event(Keycode.L_SHIFT.virtualcode, Keycode.L_SHIFT.scancode, 2, 0);
                            break;
                        case 2:
                            keybd_event(Keycode.CAPS.virtualcode, Keycode.CAPS.scancode, 0, 0);
                            keybd_event(Keycode.CAPS.virtualcode, Keycode.CAPS.scancode, 2, 0);
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 0, 0);
                            keybd_event(Keychars.DO[i][0], Keychars.DO[i][1], 2, 0);
                            keybd_event(Keycode.CAPS.virtualcode, Keycode.CAPS.scancode, 0, 0);
                            keybd_event(Keycode.CAPS.virtualcode, Keycode.CAPS.scancode, 2, 0);
                            break;
                    }
                }
            }
        }
    }
}
