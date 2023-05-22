using System;
using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層掛鉤方法
    /// </summary>
    public static class HookNativeMethods
    {
        /// <summary>
        ///     <para>
        ///         函數 <see cref="CallNextHookEx"/> 是將掛鉤信息傳遞給當前掛鉤鏈中的下一個掛鉤過程
        ///     </para>
        ///     <para>
        ///         鉤子過程可以在處理鉤子信息之前或之後調用此函數
        ///     </para>
        /// </summary>
        /// 
        /// <param name="idHook">
        ///     該參數被忽略
        /// </param>
        /// 
        /// <param name="nCode">
        ///     [in] 指定傳遞給當前鉤子過程的鉤子代碼
        /// </param>
        /// 
        /// <param name="wParam">
        ///     [in] 指定傳遞給當前掛鉤過程的 wParam 值
        /// </param>
        /// 
        /// <param name="lParam">
        ///     [in] 指定傳遞給當前掛鉤過程的 lParam 值
        /// </param>
        /// 
        /// <returns>該值由鏈中的下一個鉤子過程返回</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CallNextHookEx(
            IntPtr idHook,
            int nCode,
            IntPtr wParam,
            IntPtr lParam);

        /// <summary>
        ///     <para>
        ///         函數 <see cref="SetWindowsHookEx"/> 是將應用程序定義的掛鉤過程安裝到掛鉤鏈中
        ///     </para>
        ///     <para>
        ///         安裝一個掛鉤程序來監視系統中某些類型的事件
        ///     </para>
        ///     <para>
        ///         這些事件與特定線程或與調用線程相同的桌面中的所有線程關聯
        ///     </para>
        /// </summary>
        /// 
        /// <param name="idHook">
        ///     <para>
        ///         [in] 指定要安裝的掛鉤過程的類型, 此參數可以是以下值之一
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpfn">
        ///     <para>
        ///         [in] 指向鉤子過程的指針
        ///     </para>
        ///     <para>
        ///         如果 dwThreadId 參數為零或指定由不同進程創建的線程的識別碼
        ///     </para>
        ///     <para>
        ///         lpfn 參數必須指向動態鏈接庫 (DLL) 中的掛鉤過程
        ///     </para>
        ///     <para>
        ///         否則, lpfn 可以指向與當前進程關聯的代碼中的掛鉤過程
        ///     </para>
        /// </param>
        /// 
        /// <param name="hMod">
        ///     <para>
        ///         [in] 包含 lpfn 參數指向的鉤子過程的 DLL 句柄
        ///     </para>
        ///      <para>
        ///         如果 dwThreadId 參數指定由當前進程創建的線程並且掛鉤過程在與當前進程關聯的代碼內
        ///     </para>
        ///      <para>
        ///         則 hMod 參數必須設置為 NULL
        ///     </para>
        /// </param>
        /// 
        /// <param name="dwThreadId">
        ///     <para>
        ///         [in] 指定要與掛鉤過程關聯的線程的識別碼
        ///     </para>
        ///     <para>
        ///         如果此參數為零
        ///     </para>
        ///     <para>
        ///         則掛鉤過程與在與調用線程相同的桌面上運行的所有現有線程相關聯
        ///     </para>
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         如果函數成功, 返回值是鉤子過程的句柄
        ///     </para>
        ///     <para>
        ///         如果函數失敗, 返回值為 NULL
        ///     </para>
        ///     <para>
        ///         要獲取擴展錯誤信息, 請調用 GetLastError
        ///     </para>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern HookProcedureHandle SetWindowsHookEx(
            int idHook,
            HookProcedure lpfn,
            IntPtr hMod,
            int dwThreadId);

        /// <summary>
        ///     <para>
        ///         函數 <see cref="UnhookWindowsHookEx"/> 是刪除由 <see cref="SetWindowsHookEx"/> 函數安裝在鉤子鏈中的鉤子過程
        ///     </para>
        /// </summary>
        /// 
        /// <param name="idHook">
        ///     <para>
        ///         [in] 要卸下的掛鉤句柄, 該參數是之前調用 <see cref="SetWindowsHookEx"/> 獲得的鉤子句柄
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
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int UnhookWindowsHookEx(IntPtr idHook);
    }
}