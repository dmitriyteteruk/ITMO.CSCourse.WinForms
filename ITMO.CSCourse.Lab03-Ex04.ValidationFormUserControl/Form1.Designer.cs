﻿
namespace ITMO.CSCourse.Lab03_Ex04.ValidationFormUserControl
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
			this.userControl11 = new ITMO.CSCourse.Lab03_Ex04.ValidationFormUserControl.UserControl1();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// userControl11
			// 
			this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControl11.Location = new System.Drawing.Point(12, 12);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(339, 227);
			this.userControl11.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(36, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(294, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "Просмотреть пользователей";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(358, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(430, 379);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 404);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.userControl11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControl1 userControl11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}