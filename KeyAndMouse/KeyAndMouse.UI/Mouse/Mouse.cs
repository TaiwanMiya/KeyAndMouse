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
	public partial class Mouse : UserControl
	{
		/// <summary>
		///		鍵盤音效播放器
		/// </summary>
		internal readonly SoundPlayer MousePlayer = new SoundPlayer();

		/// <summary>
		///		按鈕開啟音效播放器
		/// </summary>
		internal readonly SoundPlayer OnPlayer = new SoundPlayer();

		/// <summary>
		///		按鈕關閉音效播放器
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

		/// <summary>
		///		鼠標 X 座標
		/// </summary>
		public int X = new int();
		/// <summary>
		///		鼠標 Y 座標
		/// </summary>
		public int Y = new int();

		internal PictureBox LeftButton;
		internal PictureBox RightButton;
		internal PictureBox MiddleButton;
		internal PictureBox X1Button;
		internal PictureBox X2Button;
		internal PictureBox WheelForward;
		internal PictureBox WheelBack;

		/// <summary>
		///		是否啟動切換式鼠標
		///		<para>
		///			啟動時: 觸發鼠標後直到再次點擊時鬆開
		///		</para>
		///		<para>
		///			關閉時: 觸發鼠標後鬆開
		///		</para>
		/// </summary>
		public bool IsToggle { get; set; } = false;

		/// <summary>
		///		是否啟用鼠標音效
		/// </summary>
		public bool IsOpenSound { get; set; } = false;

		private bool _IsOpenDetect = true;
		/// <summary>
		///		是否啟用鼠標檢測
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

		internal MouseMethods mouseMethods;

		public Mouse()
		{
			InitializeComponent();
		}
		
		private void Mouse_Load(object sender, EventArgs e)
		{
			mouseMethods = new MouseMethods(this);

			MousePlayer.Stream = Properties.Resources.click;
			OnPlayer.Stream = Properties.Resources.On;
			OffPlayer.Stream = Properties.Resources.Off;
			OnSignalPlayer.Stream = Properties.Resources.Signal_On_Music;
			OffSignalPlayer.Stream = Properties.Resources.Signal_Off_Music;
			MousePlayer.LoadAsync();
			OnPlayer.LoadAsync();
			OffPlayer.LoadAsync();
			OnSignalPlayer.LoadAsync();
			OffSignalPlayer.LoadAsync();

			ToggleSwit.Image = IsToggle ? Properties.Resources.ON_Button : Properties.Resources.OFF_Button;
			SoundSwit.Image = IsOpenSound ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			DetectSwit.Image = IsOpenDetect ? Properties.Resources.SignalOn : Properties.Resources.SignalOff;
			SettingsDetect();
		}

		/// <summary>
		///		設定檢測開關
		///		<para>
		///			依據 <see cref="IsOpenDetect"/> 變更
		///		</para>
		/// </summary>
		public void SettingsDetect()
		{
			if (mouseMethods == null) return;
				mouseMethods.SetDetect(_IsOpenDetect);
		}

		internal void MouseButton_Click(object sender, MouseEventArgs e)
		{
			Task.Run(() =>
			{
				if (!IsOpenSound) return;
				MousePlayer.Stream = Properties.Resources.click;
				MousePlayer.LoadAsync();
				MousePlayer.Play();
			});
			mouseMethods.ShowPictureByClickPos(e.X, e.Y);
		}

		internal void LeftButton_Click(object sender, EventArgs e)
		{
			if (IsToggle)
			{
				Task.Run(() =>
				{
					if (!IsOpenSound) return;
					MousePlayer.Stream = Properties.Resources.click;
					MousePlayer.LoadAsync();
					MousePlayer.Play();
				});
				LeftButton.Visible = false;
			}
			else LeftButton.Visible = false;
		}

		internal void RightButton_Click(object sender, EventArgs e)
		{
			if (IsToggle)
			{
				Task.Run(() =>
				{
					if (!IsOpenSound) return;
					MousePlayer.Stream = Properties.Resources.click;
					MousePlayer.LoadAsync();
					MousePlayer.Play();
				});
				RightButton.Visible = false;
			}
			else RightButton.Visible = false;
		}

		internal void MiddleButton_Click(object sender, EventArgs e)
		{
			if (IsToggle)
			{
				Task.Run(() =>
				{
					if (!IsOpenSound) return;
					MousePlayer.Stream = Properties.Resources.click;
					MousePlayer.LoadAsync();
					MousePlayer.Play();
				});
				MiddleButton.Visible = false;
			}
			else MiddleButton.Visible = false;
		}

		internal void X1Button_Click(object sender, EventArgs e)
		{
			if (IsToggle)
			{
				Task.Run(() =>
				{
					if (!IsOpenSound) return;
					MousePlayer.Stream = Properties.Resources.click;
					MousePlayer.LoadAsync();
					MousePlayer.Play();
				});
				X1Button.Visible = false;
			}
			else X1Button.Visible = false;
		}

		internal void X2Button_Click(object sender, EventArgs e)
		{
			if (IsToggle)
			{
				Task.Run(() =>
				{
					if (!IsOpenSound) return;
					MousePlayer.Stream = Properties.Resources.click;
					MousePlayer.LoadAsync();
					MousePlayer.Play();
				});
				X2Button.Visible = false;
			}
			else X2Button.Visible = false;
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
