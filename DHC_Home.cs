using System;
using System.IO;
using System.Windows.Forms;

namespace CheatEnginePortableInstall
{
	public partial class DHC_Home : Form
	{
		public DHC_Home()
		{
			InitializeComponent();
			ShowPopup showPopup = new ShowPopup();
			showPopup.ShowDialog();
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cheat Engine 7.5.zip");
			if (File.Exists(filePath))
			{
				button2.Enabled = true;
				button2.Visible = true;
				button1.Enabled = false;
				button1.Visible = false;
			}
			else 
			{
				button1.Enabled = true;
				button1.Visible = true;
				button2.Enabled= false;
				button2.Visible= false;
			}
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			label4.Text = "文件正在下载中，请稍后……";
			label4.Text = await AppClass.DownloadFile(progressBar1);
			button2.Enabled = true;
			button2.Visible = true;
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cheat Engine 7.5.zip");
			if (File.Exists(filePath))
			{
				AppClass.Install();
			}
			else
			{
				label4.Text = "文件不存在！正在下载中……";
				label4.Text = await AppClass.DownloadFile(progressBar1);
				AppClass.Install();
			}
		}

	}
}
