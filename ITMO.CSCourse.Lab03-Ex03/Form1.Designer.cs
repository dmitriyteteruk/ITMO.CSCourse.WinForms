﻿
namespace ITMO.CSCourse.Lab03_Ex03
{
	partial class Form1
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
			this.userControlTimer21 = new ITMO.CSCourse.Lab03_Ex03.UserControlTimer2();
			this.SuspendLayout();
			// 
			// userControlTimer21
			// 
			this.userControlTimer21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlTimer21.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userControlTimer21.Location = new System.Drawing.Point(0, 0);
			this.userControlTimer21.Name = "userControlTimer21";
			this.userControlTimer21.Size = new System.Drawing.Size(800, 450);
			this.userControlTimer21.TabIndex = 0;
			this.userControlTimer21.Text = "userControlTimer21";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.userControlTimer21);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControlTimer2 userControlTimer21;
	}
}

