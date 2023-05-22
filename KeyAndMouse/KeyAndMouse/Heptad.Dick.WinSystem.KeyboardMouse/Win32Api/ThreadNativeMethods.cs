using System;
using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層內核窗口方法
    /// </summary>
    public static class ThreadNativeMethods
    {
        /// <summary>
        ///     檢索調用線程的非託管線程識別碼
        /// </summary>
        /// 
        /// <returns>線程識別碼</returns>
        [DllImport("kernel32")]
        public static extern int GetCurrentThreadId();

        /// <summary>
        ///     <para>
        ///         檢索前台窗口(用戶當前正在使用的窗口) 的句柄
        ///     </para>
        ///     <para>
        ///         系統為前台窗口創建的線程分配會比其他線程稍高的優先等級
        ///     </para>
        /// </summary>
        /// 
        /// <returns>窗口句柄</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        ///     <para>
        ///         檢索創建指定窗口的線程的識別碼
        ///     </para>
        ///     <para>
        ///         以及創建窗口的進程的識別碼(可選)
        ///     </para>
        /// </summary>
        /// 
        /// <param name="handle">
        ///     窗口句柄
        /// </param>
        /// 
        /// <param name="processId">
        ///     <para>
        ///         指向接收進程識別碼變量的指針
        ///     </para>
        ///     <para>
        ///         如果此參數不為 NULL
        ///     </para>
        ///     <para>
        ///         <see cref="GetWindowThreadProcessId"/> 會將進程的識別碼複製到變量中, 否則不會
        ///     </para>
        /// </param>
        /// 
        /// <returns>
        ///     返回值是創建窗口的線程的識別碼
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
    }
}