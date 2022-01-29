using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petzold.c6.WhatClientSize.cs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = "What Client Size?";

			Label lbl = new Label();
			lbl.Parent = this;
			lbl.AutoSize = true;
			lbl.DataBindings.Add("Text", this, "ClientSize");
			lbl.DataBindings.Add("Location", this, "Location");
		}
	}
}
