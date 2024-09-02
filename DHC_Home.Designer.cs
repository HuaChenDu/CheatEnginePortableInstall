namespace CheatEnginePortableInstall
{
	partial class DHC_Home
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHC_Home));
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(188, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "下载";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(-1, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "1.选择安装目录并安装";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(263, 10);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(55, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "安装";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label4.Font = new System.Drawing.Font("宋体", 9F);
			this.label4.Location = new System.Drawing.Point(0, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(330, 43);
			this.label4.TabIndex = 1;
			this.label4.Text = "作者：毒华晨\r\n\r\n程序版本：1.0.0.0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(2, 39);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(328, 12);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 3;
			// 
			// DHC_Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 97);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DHC_Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "小晨工具箱之CE修改器 V7.5 便携式安装器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

