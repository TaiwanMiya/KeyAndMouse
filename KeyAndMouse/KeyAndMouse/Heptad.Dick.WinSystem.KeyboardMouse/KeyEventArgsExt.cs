using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     提供以下參數的擴展數據
    ///     <list type="bullet">
    ///         <item>
    ///             <see cref='KeyListener.KeyDown' />
    ///         </item>
    ///         <item>
    ///             <see cref='KeyListener.KeyUp' />
    ///         </item>
    ///     </list>
    /// </summary>
    public class KeyEventArgsExt : KeyEventArgs
    {
        /// <summary>
        ///     <para>
        ///         初始化一個新的實例
        ///     </para>
        ///     <para>
        ///         <see cref="KeyEventArgsExt" />
        ///     </para>
        /// </summary>
        /// 
        /// <param name="keyData">鍵盤數據</param>
        public KeyEventArgsExt(Keys keyData)
            : base(keyData)
        {
        }

        internal KeyEventArgsExt(Keys keyData, int scanCode, int timestamp, bool isKeyDown, bool isKeyUp,
            bool isExtendedKey)
            : this(keyData)
        {
            ScanCode = scanCode;
            Timestamp = timestamp;
            IsKeyDown = isKeyDown;
            IsKeyUp = isKeyUp;
            IsExtendedKey = isExtendedKey;
        }

        /// <summary>
        /// 鍵盤掃描碼
        /// </summary>
        public int ScanCode { get; }

        /// <summary>
        /// 事件發生時的系統計數
        /// </summary>
        public int Timestamp { get; }

        /// <summary>
        /// 如果事件發出按鍵按下的信號, 則為 <b>true</b>
        /// </summary>
        public bool IsKeyDown { get; }

        /// <summary>
        /// 如果事件發出按鍵鬆開的信號, 則為 <b>true</b>
        /// </summary>
        public bool IsKeyUp { get; }

        /// <summary>
        /// 如果該事件是擴展鍵, 則為 <b>true</b>
        /// </summary>
        public bool IsExtendedKey { get; }

        internal static KeyEventArgsExt FromRawDataApp(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;

            const uint maskKeydown = 0x40000000;    // bit 30
            const uint maskKeyup = 0x80000000;      // bit 31
            const uint maskExtendedKey = 0x1000000; // bit 24

            var timestamp = Environment.TickCount;

            var flags = (uint) lParam.ToInt64();

            //bit 30 指定前一個鍵狀態, 如果在發送消息之前鍵已關閉, 則值為 1; 如果密鑰向上, 則為 0
            var wasKeyDown = (flags & maskKeydown) > 0;
            //bit 31 指定過渡狀態, 如果按鍵被按下, 則值為 0; 如果按鍵被釋放, 則值為 1
            var isKeyReleased = (flags & maskKeyup) > 0;
            //bit 24 指定擴展鍵狀態, 如果鍵是擴展鍵, 則值為 1; 否則值為 0
            var isExtendedKey = (flags & maskExtendedKey) > 0;


            var keyData = AppendModifierStates((Keys) wParam);
            var scanCode = (int) (((flags & 0x10000) | (flags & 0x20000) | (flags & 0x40000) | (flags & 0x80000) |
                                   (flags & 0x100000) | (flags & 0x200000) | (flags & 0x400000) | (flags & 0x800000)) >>
                                  16);

            var isKeyDown = !isKeyReleased;
            var isKeyUp = wasKeyDown && isKeyReleased;

            return new KeyEventArgsExt(keyData, scanCode, timestamp, isKeyDown, isKeyUp, isExtendedKey);
        }

        internal static KeyEventArgsExt FromRawDataGlobal(CallbackData data)
        {
            var wParam = data.WParam;
            var lParam = data.LParam;
            var keyboardHookStruct =
                (KeyboardHookStruct) Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

            var keyData = AppendModifierStates((Keys) keyboardHookStruct.VirtualKeyCode);

            var keyCode = (int) wParam;
            var isKeyDown = keyCode == Messages.WM_KEYDOWN || keyCode == Messages.WM_SYSKEYDOWN;
            var isKeyUp = keyCode == Messages.WM_KEYUP || keyCode == Messages.WM_SYSKEYUP;

            const uint maskExtendedKey = 0x1;
            var isExtendedKey = (keyboardHookStruct.Flags & maskExtendedKey) > 0;

            return new KeyEventArgsExt(keyData, keyboardHookStruct.ScanCode, keyboardHookStruct.Time, isKeyDown,
                isKeyUp, isExtendedKey);
        }
        
        /// <summary>
        /// 檢查修飾符
        /// </summary>
        private static bool CheckModifier(int vKey)
        {
            return (KeyboardNativeMethods.GetKeyState(vKey) & 0x8000) > 0;
        }

        private static Keys AppendModifierStates(Keys keyData)
        {
            // Ctrl 是否被按住
            var control = CheckModifier(KeyboardNativeMethods.VK_CONTROL);
            // Shift 是否被按住
            var shift = CheckModifier(KeyboardNativeMethods.VK_SHIFT);
            // Alt 是否被按住
            var alt = CheckModifier(KeyboardNativeMethods.VK_MENU);

            return keyData |
                   (control ? Keys.Control : Keys.None) |
                   (shift ? Keys.Shift : Keys.None) |
                   (alt ? Keys.Alt : Keys.None);
        }
    }
}