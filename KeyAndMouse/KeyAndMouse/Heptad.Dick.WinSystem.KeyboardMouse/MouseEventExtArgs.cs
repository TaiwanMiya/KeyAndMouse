using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    /// 為 MouseClickExt 和 MouseMoveExt 事件提供擴展數據
    /// </summary>
    public class MouseEventExtArgs : MouseEventArgs
    {
        /// <summary>
        ///     <para>
        ///         初始化一個新的實例
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventExtArgs" />
        ///     </para>
        /// </summary>
        /// 
        /// <param name="buttons">指示按下哪個鼠標按鈕的 MouseButtons 值之一</param>
        /// 
        /// <param name="clicks">鼠標按鈕被按下的次數</param>
        /// 
        /// <param name="point">鼠標單擊的 x 和 y 坐標,以像素為單位</param>
        /// 
        /// <param name="delta">車輪旋轉的數量, 正值向前, 負值向後</param>
        /// 
        /// <param name="timestamp">事件發生時的計數</param>
        /// 
        /// <param name="isMouseButtonDown">如果事件發出鼠標按鈕按下的信號, 則為 true</param>
        /// 
        /// <param name="isMouseButtonUp">如果事件發出鼠標按鈕向上的信號, 則為 true</param>
        /// 
        /// <param name="isHorizontalWheel">如果事件表示水平輪動作, 則為 true</param>
        internal MouseEventExtArgs(MouseButtons buttons, int clicks, Point point, int delta, int timestamp,
            bool isMouseButtonDown, bool isMouseButtonUp, bool isHorizontalWheel)
            : base(buttons, clicks, point.X, point.Y, delta)
        {
            IsMouseButtonDown = isMouseButtonDown;
            IsMouseButtonUp = isMouseButtonUp;
            IsHorizontalWheel = isHorizontalWheel;
            Timestamp = timestamp;
        }

        /// <summary>
        ///     <para>
        ///         在事件處理程序中將此屬性設置為 <b>true</b>
        ///     </para>
        ///     <para>
        ///         來防止在其他應用程序中進一步處理該事件
        ///     </para>
        /// </summary>
        public bool Handled { get; set; }

        /// <summary>
        /// 事件包含有關滾輪滾動的信息
        /// </summary>
        public bool WheelScrolled
        {
            get { return Delta != 0; }
        }

        /// <summary>
        ///     <para>
        ///         如果事件發出點擊信號, 則為 <b>true</b>
        ///     </para>
        ///     <para>
        ///         如果它只是移動或滾輪滾動, 則為 <b>false</b>
        ///     </para>
        /// </summary>
        public bool Clicked
        {
            get { return Clicks > 0; }
        }

        /// <summary>
        /// 如果事件發出鼠標按鈕按下的信號, 則為 <b>true</b>
        /// </summary>
        public bool IsMouseButtonDown { get; }

        /// <summary>
        /// 如果事件發出鼠標按鈕向上的信號, 則為 <b>true</b>
        /// </summary>
        public bool IsMouseButtonUp { get; }

        /// <summary>
        /// 如果事件表示水平輪動作, 則為 <b>true</b>
        /// </summary>
        public bool IsHorizontalWheel { get; }

        /// <summary>
        /// 事件發生時的計數
        /// </summary>
        public int Timestamp { get; }

        /// <summary>
        /// 鼠標單擊的 x 和 y 坐標<br/>以像素為單位
        /// </summary>
        internal Point Point
        {
            get { return new Point(X, Y); }
        }

        /// <summary>
        /// 應用數據掛勾
        /// </summary>
        internal static MouseEventExtArgs FromRawDataApp(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            var marshalledMouseStruct =
                (AppMouseStruct) Marshal.PtrToStructure(lParam, typeof(AppMouseStruct));
            return FromRawDataUniversal(wParam, marshalledMouseStruct.ToMouseStruct());
        }

        /// <summary>
        /// 全域數據掛勾
        /// </summary>
        internal static MouseEventExtArgs FromRawDataGlobal(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            var marshalledMouseStruct = (MouseStruct) Marshal.PtrToStructure(lParam, typeof(MouseStruct));
            return FromRawDataUniversal(wParam, marshalledMouseStruct);
        }

        /// <summary>
        ///     創建來自 <see cref="MouseEventExtArgs" /> 的鼠標數據
        /// </summary>
        /// 
        /// <param name="wParam">
        ///     <para>
        ///         第一個 Windows 消息參數
        ///     </para>
        /// </param>
        /// 
        /// <param name="mouseInfo">
        ///     <para>
        ///         一個 <see cref="MouseStruct" />
        ///     </para>
        ///     <para>
        ///         包含從中構造 <see cref="MouseEventExtArgs" /> 的信息
        ///     </para>
        /// </param>
        /// 
        /// <returns>一個新的 <see cref="MouseEventExtArgs"/> 對象</returns>
        private static MouseEventExtArgs FromRawDataUniversal(IntPtr wParam, MouseStruct mouseInfo)
        {
            var button = MouseButtons.None;
            short mouseDelta = 0;
            var clickCount = 0;

            var isMouseButtonDown = false;
            var isMouseButtonUp = false;
            var isHorizontalWheel = false;


            switch ((long) wParam)
            {
                case Messages.WM_LBUTTONDOWN:
                    isMouseButtonDown = true;
                    button = MouseButtons.Left;
                    clickCount = 1;
                    break;
                case Messages.WM_LBUTTONUP:
                    isMouseButtonUp = true;
                    button = MouseButtons.Left;
                    clickCount = 1;
                    break;
                case Messages.WM_LBUTTONDBLCLK:
                    isMouseButtonDown = true;
                    button = MouseButtons.Left;
                    clickCount = 2;
                    break;
                case Messages.WM_RBUTTONDOWN:
                    isMouseButtonDown = true;
                    button = MouseButtons.Right;
                    clickCount = 1;
                    break;
                case Messages.WM_RBUTTONUP:
                    isMouseButtonUp = true;
                    button = MouseButtons.Right;
                    clickCount = 1;
                    break;
                case Messages.WM_RBUTTONDBLCLK:
                    isMouseButtonDown = true;
                    button = MouseButtons.Right;
                    clickCount = 2;
                    break;
                case Messages.WM_MBUTTONDOWN:
                    isMouseButtonDown = true;
                    button = MouseButtons.Middle;
                    clickCount = 1;
                    break;
                case Messages.WM_MBUTTONUP:
                    isMouseButtonUp = true;
                    button = MouseButtons.Middle;
                    clickCount = 1;
                    break;
                case Messages.WM_MBUTTONDBLCLK:
                    isMouseButtonDown = true;
                    button = MouseButtons.Middle;
                    clickCount = 2;
                    break;
                case Messages.WM_MOUSEWHEEL:
                    isHorizontalWheel = false;
                    mouseDelta = mouseInfo.MouseData;
                    break;
                case Messages.WM_MOUSEHWHEEL:
                    isHorizontalWheel = true;
                    mouseDelta = mouseInfo.MouseData;
                    break;
                case Messages.WM_XBUTTONDOWN:
                    button = mouseInfo.MouseData == 1
                        ? MouseButtons.XButton1
                        : MouseButtons.XButton2;
                    isMouseButtonDown = true;
                    clickCount = 1;
                    break;
                case Messages.WM_XBUTTONUP:
                    button = mouseInfo.MouseData == 1
                        ? MouseButtons.XButton1
                        : MouseButtons.XButton2;
                    isMouseButtonUp = true;
                    clickCount = 1;
                    break;
                case Messages.WM_XBUTTONDBLCLK:
                    isMouseButtonDown = true;
                    button = mouseInfo.MouseData == 1
                        ? MouseButtons.XButton1
                        : MouseButtons.XButton2;
                    clickCount = 2;
                    break;
            }

            var e = new MouseEventExtArgs(
                button,
                clickCount,
                mouseInfo.Point,
                mouseDelta,
                mouseInfo.Timestamp,
                isMouseButtonDown,
                isMouseButtonUp,
                isHorizontalWheel);

            return e;
        }
        
        /// <summary>
        /// 鼠標雙擊事件參數
        /// </summary>
        internal MouseEventExtArgs ToDoubleClickEventArgs()
        {
            return new MouseEventExtArgs(Button, 2, Point, Delta, Timestamp, IsMouseButtonDown, IsMouseButtonUp, IsHorizontalWheel);
        }
    }
}