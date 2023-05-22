using System;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    internal class HookResult : IDisposable
    {
        public HookResult(HookProcedureHandle handle, HookProcedure procedure)
        {
            Handle = handle;
            Procedure = procedure;
        }

        public HookProcedureHandle Handle { get; }

        public HookProcedure Procedure { get; }

        public void Dispose()
        {
            Handle.Dispose();
        }
    }
}