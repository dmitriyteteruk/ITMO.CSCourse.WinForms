using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary
{
	public partial class UserControl2 : UserControl
	{
		public UserControl2()
		{
			InitializeComponent();
		}

		public bool TimeEnabled
		{
			get { return timer2.Enabled; }
			set { timer2.Enabled = value; }
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToLongTimeString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (timer2.Enabled == true)
			{
				TimeEnabled = false; 
			}
			else
			{
				TimeEnabled = true;
			}
		}
	}
}
