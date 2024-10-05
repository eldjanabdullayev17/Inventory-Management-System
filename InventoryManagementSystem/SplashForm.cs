using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class SplashForm : Form
	{
		public SplashForm()
		{
			InitializeComponent();
		}

		int startPoint = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			startPoint += 1;
			progressBar1.Value = startPoint;
			if(progressBar1.Value == 100)
			{
				progressBar1.Value = 0;
				timer1.Stop();
				loginForm loginForm = new loginForm();
				loginForm.Show();
				this.Hide();
			}
		}

		private void SplashForm_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
