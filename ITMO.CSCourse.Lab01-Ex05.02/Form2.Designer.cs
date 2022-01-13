
namespace ITMO.CSCourse.Lab01_Ex05._02
{
	partial class Form2
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
			this.OpenForm1 = new System.Windows.Forms.Button();
			this.CloseForm1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OpenForm1
			// 
			this.OpenForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenForm1.Location = new System.Drawing.Point(141, 151);
			this.OpenForm1.Name = "OpenForm1";
			this.OpenForm1.Size = new System.Drawing.Size(223, 127);
			this.OpenForm1.TabIndex = 0;
			this.OpenForm1.Text = "Open Form 1";
			this.OpenForm1.UseVisualStyleBackColor = true;
			this.OpenForm1.Click += new System.EventHandler(this.OpenForm1_Click);
			// 
			// CloseForm1
			// 
			this.CloseForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseForm1.Location = new System.Drawing.Point(441, 151);
			this.CloseForm1.Name = "CloseForm1";
			this.CloseForm1.Size = new System.Drawing.Size(223, 127);
			this.CloseForm1.TabIndex = 1;
			this.CloseForm1.Text = "Close Form 1";
			this.CloseForm1.UseVisualStyleBackColor = true;
			this.CloseForm1.Click += new System.EventHandler(this.CloseForm1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CloseForm1);
			this.Controls.Add(this.OpenForm1);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button OpenForm1;
		private System.Windows.Forms.Button CloseForm1;
	}
}