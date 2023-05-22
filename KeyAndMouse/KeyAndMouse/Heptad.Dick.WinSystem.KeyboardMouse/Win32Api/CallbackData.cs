using System;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     回調數據
    /// </summary>
    internal struct CallbackData
    {
        public CallbackData(IntPtr wParam, IntPtr lParam)
        {
            WParam = wParam;
            LParam = lParam;
        }

        public IntPtr WParam { get; }

        public IntPtr LParam { get; }
    }
}