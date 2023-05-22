using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Heptad.Dick.WinSystem.KeyboardMouse;
using Heptad.Dick.WinSystem.KeyboardMouse.UI.Hooks;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	class CursorNativeMethods
	{
		/// <summary>
		///		<see cref="GetDC"/> 函數為指定窗口的客戶區或整個屏幕檢索設備上下文 (DC) 的句柄
		///		<para>
		///			可以在後續的 GDI 函數中使用返回的句柄來繪製 DC
		///		</para>
		///		<para>
		///			設備上下文是一個不透明的數據結構, 其值由 GDI 在內部使用
		///		</para>
		/// </summary>
		/// 
		/// <param name="hWnd">
		///		設備的句柄, 值建議給定 <see cref="IntPtr.Zero"/>
		/// </param>
		/// 
		/// <returns>
		///		<para>
		///			如果函數成功, 則返回值是指定窗口客戶區的 DC 句柄
		///		</para>
		///		<para>
		///			如果函數失敗, 則返回值為NULL
		///		</para>
		/// </returns>
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);

		/// <summary>
		///		<see cref="GetPixel"/> 函數檢索指定坐標處像素的紅, 綠, 藍 (RGB) 顏色值
		/// </summary>
		/// 
		/// <param name="hDC">
		///		設備上下文的句柄, 即是 <see cref="GetDC"/> 的返回值
		/// </param>
		/// 
		/// <param name="x">
		///		要檢查的像素的 x 坐標
		/// </param>
		/// 
		/// <param name="y">
		///		要檢查的像素的 y 坐標
		/// </param>
		/// 
		/// <returns></returns>
		[DllImport("gdi32.dll")]
		public static extern uint GetPixel(IntPtr hDC, int x, int y);
	}

	class CursorMethods
	{
		internal IntPtr DC = CursorNativeMethods.GetDC(IntPtr.Zero);

		private Cursor kmCursor;

		public CursorMethods(Cursor cursor)
		{
			if (HookEvent.MouseEvent == null)
				HookEvent.MouseEvent = Hook.GlobalEvents();
			kmCursor = cursor;
			Win32Api.Point point = new Win32Api.Point();
			MouseNativeMethods.GetCursorPos(out point);
			kmCursor.Location = new System.Drawing.Point(point.X + 20, point.Y + 20);
			kmCursor.lbX.Text = point.X.ToString();
			kmCursor.lbY.Text = point.Y.ToString();
			uint pixel = CursorNativeMethods.GetPixel(DC, point.X, point.Y);
			DealWithRGB(pixel);
			HookEvent.MouseEvent.MouseMove += MouseEvent_MouseMove;
		}

		internal void Dispose()
		{
			HookEvent.MouseEvent.MouseMove -= MouseEvent_MouseMove;
		}

		private void MouseEvent_MouseMove(object sender, MouseEventArgs e)
		{
			kmCursor.X = e.X;
			kmCursor.Y = e.Y;
		}

		internal void DealWithRGB(uint pixel)
		{
			int red		= (int)pixel % 256;
			pixel		/= 256;
			int green	= (int)pixel % 256;
			pixel		/= 256;
			int blue	= (int)pixel % 256;
			if (red < 0 || green < 0 || blue < 0 || red > 255 || green > 255 || blue > 255)
				return;
			kmCursor.Pixel = Tuple.Create(red, green, blue);
		}

		/// <summary>
		///		處理RGB
		/// </summary>
		/// <param name="pixel"></param>
		/// <returns></returns>
		public Tuple<int, int, int> HandleColorByRGB(uint pixel)
		{
			int red = (int)pixel % 256;
			pixel /= 256;
			int green = (int)pixel % 256;
			pixel /= 256;
			int blue = (int)pixel % 256;
			return Tuple.Create(red, green, blue); ;
		}
	}
}
