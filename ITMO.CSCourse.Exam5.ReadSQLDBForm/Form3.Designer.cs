
namespace ITMO.CSCourse.Exam5.ReadSQLDBForm
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelState = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_State = new System.Windows.Forms.TextBox();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.dataSet1 = new ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1();
			this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.giftsTableAdapter = new ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1TableAdapters.GiftsTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(28, 31);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(29, 13);
			this.labelFirstName.TabIndex = 0;
			this.labelFirstName.Text = "Имя";
			// 
			// labelState
			// 
			this.labelState.AutoSize = true;
			this.labelState.Location = new System.Drawing.Point(31, 69);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(32, 13);
			this.labelState.TabIndex = 1;
			this.labelState.Text = "State";
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(120, 31);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(225, 20);
			this.txt_Name.TabIndex = 2;
			// 
			// txt_State
			// 
			this.txt_State.Location = new System.Drawing.Point(120, 69);
			this.txt_State.Name = "txt_State";
			this.txt_State.Size = new System.Drawing.Size(225, 20);
			this.txt_State.TabIndex = 3;
			// 
			// btn_Insert
			// 
			this.btn_Insert.Location = new System.Drawing.Point(12, 112);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(96, 23);
			this.btn_Insert.TabIndex = 4;
			this.btn_Insert.Text = "Insert";
			this.btn_Insert.UseVisualStyleBackColor = true;
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(120, 112);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(86, 23);
			this.btn_Update.TabIndex = 5;
			this.btn_Update.Text = "Update";
			this.btn_Update.UseVisualStyleBackColor = true;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(223, 112);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(89, 23);
			this.btn_Delete.TabIndex = 6;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.UseVisualStyleBackColor = true;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// giftsBindingSource
			// 
			this.giftsBindingSource.DataMember = "Gifts";
			this.giftsBindingSource.DataSource = this.dataSet1;
			// 
			// giftsTableAdapter
			// 
			this.giftsTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 157);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(935, 150);
			this.dataGridView1.TabIndex = 7;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.btn_Insert);
			this.Controls.Add(this.txt_State);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.labelState);
			this.Controls.Add(this.labelFirstName);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_State;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Delete;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource giftsBindingSource;
		private DataSet1TableAdapters.GiftsTableAdapter giftsTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}