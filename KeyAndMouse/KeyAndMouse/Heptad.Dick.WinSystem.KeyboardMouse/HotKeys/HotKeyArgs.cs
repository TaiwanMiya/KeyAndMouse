using System;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Hotkeys
{
    /// <summary>
    ///     觸發 HotKeySet 的 OnHotKeysDownHold 事件時傳遞的事件參數
    /// </summary>
    public sealed class HotKeyArgs : EventArgs
    {
        /// <summary>
        ///     創建 HotKeyArgs 的一個實例
        /// </summary>
        /// 
        /// <param name="triggeredAt">
        ///     觸發事件的時間
        /// </param>
        public HotKeyArgs(DateTime triggeredAt)
        {
            Time = triggeredAt;
        }

        /// <summary>
        ///     觸發事件的時間
        /// </summary>
        public DateTime Time { get; }
    }
}