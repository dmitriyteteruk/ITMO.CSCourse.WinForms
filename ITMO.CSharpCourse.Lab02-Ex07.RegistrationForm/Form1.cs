﻿// даннный 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSharpCourse.Lab02_Ex07.RegistrationForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				Label lbl = new Label();
				lbl.Location = new System.Drawing.Point(16, 96);
				lbl.Size = new System.Drawing.Size(32, 23);
				lbl.Name = "labelll";
				lbl.TabIndex = 2;
				lbl.Text = "PIN2";
				groupBox1.Controls.Add(lbl);
				TextBox txt = new TextBox();
				txt.Location = new System.Drawing.Point(82, 96);
				txt.Size = new System.Drawing.Size(253, 20);
				txt.Name = "textboxx";
				txt.TabIndex = 1;
				txt.Text = "";
				groupBox1.Controls.Add(txt);
				txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			}
			else
			{
				int lcv;
				lcv = groupBox1.Controls.Count;// определяется количество элементов
				while (lcv > 4)
				{
					groupBox1.Controls.RemoveAt(lcv - 1);
					lcv -= 1;
				}
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Поле Name не может содержать цифры");
				errorProvider1.SetError(textBox1, "Must be letter");   // код Lab02-Ex08 пункт 12
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Поле PIN не может содержать буквы");
			}
		}

		private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void textBox2_Validating(object sender, CancelEventArgs e)
		{
			if (textBox2.Text == "")
			{
				e.Cancel = false;
			}
			else
			{
				try
				{
					double.Parse(textBox2.Text);
					e.Cancel = false;
				}
				catch
				{
					e.Cancel = true;
					MessageBox.Show("Поле PIN не может содержать буквы");
				}
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
