using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    /// <summary>
    ///     <para>
    ///         包含特定時刻鍵盤狀態的快照
    ///     </para>
    ///     <para>
    ///         提供查詢特定鍵是否被按下或鎖定的方法
    ///     </para>
    /// </summary>
    /// 
    /// <remarks>
    ///     此類基本上是 GetKeyboardState API 函數的託管包裝器
    /// </remarks>
    public class KeyboardState
    {
        private readonly byte[] m_KeyboardStateNative;

        private KeyboardState(byte[] keyboardStateNative)
        {
            m_KeyboardStateNative = keyboardStateNative;
        }

        /// <summary>
        ///     對調用時的鍵盤狀態進行快照並返回一個 <see cref="KeyboardState" />
        /// </summary>
        /// 
        /// <returns>
        ///     <see cref="KeyboardState" /> 表示指定時刻鍵盤狀態快照的類別
        /// </returns>
        public static KeyboardState GetCurrent()
        {
            var keyboardStateNative = new byte[256];
            KeyboardNativeMethods.GetKeyboardState(keyboardStateNative);
            return new KeyboardState(keyboardStateNative);
        }

        internal byte[] GetNativeState()
        {
            return m_KeyboardStateNative;
        }

        /// <summary>
        ///     指示在創建快照時指定的鍵是否已關閉
        /// </summary>
        /// 
        /// <param name="key">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <returns>
        ///     <list type="bullet">
        ///         <item>
        ///             <b>true</b> 鍵盤按下
        ///         </item>
        ///         <item>
        ///             <b>false</b> 鍵盤鬆開
        ///         </item>
        ///     </list>
        /// </returns>
        public bool IsDown(Keys key)
        {
            if ((int)key < 256) return IsDownRaw(key);
            if (key == Keys.Alt) return IsDownRaw(Keys.LMenu) || IsDownRaw(Keys.RMenu);
            if (key == Keys.Shift) return IsDownRaw(Keys.LShiftKey) || IsDownRaw(Keys.RShiftKey);
            if (key == Keys.Control) return IsDownRaw(Keys.LControlKey) || IsDownRaw(Keys.RControlKey);
            return false;
        }

        private bool IsDownRaw(Keys key)
        {
            var keyState = GetKeyState(key);
            var isDown = GetHighBit(keyState);
            return isDown;
        }

        /// <summary>
        ///     指示在創建快照時是否切換了指定鍵
        /// </summary>
        /// 
        /// <param name="key">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <returns>
        ///     <list type="bullet">
        ///         <item>
        ///             <b>true</b> 如果(CapsLock、NumLocke 等) 之類的切換鍵已打開
        ///         </item>
        ///         <item>
        ///             <b>false</b> 如果(CapsLock、NumLocke 等) 之類的切換鍵已關閉, 非切換鍵都是返回 false
        ///         </item>
        ///     </list>
        /// </returns>
        public bool IsToggled(Keys key)
        {
            var keyState = GetKeyState(key);
            var isToggled = GetLowBit(keyState);
            return isToggled;
        }

        /// <summary>
        ///     <para>
        ///         指示在創建快照時是否每個指定的鍵都已關閉
        ///     </para>
        ///     <para>
        ///         如果其中一個已啟動, 該方法將返回 false
        ///     </para>
        /// </summary>
        /// 
        /// <param name="keys">
        ///     虛擬鍵碼
        /// </param>
        /// 
        /// <returns>
        ///     <list type="bullet">
        ///         <item>
        ///             <b>true</b> - 以確認關閉所有按鍵
        ///         </item>
        ///         <item>
        ///             <b>false</b> - 最少有一個按鍵未關閉
        ///         </item>
        ///     </list>
        /// </returns>
        public bool AreAllDown(IEnumerable<Keys> keys)
        {
            return keys.All(IsDown);
        }

        private byte GetKeyState(Keys key)
        {
            var virtualKeyCode = (int) key;
            if (virtualKeyCode < 0 || virtualKeyCode > 255)
                throw new ArgumentOutOfRangeException("key", key, "The value must be between 0 and 255.");
            return m_KeyboardStateNative[virtualKeyCode];
        }

        private static bool GetHighBit(byte value)
        {
            return value >> 7 != 0;
        }

        private static bool GetLowBit(byte value)
        {
            return (value & 1) != 0;
        }
    }
}