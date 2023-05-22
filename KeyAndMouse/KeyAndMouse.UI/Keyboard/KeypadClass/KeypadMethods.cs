using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse;
using Heptad.Dick.WinSystem.KeyboardMouse.UI.Hooks;
using Heptad.Dick.WinSystem.KeyboardMouse.Code;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	class KeypadMethods
	{
		private Keypad kmKeypad;

		internal Dictionary<Keys, PictureBox> KeypadInfo;

		public KeypadMethods(Keypad keypad)
		{
			kmKeypad = keypad;
			#region 鍵盤綁定鍵位
			KeypadInfo = new Dictionary<Keys, PictureBox>
			{
				{ Keys.NumLock, kmKeypad.NumLock },
				{ Keys.Divide, kmKeypad.NumDivide },
				{ Keys.Multiply, kmKeypad.NumMultiply },
				{ Keys.Subtract, kmKeypad.NumSubtract },
				{ Keys.Add, kmKeypad.NumAdd },
				{ Keys.NumPad9, kmKeypad.Numpad9 },
				{ Keys.NumPad8, kmKeypad.Numpad8 },
				{ Keys.NumPad7, kmKeypad.Numpad7 },
				{ Keys.NumPad6, kmKeypad.Numpad6 },
				{ Keys.NumPad5, kmKeypad.Numpad5 },
				{ Keys.NumPad4, kmKeypad.Numpad4 },
				{ Keys.NumPad3, kmKeypad.Numpad3 },
				{ Keys.NumPad2, kmKeypad.Numpad2 },
				{ Keys.NumPad1, kmKeypad.Numpad1 },
				{ Keys.NumPad0, kmKeypad.Numpad0 },
				{ Keys.Decimal, kmKeypad.NumDecimal },
				{ Keys.Escape, kmKeypad.ESC },
				{ Keys.F1, kmKeypad.F1 },
				{ Keys.F2, kmKeypad.F2 },
				{ Keys.F3, kmKeypad.F3 },
				{ Keys.F4, kmKeypad.F4 },
				{ Keys.F5, kmKeypad.F5 },
				{ Keys.F6, kmKeypad.F6 },
				{ Keys.F7, kmKeypad.F7 },
				{ Keys.F8, kmKeypad.F8 },
				{ Keys.F9, kmKeypad.F9 },
				{ Keys.F10, kmKeypad.F10 },
				{ Keys.F11, kmKeypad.F11 },
				{ Keys.F12, kmKeypad.F12 },
				{ Keys.Pause, kmKeypad.Pause },
				{ Keys.Scroll, kmKeypad.ScrollLock },
				{ Keys.PrintScreen, kmKeypad.PrintScreen },
				{ Keys.PageUp, kmKeypad.PageUp },
				{ Keys.Next, kmKeypad.PageDown },
				{ Keys.Home, kmKeypad.HOME },
				{ Keys.End, kmKeypad.END },
				{ Keys.Insert, kmKeypad.Insert },
				{ Keys.Delete, kmKeypad.DELETE },
				{ Keys.Up, kmKeypad.ArrowUp },
				{ Keys.Down, kmKeypad.ArrowDown },
				{ Keys.Left, kmKeypad.ArrowLeft },
				{ Keys.Right, kmKeypad.ArrowRight },
				{ Keys.Oemtilde, kmKeypad.Ellipsis },
				{ Keys.D1, kmKeypad.D1 },
				{ Keys.D2, kmKeypad.D2 },
				{ Keys.D3, kmKeypad.D3 },
				{ Keys.D4, kmKeypad.D4 },
				{ Keys.D5, kmKeypad.D5 },
				{ Keys.D6, kmKeypad.D6 },
				{ Keys.D7, kmKeypad.D7 },
				{ Keys.D8, kmKeypad.D8 },
				{ Keys.D9, kmKeypad.D9 },
				{ Keys.D0, kmKeypad.D0 },
				{ Keys.OemMinus, kmKeypad.Subtract },
				{ Keys.Oemplus, kmKeypad.Equal },
				{ Keys.Back, kmKeypad.BackSpace },
				{ Keys.OemOpenBrackets, kmKeypad.LBracket },
				{ Keys.Oem6, kmKeypad.RBracket },
				{ Keys.A, kmKeypad.A },
				{ Keys.B, kmKeypad.B },
				{ Keys.C, kmKeypad.C },
				{ Keys.D, kmKeypad.D },
				{ Keys.E, kmKeypad.E },
				{ Keys.F, kmKeypad.F },
				{ Keys.G, kmKeypad.G },
				{ Keys.H, kmKeypad.H },
				{ Keys.I, kmKeypad.I },
				{ Keys.J, kmKeypad.J },
				{ Keys.K, kmKeypad.K },
				{ Keys.L, kmKeypad.L },
				{ Keys.M, kmKeypad.M },
				{ Keys.N, kmKeypad.N },
				{ Keys.O, kmKeypad.O },
				{ Keys.P, kmKeypad.P },
				{ Keys.Q, kmKeypad.Q },
				{ Keys.R, kmKeypad.R },
				{ Keys.S, kmKeypad.S },
				{ Keys.T, kmKeypad.T },
				{ Keys.U, kmKeypad.U },
				{ Keys.V, kmKeypad.V },
				{ Keys.W, kmKeypad.W },
				{ Keys.X, kmKeypad.X },
				{ Keys.Y, kmKeypad.Y },
				{ Keys.Z, kmKeypad.Z },
				{ Keys.Oem7, kmKeypad.Quotation },
				{ Keys.Oem1, kmKeypad.Semicolon },
				{ Keys.OemQuestion, kmKeypad.Slash },
				{ Keys.OemPeriod, kmKeypad.Dot },
				{ Keys.Oemcomma, kmKeypad.Comma },
				{ Keys.Oem5, kmKeypad.BackSlash },
				{ Keys.Return, kmKeypad.Enter },
				{ Keys.Tab, kmKeypad.TAB },
				{ Keys.Capital, kmKeypad.CapsLock },
				{ Keys.LControlKey, kmKeypad.LControlKey },
				{ Keys.RControlKey, kmKeypad.RControlKey },
				{ Keys.LWin, kmKeypad.LWindowsKey },
				{ Keys.RWin, kmKeypad.RWindowsKey },
				{ Keys.LMenu, kmKeypad.LAltKey },
				{ Keys.RMenu, kmKeypad.RAltKey },
				{ Keys.LShiftKey, kmKeypad.LShiftKey },
				{ Keys.RShiftKey, kmKeypad.RShiftKey },
				{ Keys.Space, kmKeypad.Space }
			};
			#endregion
		}

		internal void SetDetect(bool DetectOpen)
		{
			if (DetectOpen)
			{
				if (HookEvent.KeyEvent == null)
					HookEvent.KeyEvent = Hook.GlobalEvents();
				HookEvent.KeyEvent.KeyDown += KeypadEvent_KeyDown;
				HookEvent.KeyEvent.KeyUp += KeypadEvent_KeyUp;
			}
			else
			{
				if (HookEvent.KeyEvent == null) return;
				HookEvent.KeyEvent.KeyDown -= KeypadEvent_KeyDown;
				HookEvent.KeyEvent.KeyUp -= KeypadEvent_KeyUp;
			}
		}

		internal void CheakToggleKeys()
		{
			short CapsStatus = KeyboardNativeMethods.GetKeyState(Keycode.CAPS.virtualcode);
			kmKeypad.CapsLockLight.Image = CapsStatus == 1 ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
			short ScrollStatus = KeyboardNativeMethods.GetKeyState(Keycode.SCROLL.virtualcode);
			kmKeypad.ScrollLockLight.Image = ScrollStatus == 1 ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
			short NumLockStatus = KeyboardNativeMethods.GetKeyState(Keycode.NUMLOCK.virtualcode);
			kmKeypad.NumLockLight.Image = NumLockStatus == 1 ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
		}

		private async void KeypadEvent_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if ((string)KeypadInfo[e.KeyCode].Tag == "DOWN") return;
				SwitchPictureByPictureBox(KeypadInfo[e.KeyCode], true, true);
				_ = Task.Run(() =>
				  {
					  if (!kmKeypad.IsOpenSound) return;
					  kmKeypad.KeyPadPlayer.Play();
				  });
			}
			catch (KeyNotFoundException) { }
			await Task.Delay(1);
			CheakToggleKeys();
		}

		private async void KeypadEvent_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				SwitchPictureByPictureBox(KeypadInfo[e.KeyCode], true, false);
				_ = Task.Run(() =>
				  {
					  if (!kmKeypad.IsOpenSound) return;
					  kmKeypad.KeyPadPlayer.Play();
				  });
			}
			catch (KeyNotFoundException) { }
			await Task.Delay(1);
			CheakToggleKeys();
		}

		internal async void SwitchPictureByPictureBox(PictureBox pic, bool IsDetect = false, bool IsKeyDown = false)
		{
			Size size = new Size(pic.Width, pic.Height);

			if (kmKeypad.IsToggle && !IsDetect)
			{
				if (size == new Size(50, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Down : Properties.Resources.Up;
				else if (size == new Size(50, 106))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Height_Down : Properties.Resources.Height_Up;
				else if (size == new Size(67, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width1_Down : Properties.Resources.Width1_Up;
				else if (size == new Size(89, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width2_Down : Properties.Resources.Width2_Up;
				else if (size == new Size(106, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width3_Down : Properties.Resources.Width3_Up;
				else if (size == new Size(123, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width4_Down : Properties.Resources.Width4_Up;
				else if (size == new Size(133, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width5_Down : Properties.Resources.Width5_Up;
				else if (size == new Size(386, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width6_Down : Properties.Resources.Width6_Up;

				pic.Tag = (string)pic.Tag == "UP" ? "DOWN" : "UP";

				CaseFunctionKey(pic.Name);
			}
			else if (IsDetect)
			{
				if (size == new Size(50, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Down : Properties.Resources.Up;
				else if (size == new Size(50, 106))
					pic.Image = IsKeyDown ? Properties.Resources.Height_Down : Properties.Resources.Height_Up;
				else if (size == new Size(67, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width1_Down : Properties.Resources.Width1_Up;
				else if (size == new Size(89, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width2_Down : Properties.Resources.Width2_Up;
				else if (size == new Size(106, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width3_Down : Properties.Resources.Width3_Up;
				else if (size == new Size(123, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width4_Down : Properties.Resources.Width4_Up;
				else if (size == new Size(133, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width5_Down : Properties.Resources.Width5_Up;
				else if (size == new Size(386, 50))
					pic.Image = IsKeyDown ? Properties.Resources.Width6_Down : Properties.Resources.Width6_Up;

				pic.Tag = IsKeyDown ? "DOWN" : "UP";

				CaseFunctionKey(pic.Name);
			}
			else
			{
				if (size == new Size(50, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(50, 106))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Height_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Height_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(67, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width1_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width1_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(89, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width2_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width2_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(106, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width3_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width3_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(123, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width4_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width4_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(133, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width5_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width5_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(386, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width6_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width6_Up;
					CaseFunctionKey(pic.Name);
				}
			}
		}

		internal async void SwitchPictureByLabel(Label label)
		{
			PictureBox pic = label.Parent as PictureBox;

			Size size = pic.Size;

			if (kmKeypad.IsToggle)
			{
				if (size == new Size(50, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Down : Properties.Resources.Up;
				else if (size == new Size(50, 106))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Height_Down : Properties.Resources.Height_Up;
				else if (size == new Size(67, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width1_Down : Properties.Resources.Width1_Up;
				else if (size == new Size(89, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width2_Down : Properties.Resources.Width2_Up;
				else if (size == new Size(106, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width3_Down : Properties.Resources.Width3_Up;
				else if (size == new Size(123, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width4_Down : Properties.Resources.Width4_Up;
				else if (size == new Size(133, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width5_Down : Properties.Resources.Width5_Up;
				else if (size == new Size(386, 50))
					pic.Image = (string)pic.Tag == "UP" ? Properties.Resources.Width6_Down : Properties.Resources.Width6_Up;

				pic.Tag = (string)pic.Tag == "UP" ? "DOWN" : "UP";

				CaseFunctionKey(pic.Name);
			}
			else
			{
				if (size == new Size(50, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(50, 106))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Height_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Height_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(67, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width1_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width1_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(89, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width2_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width2_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(106, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width3_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width3_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(123, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width4_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width4_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(133, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width5_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width5_Up;
					CaseFunctionKey(pic.Name);
				}
				else if (size == new Size(386, 50))
				{
					pic.Tag = "DOWN";
					pic.Image = Properties.Resources.Width6_Down;
					CaseFunctionKey(pic.Name);
					await Task.Delay(TimeSpan.FromMilliseconds(150));
					pic.Tag = "UP";
					pic.Image = Properties.Resources.Width6_Up;
					CaseFunctionKey(pic.Name);
				}
			}
		}

		internal void CaseFunctionKey(string name)
		{
			switch (name)
			{
				case "LControlKey":
					kmKeypad._CtrlDown = (string)kmKeypad.LControlKey.Tag == "DOWN";
					kmKeypad.ControlKeyLight.Image = kmKeypad._CtrlDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "RControlKey":
					kmKeypad._CtrlDown = (string)kmKeypad.RControlKey.Tag == "DOWN";
					kmKeypad.ControlKeyLight.Image = kmKeypad._CtrlDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "LAltKey":
					kmKeypad._AltDown = (string)kmKeypad.LAltKey.Tag == "DOWN";
					kmKeypad.AltKeyLight.Image = kmKeypad._AltDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "RAltKey":
					kmKeypad._AltDown = (string)kmKeypad.RAltKey.Tag == "DOWN";
					kmKeypad.AltKeyLight.Image = kmKeypad._AltDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "LShiftKey":
					kmKeypad._ShiftDown = (string)kmKeypad.LShiftKey.Tag == "DOWN";
					kmKeypad.ShiftKeyLight.Image = kmKeypad._ShiftDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "RShiftKey":
					kmKeypad._ShiftDown = (string)kmKeypad.RShiftKey.Tag == "DOWN";
					kmKeypad.ShiftKeyLight.Image = kmKeypad._ShiftDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbLControlKey":
					kmKeypad._CtrlDown = (string)kmKeypad.LControlKey.Tag == "DOWN";
					kmKeypad.ControlKeyLight.Image = kmKeypad._CtrlDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbRControlKey":
					kmKeypad._CtrlDown = (string)kmKeypad.RControlKey.Tag == "DOWN";
					kmKeypad.ControlKeyLight.Image = kmKeypad._CtrlDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbLAltKey":
					kmKeypad._AltDown = (string)kmKeypad.LAltKey.Tag == "DOWN";
					kmKeypad.AltKeyLight.Image = kmKeypad._AltDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbRAltKey":
					kmKeypad._AltDown = (string)kmKeypad.RAltKey.Tag == "DOWN";
					kmKeypad.AltKeyLight.Image = kmKeypad._AltDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbLShiftKey":
					kmKeypad._ShiftDown = (string)kmKeypad.LShiftKey.Tag == "DOWN";
					kmKeypad.ShiftKeyLight.Image = kmKeypad._ShiftDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;
				case "lbRShiftKey":
					kmKeypad._ShiftDown = (string)kmKeypad.RShiftKey.Tag == "DOWN";
					kmKeypad.ShiftKeyLight.Image = kmKeypad._ShiftDown ? Properties.Resources.Lamp_Green : Properties.Resources.Lamp_Grey;
					break;

			}
		}
	}
}
