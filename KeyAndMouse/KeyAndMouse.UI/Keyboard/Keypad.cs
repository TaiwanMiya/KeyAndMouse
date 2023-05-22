using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	/// <summary>
	///		鍵盤的狀態
	/// </summary>
	public enum KeypadType
	{
		/// <summary>
		///		沒有此按鍵
		/// </summary>
		NoSuch = 0x00,
		/// <summary>
		///		按下中
		/// </summary>
		Down = 0x01,
		/// <summary>
		///		鬆開中
		/// </summary>
		Up = 0x02,
	}

	/// <summary>
	///		鍵盤介面
	/// </summary>
	public partial class Keypad : UserControl
	{
		/// <summary>
		///		鍵盤音效播放器
		/// </summary>
		internal readonly SoundPlayer KeyPadPlayer = new SoundPlayer();

		/// <summary>
		///		鍵盤鎖定按鈕開啟音效播放器
		/// </summary>
		internal readonly SoundPlayer OnPlayer = new SoundPlayer();

		/// <summary>
		///		鍵盤鎖定按鈕關閉音效播放器
		/// </summary>
		internal readonly SoundPlayer OffPlayer = new SoundPlayer();

		/// <summary>
		///		鍵盤音效按鈕開啟音效播放器
		/// </summary>
		internal readonly SoundPlayer OnSignalPlayer = new SoundPlayer();

		/// <summary>
		///		鍵盤音效按鈕關閉音效播放器
		/// </summary>
		internal readonly SoundPlayer OffSignalPlayer = new SoundPlayer();

		internal bool _CapsLockSwit;
		/// <summary>
		///		是否啟用大寫鎖定
		/// </summary>
		public bool CapsLockSwit => _CapsLockSwit = false;

		internal bool _ScrollLockSwit;
		/// <summary>
		///		是否啟用滾動鎖定
		/// </summary>
		public bool ScrollLockSwit => _ScrollLockSwit = false;

		internal bool _NumLockSwit;
		/// <summary>
		///		是否啟用數字鎖定
		/// </summary>
		public bool NumLockSwit => _NumLockSwit = false;

		internal bool _CtrlDown;
		/// <summary>
		///		是否按下Ctrl鍵
		/// </summary>
		public bool CtrlDown => _CtrlDown = false;

		internal bool _AltDown;
		/// <summary>
		///		是否按下Alt鍵
		/// </summary>
		public bool AltDown => _AltDown = false;

		internal bool _ShiftDown;
		/// <summary>
		///		是否按下Shift鍵
		/// </summary>
		public bool ShiftDown => _ShiftDown = false;

		/// <summary>
		///		是否啟動切換式鍵盤
		///		<para>
		///			啟動時: 觸發鍵盤後直到再次點擊時鬆開
		///		</para>
		///		<para>
		///			關閉時: 觸發鍵盤後鬆開
		///		</para>
		/// </summary>
		public bool IsToggle { get; set; } = false;

		/// <summary>
		///		是否啟用鍵盤音效
		/// </summary>
		public bool IsOpenSound { get; set; } = false;

		private bool _IsOpenDetect = true;
		/// <summary>
		///		是否啟用鍵盤檢測
		/// </summary>
		public bool IsOpenDetect
		{
			get
			{
				return _IsOpenDetect;
			}
			set
			{
				_IsOpenDetect = value;
			}
		}

		internal KeypadMethods keypadMethods;

		internal PictureBox[] pictureBoxes;

		/// <summary>
		///		鍵盤介面
		/// </summary>
		public Keypad()
		{
			InitializeComponent();
			pictureBoxes = new PictureBox[]
			{
				this.NumLock,
				this.NumDivide,
				this.NumMultiply,
				this.NumSubtract,
				this.Numpad9,
				this.Numpad8,
				this.Numpad7,
				this.Numpad6,
				this.Numpad5,
				this.Numpad4,
				this.Numpad3,
				this.Numpad2,
				this.Numpad1,
				this.NumDecimal,
				this.Numpad0,
				this.NumAdd,
				this.NumEnter,
				this.ESC,
				this.F4,
				this.F3,
				this.F2,
				this.F1,
				this.F8,
				this.F7,
				this.F6,
				this.F5,
				this.F12,
				this.F11,
				this.F10,
				this.F9,
				this.Pause,
				this.ScrollLock,
				this.PrintScreen,
				this.PageUp,
				this.HOME,
				this.Insert,
				this.PageDown,
				this.END,
				this.DELETE,
				this.ArrowRight,
				this.ArrowDown,
				this.ArrowLeft,
				this.ArrowUp,
				this.Ellipsis,
				this.D1,
				this.D2,
				this.D5,
				this.D4,
				this.D3,
				this.D8,
				this.D7,
				this.D6,
				this.Subtract,
				this.D0,
				this.D9,
				this.Equal,
				this.BackSpace,
				this.RBracket,
				this.LBracket,
				this.P,
				this.O,
				this.I,
				this.U,
				this.Y,
				this.T,
				this.R,
				this.E,
				this.W,
				this.Q,
				this.Quotation,
				this.Semicolon,
				this.L,
				this.K,
				this.J,
				this.H,
				this.G,
				this.F,
				this.D,
				this.S,
				this.A,
				this.Slash,
				this.Dot,
				this.Comma,
				this.M,
				this.N,
				this.B,
				this.V,
				this.C,
				this.X,
				this.Z,
				this.BackSlash,
				this.Enter,
				this.TAB,
				this.CapsLock,
				this.LControlKey,
				this.RControlKey,
				this.LWindowsKey,
				this.LAltKey,
				this.RWindowsKey,
				this.RAltKey,
				this.Space,
				this.LShiftKey,
				this.RShiftKey,
			};
			KeypadNames GetNames = new KeypadNames();
			GetNames.LoadNames(this);
		}

		private void Keypad_Load(object sender, EventArgs e)
		{
			keypadMethods = new KeypadMethods(this);
			KeyPadPlayer.Stream = Properties.Resources.press;
			OnPlayer.Stream = Properties.Resources.On;
			OffPlayer.Stream = Properties.Resources.Off;
			OnSignalPlayer.Stream = Properties.Resources.Signal_On_Music;
			OffSignalPlayer.Stream = Properties.Resources.Signal_Off_Music;
			KeyPadPlayer.LoadAsync();
			OnPlayer.LoadAsync();
			OffPlayer.LoadAsync();
			OnSignalPlayer.LoadAsync();
			OffSignalPlayer.LoadAsync();

			ToggleSwit.Image = IsToggle ? Properties.Resources.ON_Button : Properties.Resources.OFF_Button;
			SoundSwit.Image = IsOpenSound ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			DetectSwit.Image = IsOpenDetect ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			keypadMethods.CheakToggleKeys();
			SettingsDetect();
		}

		/// <summary>
		///		檢測鍵盤狀態
		/// </summary>
		/// 
		/// <param name="key">
		///		按鍵
		/// </param>
		/// 
		/// <returns>
		///		<see cref="KeypadType"/> 的狀態
		/// </returns>
		public KeypadType KeyInfo(Keys key)
		{
			if (keypadMethods.KeypadInfo.ContainsKey(key))
			{
				switch ((KeypadType)keypadMethods.KeypadInfo[key].Tag)
				{
					case KeypadType.Down:
						return KeypadType.Down;
					case KeypadType.Up:
						return KeypadType.Up;
					default:
						return KeypadType.NoSuch;
				}
			}
			return KeypadType.NoSuch;
		}

		/// <summary>
		///		設定檢測開關
		///		<para>
		///			依據 <see cref="IsOpenDetect"/> 變更
		///		</para>
		/// </summary>
		public void SettingsDetect()
		{
			if (keypadMethods == null) return;
				keypadMethods.SetDetect(_IsOpenDetect);
		}

		internal void KeyPads_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				if (!IsOpenSound) return;
				KeyPadPlayer.Play();
			});
			keypadMethods.SwitchPictureByPictureBox((PictureBox)sender);
			switch (((PictureBox)sender).Name)
			{
				case "CapsLock":
					_CapsLockSwit = !_CapsLockSwit;
					CapsLockLight.Image = _CapsLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
				case "ScrollLock":
					_ScrollLockSwit = !_ScrollLockSwit;
					ScrollLockLight.Image = _ScrollLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
				case "NumLock":
					_NumLockSwit = !_NumLockSwit;
					NumLockLight.Image = _NumLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
			}
		}

		internal void KeyPadsText_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				if (!IsOpenSound) return;
				KeyPadPlayer.Stream = Properties.Resources.press;
				KeyPadPlayer.LoadAsync();
				KeyPadPlayer.Play();
			});
			keypadMethods.SwitchPictureByLabel((Label)sender);
			switch (((Label)sender).Name)
			{
				case "lbCapsLock":
					_CapsLockSwit = !_CapsLockSwit;
					CapsLockLight.Image = _CapsLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
				case "lbScrollLock":
					_ScrollLockSwit = !_ScrollLockSwit;
					ScrollLockLight.Image = _ScrollLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
				case "lbNumLock":
					_NumLockSwit = !_NumLockSwit;
					NumLockLight.Image = _NumLockSwit ? Properties.Resources.Lamp_Red : Properties.Resources.Lamp_Grey;
					break;
			}
		}

		private void ToggleSwit_Click(object sender, EventArgs e)
		{
			IsToggle = !IsToggle;
			ToggleSwit.Image = IsToggle ? Properties.Resources.ON_Button : Properties.Resources.OFF_Button;

			Task.Run(() =>
			{
				if (!IsOpenSound) return;
				if (IsToggle)
					OnPlayer.Play();
				else
					OffPlayer.Play();
			});
		}

		private void SoundSwit_Click(object sender, EventArgs e)
		{
			IsOpenSound = !IsOpenSound;
			SoundSwit.Image = IsOpenSound ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			Task.Run(() =>
			{
				if (IsOpenSound)
					OnSignalPlayer.Play();
				else
					OffSignalPlayer.Play();
			});
		}

		private void DetectSwit_Click(object sender, EventArgs e)
		{
			IsOpenDetect = !IsOpenDetect;
			keypadMethods.CheakToggleKeys();
			DetectSwit.Image = IsOpenDetect ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			SettingsDetect();
			Task.Run(() =>
			{
				if (!IsOpenSound) return;
				if (IsOpenDetect)
					OnSignalPlayer.Play();
				else
					OffSignalPlayer.Play();
			});
		}
	}
}
