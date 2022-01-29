
namespace SQL_App_Sample
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
			this.m_LoadButton = new System.Windows.Forms.Button();
			this.m_CustomerGrid = new System.Windows.Forms.DataGridView();
			this.m_CustomersDataSet = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.m_CustomerGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_CustomersDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// m_LoadButton
			// 
			this.m_LoadButton.AutoSize = true;
			this.m_LoadButton.Location = new System.Drawing.Point(13, 12);
			this.m_LoadButton.Name = "m_LoadButton";
			this.m_LoadButton.Size = new System.Drawing.Size(93, 23);
			this.m_LoadButton.TabIndex = 0;
			this.m_LoadButton.Text = "Load/Загрузка";
			this.m_LoadButton.UseVisualStyleBackColor = true;
			this.m_LoadButton.Click += new System.EventHandler(this.OnLoadData);
			// 
			// m_CustomerGrid
			// 
			this.m_CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_CustomerGrid.Location = new System.Drawing.Point(13, 42);
			this.m_CustomerGrid.Name = "m_CustomerGrid";
			this.m_CustomerGrid.Size = new System.Drawing.Size(916, 407);
			this.m_CustomerGrid.TabIndex = 1;
			// 
			// m_CustomersDataSet
			// 
			this.m_CustomersDataSet.DataSetName = "NewDataSet";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 461);
			this.Controls.Add(this.m_CustomerGrid);
			this.Controls.Add(this.m_LoadButton);
			this.Name = "Form1";
			this.Text = "SQL App";
			((System.ComponentModel.ISupportInitialize)(this.m_CustomerGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_CustomersDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_LoadButton;
		private System.Windows.Forms.DataGridView m_CustomerGrid;
		private System.Data.DataSet m_CustomersDataSet;
	}
}

