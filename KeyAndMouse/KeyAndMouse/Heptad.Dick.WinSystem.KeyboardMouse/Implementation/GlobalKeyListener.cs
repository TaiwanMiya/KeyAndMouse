using System.Collections.Generic;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    internal class GlobalKeyListener : KeyListener
    {
        public GlobalKeyListener()
            : base(HookHelper.HookGlobalKeyboard)
        {
        }

        protected override IEnumerable<KeyPressEventArgsExt> GetPressEventArgs(CallbackData data)
        {
            return KeyPressEventArgsExt.FromRawDataGlobal(data);
        }

        protected override KeyEventArgsExt GetDownUpEventArgs(CallbackData data)
        {
            return KeyEventArgsExt.FromRawDataGlobal(data);
        }
    }
}