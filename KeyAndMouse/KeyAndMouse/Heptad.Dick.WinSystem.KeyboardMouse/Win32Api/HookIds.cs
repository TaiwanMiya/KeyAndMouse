namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層掛鉤碼
    ///     <para>
    ///         winuser.h 掛鉤程序ID
    ///     </para>
    /// </summary>
    public static class HookIds
    {
        /// <summary>
        ///     安裝一個監視鼠標消息的程序, 詳情請看 user32 MouseProc
        /// </summary>
        internal const int WH_MOUSE = 7;

        /// <summary>
        ///     安裝一個監視鍵盤消息的程序, 詳情請看 user32 KeyboardProc
        /// </summary>
        internal const int WH_KEYBOARD = 2;

        /// <summary>
        ///     <para>
        ///         <b>Windows NT/2000/XP/Vista/7</b>
        ///     </para>
        ///     <para>
        ///         安裝一個監控低級鼠標輸入事件的掛鉤程序
        ///     </para>
        /// </summary>
        internal const int WH_MOUSE_LL = 14;

        /// <summary>
        ///     <para>
        ///         <b>Windows NT/2000/XP/Vista/7</b>
        ///     </para>
        ///     <para>
        ///         安裝一個監視低級鍵盤輸入事件的掛鉤程序
        ///     </para>
        /// </summary>
        internal const int WH_KEYBOARD_LL = 13;
    }
}