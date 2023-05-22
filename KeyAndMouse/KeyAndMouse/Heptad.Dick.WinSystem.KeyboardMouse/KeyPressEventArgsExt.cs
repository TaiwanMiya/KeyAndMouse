using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         提供擴展數據
    ///     </para>
    ///     <para>
    ///         <see cref='KeyListener.KeyPress' />
    ///     </para>
    /// </summary>
    public class KeyPressEventArgsExt : KeyPressEventArgs
    {
        internal KeyPressEventArgsExt(char keyChar, int timestamp)
            : base(keyChar)
        {
            IsNonChar = keyChar == (char) 0x0;
            Timestamp = timestamp;
        }

        /// <summary>
        ///     <para>
        ///         初始化一個新的實例
        ///     </para>
        ///     <para>
        ///         <see cref='KeyPressEventArgsExt' />
        ///     </para>
        /// </summary>
        /// 
        /// <param name="keyChar">
        ///     <para>
        ///         與按下的鍵對應的字符, 0 char 表示系統或功能性非 char 鍵
        ///     </para>
        /// </param>
        public KeyPressEventArgsExt(char keyChar)
            : this(keyChar, Environment.TickCount)
        {
        }

        /// <summary>
        /// 如果表示系統或功能性非字符鍵, 則為 <b>true</b>
        /// </summary>
        public bool IsNonChar { get; }

        /// <summary>
        /// 事件發生時的系統計數
        /// </summary>
        public int Timestamp { get; }

        internal static IEnumerable<KeyPressEventArgsExt> FromRawDataApp(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            const uint maskKeydown = 0x40000000;    // bit 30
            const uint maskKeyup = 0x80000000;      // bit 31
            const uint maskScanCode = 0xff0000;     // bit 23-16

            var flags = (uint) lParam.ToInt64();

            //bit 30 -> 指定前一個鍵狀態, 如果在發送消息之前鍵已關閉, 則值為 1; 如果鍵盤鬆開, 則為 0
            var wasKeyDown = (flags & maskKeydown) > 0;
            //bit 31 -> 指定過渡狀態, 如果按鍵被按下, 則值為 0; 如果按鍵被釋放, 則值為 1
            var isKeyReleased = (flags & maskKeyup) > 0;

            if (!wasKeyDown && !isKeyReleased)
                yield break;

            var virtualKeyCode = (int) wParam;
            var scanCode = checked((int) (flags & maskScanCode));
            const int fuState = 0;

            KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, out char[] chars);
            if (chars == null) yield break;
            foreach (var ch in chars)
                yield return new KeyPressEventArgsExt(ch);
        }

        internal static IEnumerable<KeyPressEventArgsExt> FromRawDataGlobal(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            if ((int) wParam != Messages.WM_KEYDOWN && (int) wParam != Messages.WM_SYSKEYDOWN)
                yield break;

            var keyboardHookStruct =
                (KeyboardHookStruct) Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

            var virtualKeyCode = keyboardHookStruct.VirtualKeyCode;
            var scanCode = keyboardHookStruct.ScanCode;
            var fuState = keyboardHookStruct.Flags;

            if (virtualKeyCode == KeyboardNativeMethods.VK_PACKET)
            {
                var ch = (char) scanCode;
                yield return new KeyPressEventArgsExt(ch, keyboardHookStruct.Time);
            }
            else
            {
                KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, out char[] chars);
                if (chars == null) yield break;
                foreach (var current in chars)
                    yield return new KeyPressEventArgsExt(current, keyboardHookStruct.Time);
            }
        }
    }
}