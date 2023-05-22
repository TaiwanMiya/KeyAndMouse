using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	public partial class Cursor : Form
	{
		private CursorMethods cursorMethods;

		internal int X;
		internal int Y;
		internal Tuple<int, int, int> Pixel;

		int ScreenHeight = SystemInformation.PrimaryMonitorSize.Height;
		int ScreenWidth = SystemInformation.PrimaryMonitorSize.Width;

		public Cursor()
		{
			InitializeComponent();
		}

		private void Cursor_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.BackColor = Color.Peru;
			this.TransparencyKey = this.BackColor;
			cursorMethods = new CursorMethods(this);
			timer1.Enabled = true;
		}

		private void Cursor_FormClosing(object sender, FormClosingEventArgs e)
		{
			cursorMethods.Dispose();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			uint pixel = CursorNativeMethods.GetPixel(cursorMethods.DC, X, Y);
			cursorMethods.DealWithRGB(pixel);
			
			lbColorCode.Text = string.Format("# {0:x2}{1:x2}{2:x2}", Pixel.Item1, Pixel.Item2, Pixel.Item3);
			lbRGB.Text = $"{Pixel.Item1}, {Pixel.Item2}, {Pixel.Item3}";
			lbX.Text = X.ToString();
			lbY.Text = Y.ToString();
			RGBimage.BackColor = Color.FromArgb(Pixel.Item1, Pixel.Item2, Pixel.Item3);

			int pointX = -1;
			int pointY = -1;
			if (!(ScreenHeight - this.Size.Height < Y) && !(ScreenWidth - this.Size.Width < X))
			{
				this.Location = new Point(X + 20, Y + 20);
				return;
			}
			if (ScreenWidth - this.Size.Width < X)
			{
				pointX = X - (this.Size.Width + 20);
			}
			if (ScreenHeight - this.Size.Height < Y)
			{
				pointY = Y - (this.Size.Height + 20);
			}
			this.Location = new Point(pointX == -1 ? X : pointX, pointY == -1 ? Y : pointY);
		}
	}
}
