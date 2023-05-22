using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    public class HookProcedureHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private static bool _closing;

        static HookProcedureHandle()
        {
            Application.ApplicationExit += (sender, e) => { _closing = true; };
        }

        public HookProcedureHandle()
            : base(true)
        {
        }

        protected override bool ReleaseHandle()
        {
            // 注意! 在 processexit 期間調用 Unhook 會導致延遲
            if (_closing) return true;
            return HookNativeMethods.UnhookWindowsHookEx(handle) != 0;
        }
    }
}