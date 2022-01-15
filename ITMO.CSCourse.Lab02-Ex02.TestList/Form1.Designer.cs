﻿
namespace ITMO.CSCourse.Lab02_Ex02.TestList
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
			this.peopleList = new System.Windows.Forms.ComboBox();
			this.memberList = new System.Windows.Forms.CheckedListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSort = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// peopleList
			// 
			this.peopleList.FormattingEnabled = true;
			this.peopleList.Items.AddRange(new object[] {
            "Иваново Иван Иванович",
            "Петров Петр Петрович"});
			this.peopleList.Location = new System.Drawing.Point(12, 224);
			this.peopleList.Name = "peopleList";
			this.peopleList.Size = new System.Drawing.Size(270, 21);
			this.peopleList.TabIndex = 0;
			// 
			// memberList
			// 
			this.memberList.FormattingEnabled = true;
			this.memberList.Location = new System.Drawing.Point(6, 19);
			this.memberList.Name = "memberList";
			this.memberList.Size = new System.Drawing.Size(258, 184);
			this.memberList.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.memberList);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 206);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список участников";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(288, 12);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(288, 41);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 23);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(288, 70);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(80, 23);
			this.buttonSort.TabIndex = 5;
			this.buttonSort.Text = "Сортировать";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 257);
			this.Controls.Add(this.buttonSort);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.peopleList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Работа со списками";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox peopleList;
		private System.Windows.Forms.CheckedListBox memberList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSort;
	}
}

