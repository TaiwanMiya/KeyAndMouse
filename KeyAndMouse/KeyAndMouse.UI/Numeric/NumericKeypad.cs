using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.Interface.UserControls.Numeric
{
	/// <summary>
	///		九宮格數字鍵控件
	/// </summary>
	public partial class NumericKeypad : UserControl
	{
		private bool isNumLock = false;

		/// <summary>
		///		是否啟用 Num Lock 數字鎖定
		/// </summary>
		public bool IsNumLock { get { return isNumLock;} }

		/// <summary>
		///		九宮格數字鍵控件
		/// </summary>
		public NumericKeypad()
		{
			InitializeComponent();
			Num0.Font = new Font("Arial", 30, FontStyle.Bold);
			Num1.Font = new Font("Arial", 30, FontStyle.Bold);
			Num2.Font = new Font("Arial", 30, FontStyle.Bold);
			Num3.Font = new Font("Arial", 30, FontStyle.Bold);
			Num4.Font = new Font("Arial", 30, FontStyle.Bold);
			Num5.Font = new Font("Arial", 30, FontStyle.Bold);
			Num6.Font = new Font("Arial", 30, FontStyle.Bold);
			Num7.Font = new Font("Arial", 30, FontStyle.Bold);
			Num8.Font = new Font("Arial", 30, FontStyle.Bold);
			Num9.Font = new Font("Arial", 30, FontStyle.Bold);
			NumDot.Font = new Font("Arial", 30, FontStyle.Bold);
		}

		private void NumLock_Click(object sender, EventArgs e)
		{
			isNumLock = !isNumLock;

			Num0.Text = !isNumLock ? "0" : "INSERT";
			Num1.Text = !isNumLock ? "1" : "END";
			Num2.Text = !isNumLock ? "2" : "↓";
			Num3.Text = !isNumLock ? "3" : "PAGE DOWN";
			Num4.Text = !isNumLock ? "4" : "←";
			Num5.Text = !isNumLock ? "5" : "";
			Num6.Text = !isNumLock ? "6" : "→";
			Num7.Text = !isNumLock ? "7" : "HOME";
			Num8.Text = !isNumLock ? "8" : "↑";
			Num9.Text = !isNumLock ? "9" : "PAGE UP";
			NumDot.Text = !isNumLock ? "." : "DEL";

			Num0.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num1.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num2.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num3.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num4.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num5.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num6.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num7.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num8.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			Num9.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
			NumDot.Font = !isNumLock ? new Font("Arial", 30, FontStyle.Bold): new Font("Arial", 15, FontStyle.Bold) ;
		}
	}
}
