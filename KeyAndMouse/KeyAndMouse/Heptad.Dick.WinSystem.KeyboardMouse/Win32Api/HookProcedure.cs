using System;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     <para>
    ///         CallWndProc 掛鉤過程是與 SetWindowsHookEx 函數一起使用的應用程序定義或庫定義的回調函數
    ///     </para>
    ///     <para>
    ///         HOOKPROC 類型定義了一個指向這個回調函數的指針
    ///     </para>
    ///     <para>
    ///         CallWndProc 是應用程序定義或庫定義的函數名稱的佔位符
    ///     </para>
    /// </summary>
    /// 
    /// <param name="nCode">
    ///     <para>
    ///         [in] 指定掛鉤過程是否必須處理消息
    ///     </para>
    ///     <para>
    ///         如果 nCode 是 HC_ACTION, 則掛鉤過程必須處理該消息
    ///     </para>
    ///     <para>
    ///         如果 nCode 小於零, 則掛鉤過程必須將消息傳遞給 CallNextHookEx 函數而不進行進一步處理
    ///     </para>
    ///     <para>
    ///         而且必須返回 CallNextHookEx 返回的值
    ///     </para>
    /// </param>
    /// 
    /// <param name="wParam">
    ///     <para>
    ///         [in] 指定消息是否由當前線程發送
    ///     </para>
    ///     <para>
    ///         如果消息是由當前線程發送的, 則為非零; 否則為零
    ///     </para>
    /// </param>
    /// 
    /// <param name="lParam">
    ///     <para>
    ///         [in] 指向包含有關消息的詳細信息的 CWPSTRUCT 結構的指針
    ///     </para>
    /// </param>
    /// 
    /// <returns>
    ///     <para>
    ///         如果 nCode 小於零, 則掛鉤過程必須返回 CallNextHookEx 返回的值
    ///     </para>
    ///     <para>
    ///         如果 nCode 大於等於 0, 強烈建議調用 CallNextHookEx 並返回它返回的值;
    ///     </para>
    ///     <para>
    ///         否則, 其他安裝了 WH_CALLWNDPROC 鉤子的應用程序將不會收到鉤子通知, 因此可能會出現錯誤的行為
    ///     </para>
    ///     <para>
    ///         如果掛鉤過程不調用 CallNextHookEx, 則返回值為零
    ///     </para>
    /// </returns>
    public delegate IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam);
}