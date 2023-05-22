using System.Runtime.InteropServices;
using Heptad.Dick.WinSystem.KeyboardMouse.Code;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層滑鼠驅動事件
    /// </summary>
    public class MouseScript
    {
        /// <summary>
        ///     鼠標操作
        /// </summary>
        /// 
        /// <param name="dwFlags">
        ///     動作和點擊選項
        /// </param>
        /// 
        /// <param name="dx">
        ///     X 座標位置或變化
        /// </param>
        /// 
        /// <param name="dy">
        ///     Y座標位置或變化
        /// </param>
        /// 
        /// <param name="dwData">
        ///     滾輪移動
        ///     <list type="bullet">
        ///         <item>
        ///             <description>正值向前</description>
        ///         </item>
        ///         <item>
        ///             <description>負值向後</description>
        ///         </item>
        ///     </list>
        /// </param>
        /// 
        /// <param name="dwExtraInfo">
        ///     與鼠標相關的附加數據 (建議設置0
        /// </param>
        [DllImport("user32.dll", EntryPoint = "mouse_event", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        /// <summary>
        /// 鼠標移動
        /// </summary>
        /// 
        /// <param name="x">
        ///     移動到位的 X 座標
        /// </param>
        /// <param name="y">
        ///     移動到位的 Y 座標
        /// </param>
        /// 
        /// <returns>
        ///     本次執行的進程識別碼
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "SetCursorPos", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern int SetCursorPos(int x, int y);

        /// <summary>
        /// 移動並點擊
        /// </summary>
        /// 
        /// <param name="X">
        ///     X 座標
        /// </param>
        /// 
        /// <param name="Y">
        ///     Y 座標
        /// </param>
        /// 
        /// <param name="btn">
        ///     滑鼠按鍵, 參照 <see cref="MouseKeys"/>
        /// </param>
        public static void MouseClick(int X, int Y, MouseKeys btn)
        {
            SetCursorPos(X, Y);
            switch (btn)
            {
                case MouseKeys.Left:
                    mouse_event(MouseCode.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    break;
                case MouseKeys.Right:
                    mouse_event(MouseCode.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    break;
                case MouseKeys.Middle:
                    mouse_event(MouseCode.MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                    break;
            }
        }

        /// <summary>
        /// 不移動只點擊
        /// </summary>
        /// 
        /// <param name="btn">
        ///     滑鼠按鍵, 參照 <see cref="MouseKeys"/>
        /// </param>
        public static void Click(MouseKeys btn)
        {
            switch (btn)
            {
                case MouseKeys.Left:
                    mouse_event(MouseCode.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    break;
                case MouseKeys.Right:
                    mouse_event(MouseCode.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    break;
                case MouseKeys.Middle:
                    mouse_event(MouseCode.MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                    mouse_event(MouseCode.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                    break;
            }
        }

        /// <summary>
        /// 滑鼠滾動
        /// </summary>
        /// 
        /// <param name="values">
        ///     滾輪移動
        ///     <list type="bullet">
        ///         <item>
        ///             <description>正值向前</description>
        ///         </item>
        ///         <item>
        ///             <description>負值向後</description>
        ///         </item>
        ///     </list>
        /// </param>
        public static void Scroll(int values)
        {
            mouse_event(MouseCode.MOUSEEVENTF_WHEEL, 0, 0, values, 0);
        }
    }
}
