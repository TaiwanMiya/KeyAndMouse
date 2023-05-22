using System;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    internal abstract class BaseListener : IDisposable
    {
        protected BaseListener(Subscribe subscribe)
        {
            Handle = subscribe(Callback);
        }

        protected HookResult Handle { get; set; }

        public void Dispose()
        {
            Handle.Dispose();
        }

        protected abstract bool Callback(CallbackData data);
    }
}