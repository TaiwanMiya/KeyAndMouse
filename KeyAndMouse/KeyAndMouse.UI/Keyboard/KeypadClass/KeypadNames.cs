using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	class KeypadNames
	{
		internal void LoadNames(Keypad keypad)
		{
			foreach (var pic in keypad.pictureBoxes)
			{
				Label label = new Label
				{
					Name = "lb" + pic.Name,
					Parent = pic,
					BackColor = Color.Transparent,
					ForeColor = Color.White,
					Font = new Font("Arial", 10, FontStyle.Bold),
					AutoSize = true,
					TextAlign = ContentAlignment.MiddleCenter,
					UseMnemonic = false,
				};
				switch (pic.Name)
				{
					case "ESC":
						label.Text = "ESC";
						break;
					case "F1":
						label.Text = "F1";
						break;
					case "F2":
						label.Text = "F2";
						break;
					case "F3":
						label.Text = "F3";
						break;
					case "F4":
						label.Text = "F4";
						break;
					case "F5":
						label.Text = "F5";
						break;
					case "F6":
						label.Text = "F6";
						break;
					case "F7":
						label.Text = "F7";
						break;
					case "F8":
						label.Text = "F8";
						break;
					case "F9":
						label.Text = "F9";
						break;
					case "F10":
						label.Text = "F10";
						break;
					case "F11":
						label.Text = "F11";
						break;
					case "F12":
						label.Text = "F12";
						break;
					case "D0":
						label.Text = "0\n)";
						break;
					case "D1":
						label.Text = "1\n!";
						break;
					case "D2":
						label.Text = "2\n@";
						break;
					case "D3":
						label.Text = "3\n#";
						break;
					case "D4":
						label.Text = "4\n$";
						break;
					case "D5":
						label.Text = "5\n%";
						break;
					case "D6":
						label.Text = "6\n^";
						break;
					case "D7":
						label.Text = "7\n&";
						break;
					case "D8":
						label.Text = "8\n*";
						break;
					case "D9":
						label.Text = "9\n(";
						break;
					case "Numpad0":
						label.Text = "0\nINS";
						break;
					case "Numpad1":
						label.Text = "1\nEND";
						break;
					case "Numpad2":
						label.Text = "2\n↓";
						break;
					case "Numpad3":
						label.Text = "3\nPage\nDown";
						break;
					case "Numpad4":
						label.Text = "4\n←";
						break;
					case "Numpad5":
						label.Text = "5";
						break;
					case "Numpad6":
						label.Text = "6\n→";
						break;
					case "Numpad7":
						label.Text = "7\nHOME";
						break;
					case "Numpad8":
						label.Text = "8\n↑";
						break;
					case "Numpad9":
						label.Text = "9\nPage\nUp";
						break;
					case "A":
						label.Text = "A";
						break;
					case "B":
						label.Text = "B";
						break;
					case "C":
						label.Text = "C";
						break;
					case "D":
						label.Text = "D";
						break;
					case "E":
						label.Text = "E";
						break;
					case "F":
						label.Text = "F";
						break;
					case "G":
						label.Text = "G";
						break;
					case "H":
						label.Text = "H";
						break;
					case "I":
						label.Text = "I";
						break;
					case "J":
						label.Text = "J";
						break;
					case "K":
						label.Text = "K";
						break;
					case "L":
						label.Text = "L";
						break;
					case "M":
						label.Text = "M";
						break;
					case "N":
						label.Text = "N";
						break;
					case "O":
						label.Text = "O";
						break;
					case "P":
						label.Text = "P";
						break;
					case "Q":
						label.Text = "Q";
						break;
					case "R":
						label.Text = "R";
						break;
					case "S":
						label.Text = "S";
						break;
					case "T":
						label.Text = "T";
						break;
					case "U":
						label.Text = "U";
						break;
					case "V":
						label.Text = "V";
						break;
					case "W":
						label.Text = "W";
						break;
					case "X":
						label.Text = "X";
						break;
					case "Y":
						label.Text = "Y";
						break;
					case "Z":
						label.Text = "Z";
						break;
					case "NumLock":
						label.Text = "NUM\nLOCK";
						break;
					case "Enter":
						label.Text = "↩\nENTER";
						break;
					case "NumEnter":
						label.Text = "ENTER";
						break;
					case "BackSpace":
						label.Text = "←\nBACK";
						break;
					case "Space":
						label.Text = "‾";
						break;
					case "TAB":
						label.Text = "⇆\nTAB";
						break;
					case "LShiftKey":
						label.Text = "⇑   SHIFT";
						break;
					case "RShiftKey":
						label.Text = "⇑   SHIFT";
						break;
					case "LControlKey":
						label.Text = "CTRL";
						break;
					case "RControlKey":
						label.Text = "CTRL";
						break;
					case "LAltKey":
						label.Text = "ALT";
						break;
					case "RAltKey":
						label.Text = "ALT";
						break;
					case "LWindowsKey":
						label.Text = "WIN";
						break;
					case "RWindowsKey":
						label.Text = "WIN";
						break;
					case "Ellipsis":
						label.Text = "`\n~";
						break;
					case "BackSlash":
						label.Text = "\\\n|";
						break;
					case "Subtract":
						label.Text = "-\n_";
						break;
					case "Equal":
						label.Text = "=\n+";
						break;
					case "LBracket":
						label.Text = "[\n{";
						break;
					case "RBracket":
						label.Text = "]\n}";
						break;
					case "Semicolon":
						label.Text = ";\n:";
						break;
					case "Quotation":
						label.Text = "'\n\"";
						break;
					case "Comma":
						label.Text = ",\n<";
						break;
					case "Dot":
						label.Text = ".\n>";
						break;
					case "Slash":
						label.Text = "/\n?";
						break;
					case "PrintScreen":
						label.Text = " PRT\nSCR";
						break;
					case "ScrollLock":
						label.Text = "SCR\nLOCK";
						break;
					case "Pause":
						label.Text = "PAUSE";
						break;
					case "Insert":
						label.Text = "INS";
						break;
					case "HOME":
						label.Text = "HOME";
						break;
					case "PageUp":
						label.Text = "Page\nUp";
						break;
					case "PageDown":
						label.Text = "Page\nDown";
						break;
					case "END":
						label.Text = "END";
						break;
					case "DELETE":
						label.Text = "DEL";
						break;
					case "CapsLock":
						label.Text = "CAPS\nLOCK";
						break;
					case "NumAdd":
						label.Text = "+";
						break;
					case "NumSubtract":
						label.Text = "-";
						break;
					case "NumMultiply":
						label.Text = "*";
						break;
					case "NumDivide":
						label.Text = "/";
						break;
					case "NumDecimal":
						label.Text = ".\nDEL";
						break;
					case "ArrowUp":
						label.Text = "↑";
						break;
					case "ArrowDown":
						label.Text = "↓";
						break;
					case "ArrowLeft":
						label.Text = "←";
						break;
					case "ArrowRight":
						label.Text = "→";
						break;
					default:
						label.Text = string.Empty;
						break;
				}
				label.Location = new Point(pic.Width / 2 - label.Width / 2, pic.Height / 2 - label.Height / 2);
				label.Click += keypad.KeyPadsText_Click;
			}
		}
	}
}
