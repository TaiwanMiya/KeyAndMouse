using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heptad.Dick.WinSystem.KeyboardMouse;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI.Hooks
{
	internal enum HookType
	{
		None	= 0x00,
		Keypad	= 0x01,
		Mouse	= 0x02,
		Cursor	= 0x04,
	}

	class HookEvent : IHooksEvent
	{
		internal static IKeyboardEvents KeyEvent;

		internal static IMouseEvents MouseEvent;

		public event EventHandler<HookType> Subscribe;
		public event EventHandler<HookType> UnSubscribe;

		static HookEvent()
		{
			if (KeyEvent == null)
				KeyEvent = Hook.GlobalEvents();
			if (MouseEvent == null)
				MouseEvent = Hook.GlobalEvents();
		}
	}
}
