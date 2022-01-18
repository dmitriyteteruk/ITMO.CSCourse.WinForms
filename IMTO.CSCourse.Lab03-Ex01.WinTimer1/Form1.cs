using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMTO.CSCourse.Lab03_Ex01.WinTimer1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void buttonTimeEnabledDisabled_Click(object sender, EventArgs e)
		{
			
		}

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox1.Checked == false)
			{
				userControlTimer1.TimeEnabled = true; // TimeEnabled это свойство класса
			}
			else 
			{
				userControlTimer1.TimeEnabled = false;	 
			}
		}
	}
}
