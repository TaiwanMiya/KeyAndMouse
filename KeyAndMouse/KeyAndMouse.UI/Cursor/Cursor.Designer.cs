
namespace Heptad.Dick.WinSystem.KeyboardMouse.UI
{
	partial class Cursor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.RGBimage = new System.Windows.Forms.PictureBox();
			this.lbColorCode = new System.Windows.Forms.Label();
			this.lbXtitle = new System.Windows.Forms.Label();
			this.lbYtitle = new System.Windows.Forms.Label();
			this.lbY = new System.Windows.Forms.Label();
			this.lbX = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbRGB = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.RGBimage)).BeginInit();
			this.SuspendLayout();
			// 
			// RGBimage
			// 
			this.RGBimage.Location = new System.Drawing.Point(0, 0);
			this.RGBimage.Name = "RGBimage";
			this.RGBimage.Size = new System.Drawing.Size(100, 100);
			this.RGBimage.TabIndex = 0;
			this.RGBimage.TabStop = false;
			// 
			// lbColorCode
			// 
			this.lbColorCode.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbColorCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbColorCode.ForeColor = System.Drawing.Color.Transparent;
			this.lbColorCode.Location = new System.Drawing.Point(100, 0);
			this.lbColorCode.Margin = new System.Windows.Forms.Padding(0);
			this.lbColorCode.Name = "lbColorCode";
			this.lbColorCode.Size = new System.Drawing.Size(100, 25);
			this.lbColorCode.TabIndex = 1;
			this.lbColorCode.Text = "# 000000";
			this.lbColorCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbXtitle
			// 
			this.lbXtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbXtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbXtitle.ForeColor = System.Drawing.Color.Transparent;
			this.lbXtitle.Location = new System.Drawing.Point(0, 100);
			this.lbXtitle.Margin = new System.Windows.Forms.Padding(0);
			this.lbXtitle.Name = "lbXtitle";
			this.lbXtitle.Size = new System.Drawing.Size(100, 25);
			this.lbXtitle.TabIndex = 2;
			this.lbXtitle.Text = "X";
			this.lbXtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbYtitle
			// 
			this.lbYtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbYtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbYtitle.ForeColor = System.Drawing.Color.Transparent;
			this.lbYtitle.Location = new System.Drawing.Point(0, 125);
			this.lbYtitle.Margin = new System.Windows.Forms.Padding(0);
			this.lbYtitle.Name = "lbYtitle";
			this.lbYtitle.Size = new System.Drawing.Size(100, 25);
			this.lbYtitle.TabIndex = 3;
			this.lbYtitle.Text = "Y";
			this.lbYtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbY
			// 
			this.lbY.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbY.ForeColor = System.Drawing.Color.Transparent;
			this.lbY.Location = new System.Drawing.Point(100, 125);
			this.lbY.Margin = new System.Windows.Forms.Padding(0);
			this.lbY.Name = "lbY";
			this.lbY.Size = new System.Drawing.Size(100, 25);
			this.lbY.TabIndex = 5;
			this.lbY.Text = "0";
			this.lbY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbX
			// 
			this.lbX.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbX.ForeColor = System.Drawing.Color.Transparent;
			this.lbX.Location = new System.Drawing.Point(100, 100);
			this.lbX.Margin = new System.Windows.Forms.Padding(0);
			this.lbX.Name = "lbX";
			this.lbX.Size = new System.Drawing.Size(100, 25);
			this.lbX.TabIndex = 4;
			this.lbX.Text = "0";
			this.lbX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbRGB
			// 
			this.lbRGB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbRGB.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.lbRGB.ForeColor = System.Drawing.Color.Transparent;
			this.lbRGB.Location = new System.Drawing.Point(100, 25);
			this.lbRGB.Margin = new System.Windows.Forms.Padding(0);
			this.lbRGB.Name = "lbRGB";
			this.lbRGB.Size = new System.Drawing.Size(100, 25);
			this.lbRGB.TabIndex = 6;
			this.lbRGB.Text = "255, 255, 255";
			this.lbRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Cursor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(200, 200);
			this.Controls.Add(this.lbRGB);
			this.Controls.Add(this.lbY);
			this.Controls.Add(this.lbX);
			this.Controls.Add(this.lbYtitle);
			this.Controls.Add(this.lbXtitle);
			this.Controls.Add(this.lbColorCode);
			this.Controls.Add(this.RGBimage);
			this.ForeColor = System.Drawing.Color.Red;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Cursor";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Cursor";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cursor_FormClosing);
			this.Load += new System.EventHandler(this.Cursor_Load);
			((System.ComponentModel.ISupportInitialize)(this.RGBimage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Label lbXtitle;
		public System.Windows.Forms.Label lbYtitle;
		internal System.Windows.Forms.Label lbColorCode;
		internal System.Windows.Forms.Label lbY;
		internal System.Windows.Forms.Label lbX;
		internal System.Windows.Forms.PictureBox RGBimage;
		private System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.Label lbRGB;
	}
}