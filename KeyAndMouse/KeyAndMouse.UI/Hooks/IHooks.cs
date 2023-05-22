using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI.Hooks
{
	interface IHooksEvent
	{
		event EventHandler<HookType> Subscribe;

		event EventHandler<HookType> UnSubscribe;
	}
}
