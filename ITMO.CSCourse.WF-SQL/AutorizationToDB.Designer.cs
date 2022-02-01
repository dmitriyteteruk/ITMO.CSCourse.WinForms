
namespace ITMO.CSCourse.WF_SQL
{
	partial class AuthorizationToDB
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
			this.labelEnterName = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.checkBoxWindowsAuthorization = new System.Windows.Forms.CheckBox();
			this.labelServerPath = new System.Windows.Forms.Label();
			this.textBoxServerPath = new System.Windows.Forms.TextBox();
			this.labelMainTextAuthorizationToDB = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelEnterName
			// 
			this.labelEnterName.AutoSize = true;
			this.labelEnterName.Location = new System.Drawing.Point(38, 100);
			this.labelEnterName.Name = "labelEnterName";
			this.labelEnterName.Size = new System.Drawing.Size(60, 13);
			this.labelEnterName.TabIndex = 0;
			this.labelEnterName.Text = "User Name";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Location = new System.Drawing.Point(112, 96);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(193, 20);
			this.textBoxUserName.TabIndex = 1;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(38, 134);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(53, 13);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(112, 130);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(193, 20);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// checkBoxWindowsAuthorization
			// 
			this.checkBoxWindowsAuthorization.AutoSize = true;
			this.checkBoxWindowsAuthorization.Location = new System.Drawing.Point(41, 166);
			this.checkBoxWindowsAuthorization.Name = "checkBoxWindowsAuthorization";
			this.checkBoxWindowsAuthorization.Size = new System.Drawing.Size(248, 17);
			this.checkBoxWindowsAuthorization.TabIndex = 4;
			this.checkBoxWindowsAuthorization.Text = "Use Windows Authorization for MS SQL Server";
			this.checkBoxWindowsAuthorization.UseVisualStyleBackColor = true;
			// 
			// labelServerPath
			// 
			this.labelServerPath.AutoSize = true;
			this.labelServerPath.Location = new System.Drawing.Point(38, 66);
			this.labelServerPath.Name = "labelServerPath";
			this.labelServerPath.Size = new System.Drawing.Size(63, 13);
			this.labelServerPath.TabIndex = 5;
			this.labelServerPath.Text = "Server Path";
			// 
			// textBoxServerPath
			// 
			this.textBoxServerPath.Location = new System.Drawing.Point(112, 62);
			this.textBoxServerPath.Name = "textBoxServerPath";
			this.textBoxServerPath.Size = new System.Drawing.Size(193, 20);
			this.textBoxServerPath.TabIndex = 6;
			// 
			// labelMainTextAuthorizationToDB
			// 
			this.labelMainTextAuthorizationToDB.AutoSize = true;
			this.labelMainTextAuthorizationToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMainTextAuthorizationToDB.Location = new System.Drawing.Point(38, 15);
			this.labelMainTextAuthorizationToDB.Name = "labelMainTextAuthorizationToDB";
			this.labelMainTextAuthorizationToDB.Size = new System.Drawing.Size(255, 34);
			this.labelMainTextAuthorizationToDB.TabIndex = 7;
			this.labelMainTextAuthorizationToDB.Text = "Для подлючения к БД укажите путь \r\nк серверу и данные для авторизации";
			// 
			// AuthorizationToDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 211);
			this.Controls.Add(this.labelMainTextAuthorizationToDB);
			this.Controls.Add(this.textBoxServerPath);
			this.Controls.Add(this.labelServerPath);
			this.Controls.Add(this.checkBoxWindowsAuthorization);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.labelEnterName);
			this.Name = "AuthorizationToDB";
			this.Text = "AutorizationToDB";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelEnterName;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.CheckBox checkBoxWindowsAuthorization;
		private System.Windows.Forms.Label labelServerPath;
		private System.Windows.Forms.TextBox textBoxServerPath;
		private System.Windows.Forms.Label labelMainTextAuthorizationToDB;
	}
}