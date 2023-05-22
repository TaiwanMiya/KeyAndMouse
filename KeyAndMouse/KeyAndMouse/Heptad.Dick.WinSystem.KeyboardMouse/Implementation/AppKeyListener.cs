using System.Collections.Generic;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    internal class AppKeyListener : KeyListener
    {
        public AppKeyListener()
            : base(HookHelper.HookAppKeyboard)
        {
        }

        protected override IEnumerable<KeyPressEventArgsExt> GetPressEventArgs(CallbackData data)
        {
            return KeyPressEventArgsExt.FromRawDataApp(data);
        }

        protected override KeyEventArgsExt GetDownUpEventArgs(CallbackData data)
        {
            return KeyEventArgsExt.FromRawDataApp(data);
        }
    }
}