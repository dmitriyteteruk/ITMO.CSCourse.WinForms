
namespace IMTO.CSCourse.Lab03_Ex01.WinTimer1
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.userControlTimer1 = new IMTO.CSCourse.Lab03_Ex01.WinTimer1.UserControlTimer();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.Location = new System.Drawing.Point(134, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(180, 24);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Остановить таймер";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
			// 
			// userControlTimer1
			// 
			this.userControlTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userControlTimer1.Location = new System.Drawing.Point(12, 12);
			this.userControlTimer1.Name = "userControlTimer1";
			this.userControlTimer1.Size = new System.Drawing.Size(116, 41);
			this.userControlTimer1.TabIndex = 0;
			this.userControlTimer1.TimeEnabled = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.userControlTimer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControlTimer userControlTimer1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

