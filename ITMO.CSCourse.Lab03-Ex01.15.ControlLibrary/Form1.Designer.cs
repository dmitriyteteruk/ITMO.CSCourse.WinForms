
namespace ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary
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
			this.userControl21 = new ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary.UserControl2();
			this.userControl11 = new ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary.UserControl1();
			this.SuspendLayout();
			// 
			// userControl21
			// 
			this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControl21.Location = new System.Drawing.Point(12, 148);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new System.Drawing.Size(450, 108);
			this.userControl21.TabIndex = 1;
			// 
			// userControl11
			// 
			this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControl11.Location = new System.Drawing.Point(12, 12);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(450, 108);
			this.userControl11.TabIndex = 0;
			this.userControl11.TimeEnabled = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 278);
			this.Controls.Add(this.userControl21);
			this.Controls.Add(this.userControl11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControl1 userControl11;
		private UserControl2 userControl21;
	}
}