namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層鍵盤鼠標參數
    /// </summary>
    internal static class Messages
    {
        // Winuser.h 的值

        /// <summary>
        ///     <see cref="WM_MOUSEMOVE"/>
        ///     在鼠標移動時發送到窗口
        /// </summary>
        public const int WM_MOUSEMOVE = 0x200;

        /// <summary>
        ///     <see cref="WM_LBUTTONDOWN"/>
        ///     在用戶按下鼠標左鍵時發送到窗口
        /// </summary>
        public const int WM_LBUTTONDOWN = 0x201;

        /// <summary>
        ///     <see cref="WM_RBUTTONDOWN"/>
        ///     在用戶按下鼠標右鍵時發送到窗口
        /// </summary>
        public const int WM_RBUTTONDOWN = 0x204;

        /// <summary>
        ///     <see cref="WM_MBUTTONDOWN"/>
        ///     在用戶按下鼠標中鍵時發送到窗口
        /// </summary>
        public const int WM_MBUTTONDOWN = 0x207;

        /// <summary>
        ///     <see cref="WM_LBUTTONUP"/>
        ///     在用戶鬆開鼠標左鍵時發送到窗口
        /// </summary>
        public const int WM_LBUTTONUP = 0x202;

        /// <summary>
        ///     <see cref="WM_RBUTTONUP"/>
        ///     在用戶鬆開鼠標右鍵時發送到窗口
        /// </summary>
        public const int WM_RBUTTONUP = 0x205;

        /// <summary>
        ///     <see cref="WM_RBUTTONUP"/>
        ///     在用戶鬆開鼠標中鍵時發送到窗口
        /// </summary>
        public const int WM_MBUTTONUP = 0x208;

        /// <summary>
        ///     <see cref="WM_LBUTTONDBLCLK"/>
        ///     在用戶雙擊鼠標左鍵時發送到窗口
        /// </summary>
        public const int WM_LBUTTONDBLCLK = 0x203;

        /// <summary>
        ///     <see cref="WM_RBUTTONDBLCLK"/>
        ///     在用戶雙擊鼠標右鍵時發送到窗口
        /// </summary>
        public const int WM_RBUTTONDBLCLK = 0x206;

        /// <summary>
        ///     <see cref="WM_RBUTTONDOWN"/>
        ///     在用戶按鼠標右鍵時發送到窗口
        /// </summary>
        public const int WM_MBUTTONDBLCLK = 0x209;

        /// <summary>
        ///     <see cref="WM_MOUSEWHEEL"/>
        ///     在用戶按鼠標滾輪時發送到窗口
        /// </summary>
        public const int WM_MOUSEWHEEL = 0x020A;

        /// <summary>
        ///     <see cref="WM_XBUTTONDOWN"/>
        ///     在用戶按下第一個或第二個 X 鼠標按鈕時發送到窗口
        /// </summary>
        public const int WM_XBUTTONDOWN = 0x20B;

        /// <summary>
        ///     <see cref="WM_XBUTTONUP"/>
        ///     在用戶鬆開第一個或第二個 X 鼠標按鈕時發送到窗口
        /// </summary>
        public const int WM_XBUTTONUP = 0x20C;

        /// <summary>
        ///     <see cref="WM_XBUTTONDBLCLK"/>
        ///     在用戶雙擊第一個或第二個 X 鼠標按鈕時發送到窗口
        /// </summary>
        /// 
        /// <remarks>
        ///     只有具有 CS_DBLCLKS 樣式的窗口才能接收 <see cref="WM_XBUTTONDBLCLK"/> 的消息
        /// </remarks>
        public const int WM_XBUTTONDBLCLK = 0x20D;

        /// <summary>
        ///     <see cref="WM_MOUSEHWHEEL"/>
        ///     在用戶的鼠標水平滾輪傾斜或旋轉時發送到窗口
        /// </summary>
        public const int WM_MOUSEHWHEEL = 0x20E;

        /// <summary>
        ///     當按下非系統鍵時, <see cref="WM_KEYDOWN"/> 消息將發送到窗口
        ///     <br/>
        ///     非系統鍵是在未按下 ALT 鍵時按下的鍵
        /// </summary>
        public const int WM_KEYDOWN = 0x100;

        /// <summary>
        ///     當鬆開非系統鍵時, <see cref="WM_KEYUP"/> 消息將發送窗口
        ///     <br/>
        ///     非系統鍵是在未按下 ALT 鍵時按下的鍵, 或在窗口具有鍵盤焦點時按下的鍵盤鍵
        /// </summary>
        public const int WM_KEYUP = 0x101;

        /// <summary>
        ///     當用戶按下 F10 鍵(啟用菜單欄) 或按住 ALT 鍵然後按下另一個鍵時, <see cref="WM_SYSKEYDOWN"/> 消息將發送到窗口
        ///     <br/>
        ///     在這種情況下, 當前沒有窗口時也會觸發這種情況, <see cref="WM_SYSKEYDOWN"/> 消息被發送到活動窗口
        ///     <br/>
        ///     接收消息的窗口可以通過檢查lParam參數中的上下文代碼來區分這兩種上下文
        /// </summary>
        public const int WM_SYSKEYDOWN = 0x104;

        /// <summary>
        ///     當用戶釋放 F10 鍵 或按住 ALT 鍵然後鬆開另一個鍵時, <see cref="WM_SYSKEYUP"/> 消息將發送到窗口
        ///     <br/>
        ///     在這種情況下, 當前沒有窗口時也會觸發這種情況, <see cref="WM_SYSKEYUP"/> 消息被發送到活動窗口
        ///     <br/>
        ///     接收消息的窗口可以通過檢查lParam參數中的上下文代碼來區分這兩種上下文
        /// </summary>
        public const int WM_SYSKEYUP = 0x105;
    }
}