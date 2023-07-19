using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
	/// <summary>
	///		此類別可放入鍵盤的掃描碼作為轉換
	/// </summary>
	public class ExtraKeyInfo
    {
		/// <summary>
		///		重複次數
		/// </summary>
		public ushort RepeatCount;
		/// <summary>
		///		鍵盤掃描碼
		/// </summary>
		public int ScanCode;
		/// <summary>
		///		鍵盤掃描修飾符
		/// </summary>
		public int ScanCode_Second;
		/// <summary>
		///		上下文代碼
		/// </summary>
		public byte ContextCode;
		/// <summary>
		///		上一個關鍵狀態
		/// </summary>
		public ushort PreviousKeyState;
		/// <summary>
		///		過渡狀態
		/// </summary>
		public ushort TransitionState;

		/// <summary>
		///		傳回
		///		<see cref="WinUserNativeMethods.SendMessage(IntPtr, uint, uint, uint)"/> 或者
		///		<see cref="WinUserNativeMethods.PostMessage(IntPtr, uint, uint, uint)"/>
		///		的 LParam 參數
		/// </summary>
		public int LParam =>
			RepeatCount |
			(ScanCode << 16) |
			(ScanCode_Second << 24) |
			(ContextCode << 29) |
			(PreviousKeyState << 30) |
			(TransitionState << 31);
	}
}
