
namespace ITMO.CSCourse.Lab01_Ex05._02
{
	partial class ParentForm
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
			this.CloseParentFormButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CloseParentFormButton
			// 
			this.CloseParentFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseParentFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseParentFormButton.Location = new System.Drawing.Point(140, 190);
			this.CloseParentFormButton.Margin = new System.Windows.Forms.Padding(5);
			this.CloseParentFormButton.Name = "CloseParentFormButton";
			this.CloseParentFormButton.Size = new System.Drawing.Size(170, 70);
			this.CloseParentFormButton.TabIndex = 0;
			this.CloseParentFormButton.Text = "GREENPEACE";
			this.CloseParentFormButton.UseVisualStyleBackColor = true;
			this.CloseParentFormButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// ParentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(450, 450);
			this.Controls.Add(this.CloseParentFormButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ParentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parent Form";
			this.Load += new System.EventHandler(this.ParentForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Button CloseParentFormButton;
	}
}

