namespace CheatEnginePortableInstall
{
	partial class ShowPopup
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
			this.label1 = new System.Windows.Forms.Label();
			this.popup1 = new CheatEnginePortableInstall.Popup();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 550);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "15 秒之后自动关闭弹窗";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// popup1
			// 
			this.popup1.Dock = System.Windows.Forms.DockStyle.Top;
			this.popup1.Location = new System.Drawing.Point(0, 0);
			this.popup1.Name = "popup1";
			this.popup1.Size = new System.Drawing.Size(374, 550);
			this.popup1.TabIndex = 0;
			// 
			// ShowPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 566);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.popup1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ShowPopup";
			this.Text = "打赏弹窗";
			this.ResumeLayout(false);

		}

		#endregion

		private Popup popup1;
		private System.Windows.Forms.Label label1;
	}
}