﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab01_Ex05._01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
			myPath.AddEllipse(0, 0, this.Width, this.Height);  // добавляем элипс с размерами формы
			Region myRegion = new Region(myPath);
			this.Region = myRegion;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();		// по нажатию кнопки закрываем 
		}
	}
}
