using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatEnginePortableInstall
{
	public partial class ShowPopup : Form
	{
		private Timer timer;
		private int remainingSeconds = 12;

		public ShowPopup()
		{
			InitializeComponent();
			InitializeTimer();
			UpdateLabel();
		}

		private void InitializeTimer()
		{
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			remainingSeconds--;

			if (remainingSeconds <= 0)
			{
				timer.Stop();
				this.Close();
			}
			else
			{
				UpdateLabel();
			}
		}

		private void UpdateLabel()
		{
			label1.Text = $"{remainingSeconds} 秒之后自动关闭弹窗";
		}
	}
}
