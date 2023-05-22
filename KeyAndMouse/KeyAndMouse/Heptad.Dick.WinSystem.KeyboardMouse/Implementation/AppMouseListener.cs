using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    internal class AppMouseListener : MouseListener
    {
        public AppMouseListener()
            : base(HookHelper.HookAppMouse)
        {
        }

        protected override MouseEventExtArgs GetEventArgs(CallbackData data)
        {
            return MouseEventExtArgs.FromRawDataApp(data);
        }
    }
}