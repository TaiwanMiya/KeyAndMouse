using System;
using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層熱鍵方法
    /// </summary>
    public static class HotkeysNativeMethods
    {
        /// <summary>
        ///     定義系統範圍的熱鍵
        /// </summary>
        /// 
        /// <param name="hwnd">
        ///     <para>
        ///         將接收由熱鍵生成的 WM_HOTKEY 消息的窗口句柄
        ///     </para>
        ///     <para>
        ///         如果此參數為 <b>NULL</b>
        ///     </para>
        ///     <para>
        ///         WM_HOTKEY 消息被發佈到調用線程的消息隊列中
        ///     </para>
        ///     <para>
        ///         並且必須在消息循環中進行處理
        ///     </para>
        /// </param>
        /// 
        /// <param name="id">
        ///     <para>
        ///         此為熱鍵的識別碼
        ///     </para>
        ///     <para>
        ///         如果 hWnd 參數為 NULL
        ///     </para>
        ///     <para>
        ///         則熱鍵與當前線程相關聯
        ///     </para>
        ///     <para>
        ///         而不是與特定窗口相關聯
        ///     </para>
        ///     <para>
        ///         如果已存在具有相同 hWnd 和 id 參數的熱鍵
        ///     </para>
        ///     <para>
        ///         請參閱備註了解所採取的操作
        ///     </para>
        /// </param>
        /// 
        /// <param name="fsModifiers">
        ///     <para>
        ///         為了生成 WM_HOTKEY 消息
        ///     </para>
        ///     <para>
        ///         必須與 uVirtKey 參數指定的鍵組合按下的鍵
        ///     </para>
        ///     <para>
        ///         fsModifiers 參數可以是以下值的組合
        ///     </para>
        /// </param>
        /// 
        /// <param name="vk">
        ///     <para>
        ///         熱鍵的虛擬鍵代碼
        ///     </para>
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
        public static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

        /// <summary>
        ///     釋放調用線程先前註冊的熱鍵
        /// </summary>
        /// 
        /// <param name="hwnd">
        ///     <para>
        ///         與要釋放的熱鍵關聯的窗口句柄
        ///     </para>
        ///     <para>
        ///         如果熱鍵與窗口無關, 則此參數應為 NULL
        ///     </para>
        /// </param>
        /// 
        /// <param name="id">
        ///     <para>
        ///         要釋放的熱鍵的識別碼
        ///     </para>
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
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);
    }
}