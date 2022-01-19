
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
			this.userControl11 = new ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary.UserControl1();
			this.userControl21 = new ITMO.CSCourse.Lab03_Ex01._15.ControlLibrary.UserControl2();
			this.userControlTimer21 = new ITMO.CSCourse.Lab03_Ex03.UserControlTimer2();
			this.SuspendLayout();
			// 
			// userControl11
			// 
			this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControl11.Location = new System.Drawing.Point(12, 67);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(448, 106);
			this.userControl11.TabIndex = 1;
			this.userControl11.TimeEnabled = true;
			this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
			// 
			// userControl21
			// 
			this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControl21.Location = new System.Drawing.Point(12, 179);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new System.Drawing.Size(448, 106);
			this.userControl21.TabIndex = 2;
			this.userControl21.TimeEnabled = true;
			// 
			// userControlTimer21
			// 
			this.userControlTimer21.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.userControlTimer21.Location = new System.Drawing.Point(142, 9);
			this.userControlTimer21.Name = "userControlTimer21";
			this.userControlTimer21.Size = new System.Drawing.Size(174, 45);
			this.userControlTimer21.TabIndex = 0;
			this.userControlTimer21.Text = "userControlTimer21";
			this.userControlTimer21.Click += new System.EventHandler(this.userControlTimer21_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 298);
			this.Controls.Add(this.userControl21);
			this.Controls.Add(this.userControl11);
			this.Controls.Add(this.userControlTimer21);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private UserControlTimer2 userControlTimer21;
		private Lab03_Ex01._15.ControlLibrary.UserControl1 userControl11;
		private Lab03_Ex01._15.ControlLibrary.UserControl2 userControl21;
	}
}

