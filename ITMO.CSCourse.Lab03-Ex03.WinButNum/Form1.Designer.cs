
namespace ITMO.CSCourse.Lab03_Ex03.WinButNum
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
			this.clickButton1 = new ITMO.CSCourse.Lab03_Ex03.WinButNum.ClickButton();
			this.SuspendLayout();
			// 
			// clickButton1
			// 
			this.clickButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clickButton1.Location = new System.Drawing.Point(84, 59);
			this.clickButton1.Name = "clickButton1";
			this.clickButton1.Size = new System.Drawing.Size(633, 332);
			this.clickButton1.TabIndex = 0;
			this.clickButton1.Text = "Нажми";
			this.clickButton1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.clickButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ClickButton clickButton1;
	}
}

