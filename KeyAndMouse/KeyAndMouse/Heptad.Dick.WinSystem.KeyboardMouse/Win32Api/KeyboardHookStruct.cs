using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     <see cref="KeyboardHookStruct"/> 結構包含有關低級鍵盤輸入事件的信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct KeyboardHookStruct
    {
        /// <summary>
        ///     指定一個虛擬鍵碼, 代碼必須是 1 到 254 範圍內的值
        /// </summary>
        public int VirtualKeyCode;

        /// <summary>
        ///     指定鍵盤的硬件掃描代碼
        /// </summary>
        public int ScanCode;

        /// <summary>
        ///     指定擴展鍵標誌、事件注入標誌、上下文代碼和轉換狀態標誌
        /// </summary>
        public int Flags;

        /// <summary>
        ///     指定此消息的時間戳
        /// </summary>
        public int Time;

        /// <summary>
        ///     指定與消息關聯的額外信息
        /// </summary>
        public int ExtraInfo;
    }
}