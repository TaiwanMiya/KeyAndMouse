using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Heptad.Dick.WinSystem.KeyboardMouse;
using Heptad.Dick.WinSystem.KeyboardMouse.UI.Hooks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	class MouseMethods
	{
		private Mouse kmMouse;

		public MouseMethods(Mouse mouse)
		{
			kmMouse = mouse;
			#region 鼠標圖片載入
			kmMouse.WheelForward = new PictureBox()
			{
				Name = "WheelForward",
				Size = new Size(20, 22),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_Wheel_Forward,
				Location = new Point(115, 32),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.WheelBack = new PictureBox()
			{
				Name = "WheelBack",
				Size = new Size(20, 22),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_Wheel_Back,
				Location = new Point(115, 53),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.MiddleButton = new PictureBox()
			{
				Name = "MiddleButton",
				Size = new Size(20, 45),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_Middle,
				Location = new Point(115, 32),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.LeftButton = new PictureBox()
			{
				Name = "LeftButton",
				Size = new Size(70, 95),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_Left,
				Location = new Point(53, 8),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.RightButton = new PictureBox()
			{
				Name = "RightButton",
				Size = new Size(70, 95),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_Right,
				Location = new Point(127, 8),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.X1Button = new PictureBox()
			{
				Name = "X1Button",
				Size = new Size(10, 30),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_XButton1,
				Location = new Point(37, 135),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.X2Button = new PictureBox()
			{
				Name = "X2Button",
				Size = new Size(10, 30),
				Parent = kmMouse.Mouses,
				BackColor = Color.Transparent,
				Image = Properties.Resources.Mouse_XButton2,
				Location = new Point(38, 95),
				TabIndex = 1,
				Visible = false
			};
			kmMouse.Mouses.MouseClick += kmMouse.MouseButton_Click;
			kmMouse.LeftButton.Click += kmMouse.LeftButton_Click;
			kmMouse.RightButton.Click += kmMouse.RightButton_Click;
			kmMouse.MiddleButton.Click += kmMouse.MiddleButton_Click;
			kmMouse.X1Button.Click += kmMouse.X1Button_Click;
			kmMouse.X2Button.Click += kmMouse.X2Button_Click;
			#endregion
		}

		internal void SetDetect(bool DetectOpen)
		{
			if (DetectOpen)
			{
				if (HookEvent.MouseEvent == null)
					HookEvent.MouseEvent = Hook.GlobalEvents();
				HookEvent.MouseEvent.MouseDown += MouseEvent_MouseDown;
				HookEvent.MouseEvent.MouseUp += MouseEvent_MouseUp;
				HookEvent.MouseEvent.MouseMove += MouseEvent_MouseMove;
				HookEvent.MouseEvent.MouseWheel += MouseEvent_MouseWheel;
			}
			else
			{
				if (HookEvent.MouseEvent == null) return;
				HookEvent.MouseEvent.MouseDown -= MouseEvent_MouseDown;
				HookEvent.MouseEvent.MouseUp -= MouseEvent_MouseUp;
				HookEvent.MouseEvent.MouseMove -= MouseEvent_MouseMove;
				HookEvent.MouseEvent.MouseWheel -= MouseEvent_MouseWheel;
			}
		}

		private void MouseEvent_MouseDown(object sender, MouseEventArgs e)
		{
			ShowPictureByMouseButton(e.Button, true);
			Task.Run(() =>
			{
				if (!kmMouse.IsOpenSound) return;
				kmMouse.MousePlayer.Play();
			});
		}

		private void MouseEvent_MouseUp(object sender, MouseEventArgs e)
		{
			ShowPictureByMouseButton(e.Button, false);
			Task.Run(() =>
			{
				if (!kmMouse.IsOpenSound) return;
				kmMouse.MousePlayer.Play();
			});
		}

		private void MouseEvent_MouseMove(object sender, MouseEventArgs e)
		{
			SwitchPictureByMousePos(e.X, e.Y);
			kmMouse.X = e.X;
			kmMouse.Y = e.Y;
		}

		private void MouseEvent_MouseWheel(object sender, MouseEventArgs e)
		{
			ShowPictureByMouseWheel(e.Delta);
		}

		internal async void ShowPictureByClickPos(int x, int y)
		{
			if (x >= kmMouse.LeftButton.Location.X &&
				x <= kmMouse.LeftButton.Location.X + kmMouse.LeftButton.Size.Width &&
				y >= kmMouse.LeftButton.Location.Y &&
				y <= kmMouse.LeftButton.Location.Y + kmMouse.LeftButton.Size.Height)
			{
				if (kmMouse.IsToggle)
				{
					kmMouse.LeftButton.Visible = true;
				}
				else
				{
					kmMouse.LeftButton.Visible = true;
					await Task.Delay(150);
					kmMouse.LeftButton.Visible = false;
				}
			}
			else if (x >= kmMouse.RightButton.Location.X &&
				x <= kmMouse.RightButton.Location.X + kmMouse.RightButton.Size.Width &&
				y >= kmMouse.RightButton.Location.Y &&
				y <= kmMouse.RightButton.Location.Y + kmMouse.RightButton.Size.Height)
			{
				if (kmMouse.IsToggle)
				{
					kmMouse.RightButton.Visible = true;
				}
				else
				{
					kmMouse.RightButton.Visible = true;
					await Task.Delay(150);
					kmMouse.RightButton.Visible = false;
				}
			}
			else if (x >= kmMouse.MiddleButton.Location.X &&
				x <= kmMouse.MiddleButton.Location.X + kmMouse.MiddleButton.Size.Width &&
				y >= kmMouse.MiddleButton.Location.Y &&
				y <= kmMouse.MiddleButton.Location.Y + kmMouse.MiddleButton.Size.Height)
			{
				if (kmMouse.IsToggle)
				{
					kmMouse.MiddleButton.Visible = true;
				}
				else
				{
					kmMouse.MiddleButton.Visible = true;
					await Task.Delay(150);
					kmMouse.MiddleButton.Visible = false;
				}
			}
			else if (x >= kmMouse.X1Button.Location.X &&
				x <= kmMouse.X1Button.Location.X + kmMouse.X1Button.Size.Width &&
				y >= kmMouse.X1Button.Location.Y &&
				y <= kmMouse.X1Button.Location.Y + kmMouse.X1Button.Size.Height)
			{
				if (kmMouse.IsToggle)
				{
					kmMouse.X1Button.Visible = true;
				}
				else
				{
					kmMouse.X1Button.Visible = true;
					await Task.Delay(150);
					kmMouse.X1Button.Visible = false;
				}
			}
			else if (x >= kmMouse.X2Button.Location.X &&
				x <= kmMouse.X2Button.Location.X + kmMouse.X2Button.Size.Width &&
				y >= kmMouse.X2Button.Location.Y &&
				y <= kmMouse.X2Button.Location.Y + kmMouse.X2Button.Size.Height)
			{
				if (kmMouse.IsToggle)
				{
					kmMouse.X2Button.Visible = true;
				}
				else
				{
					kmMouse.X2Button.Visible = true;
					await Task.Delay(150);
					kmMouse.X2Button.Visible = false;
				}
			}
		}

		private void ShowPictureByMouseButton(MouseButtons e, bool IsDown)
		{
			switch (e)
			{
				case MouseButtons.Left:
					kmMouse.LeftButton.Visible = IsDown;
					break;
				case MouseButtons.Right:
					kmMouse.RightButton.Visible = IsDown;
					break;
				case MouseButtons.Middle:
					kmMouse.MiddleButton.Visible = IsDown;
					break;
				case MouseButtons.XButton1:
					kmMouse.X1Button.Visible = IsDown;
					break;
				case MouseButtons.XButton2:
					kmMouse.X2Button.Visible = IsDown;
					break;
			}
		}

		private void SwitchPictureByMousePos(int x, int y)
		{
			if (kmMouse.X < x)
			{
				kmMouse.ArrowLeft.Image = Properties.Resources.Arrow_Left;
				kmMouse.ArrowRight.Image = Properties.Resources.Arrow_Right_Red;
			}
			if (kmMouse.X > x)
			{
				kmMouse.ArrowLeft.Image = Properties.Resources.Arrow_Left_Red;
				kmMouse.ArrowRight.Image = Properties.Resources.Arrow_Right;
			}
			if (kmMouse.Y < y)
			{
				kmMouse.ArrowUp.Image = Properties.Resources.Arrow_Up;
				kmMouse.ArrowDown.Image = Properties.Resources.Arrow_Down_Red;
			}
			if (kmMouse.Y > y)
			{
				kmMouse.ArrowUp.Image = Properties.Resources.Arrow_Up_Red;
				kmMouse.ArrowDown.Image = Properties.Resources.Arrow_Down;
			}
			if (kmMouse.X < x && kmMouse.Y < y)
			{
				kmMouse.ArrowLeftUp.Image = Properties.Resources.Arrow_LeftUp;
				kmMouse.ArrowLeftDown.Image = Properties.Resources.Arrow_LeftDown;
				kmMouse.ArrowRightUp.Image = Properties.Resources.Arrow_RightUp;
				kmMouse.ArrowRightDown.Image = Properties.Resources.Arrow_RightDown_Red;
			}
			if (kmMouse.X > x && kmMouse.Y < y)
			{
				kmMouse.ArrowLeftUp.Image = Properties.Resources.Arrow_LeftUp;
				kmMouse.ArrowLeftDown.Image = Properties.Resources.Arrow_LeftDown_Red;
				kmMouse.ArrowRightUp.Image = Properties.Resources.Arrow_RightUp;
				kmMouse.ArrowRightDown.Image = Properties.Resources.Arrow_RightDown;
			}
			if (kmMouse.X < x && kmMouse.Y > y)
			{
				kmMouse.ArrowLeftUp.Image = Properties.Resources.Arrow_LeftUp;
				kmMouse.ArrowLeftDown.Image = Properties.Resources.Arrow_LeftDown;
				kmMouse.ArrowRightUp.Image = Properties.Resources.Arrow_RightUp_Red;
				kmMouse.ArrowRightDown.Image = Properties.Resources.Arrow_RightDown;
			}
			if (kmMouse.X > x && kmMouse.Y > y)
			{
				kmMouse.ArrowLeftUp.Image = Properties.Resources.Arrow_LeftUp_Red;
				kmMouse.ArrowLeftDown.Image = Properties.Resources.Arrow_LeftDown;
				kmMouse.ArrowRightUp.Image = Properties.Resources.Arrow_RightUp;
				kmMouse.ArrowRightDown.Image = Properties.Resources.Arrow_RightDown;
			}
		}

		private void ShowPictureByMouseWheel(int delta)
		{
			if (delta > 0)
			{
				kmMouse.WheelForward.Visible = true;
				kmMouse.WheelBack.Visible = false;
			}
			else
			{
				kmMouse.WheelForward.Visible = false;
				kmMouse.WheelBack.Visible = true;
			}
		}
	}
}
