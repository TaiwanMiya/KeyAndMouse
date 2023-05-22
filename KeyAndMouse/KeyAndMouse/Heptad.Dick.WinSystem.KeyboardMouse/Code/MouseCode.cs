using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Code
{
    /// <summary>
    /// 滑鼠按鈕
    /// </summary>
    public enum MouseKeys
    {
        /// <summary>
        /// 左鍵
        /// </summary>
        Left = 0x01,
        /// <summary>
        /// 右鍵
        /// </summary>
        Right = 0x02,
        /// <summary>
        /// 中鍵, 滾輪
        /// </summary>
        Middle = 0x04,
    }

    public struct MouseCode
    {
        /// <summary>
        /// 滑鼠移動
        /// </summary>
        public const int MOUSEEVENTF_MOVE = 0x0001;
        /// <summary>
        /// 按下滑鼠左鍵
        /// </summary>
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        /// <summary>
        /// 鬆開滑鼠左鍵
        /// </summary>
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        /// <summary>
        /// 按下滑鼠右鍵
        /// </summary>
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        /// <summary>
        /// 鬆開滑鼠右鍵
        /// </summary>
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        /// <summary>
        /// 按下滑鼠中鍵
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        /// <summary>
        /// 鬆開滑鼠中鍵
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        /// <summary>
        /// 按下X按鈕
        /// </summary>
        public const int MOUSEEVENTF_XDOWN = 0x0080;
        /// <summary>
        /// 鬆開X按鈕
        /// </summary>
        public const int MOUSEEVENTF_XUP = 0x0100;
        /// <summary>
        /// 滑鼠滾輪移動
        /// </summary>
        public const int MOUSEEVENTF_WHEEL = 0x0800;
        /// <summary>
        /// 滑鼠滾輪傾斜
        /// </summary>
        public const int MOUSEEVENTF_HWHEEL = 0x1000;
        /// <summary>
        /// 虛擬桌面
        /// </summary>
        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;
        /// <summary>
        /// 採取絕對座標
        /// </summary>
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
    }
}
