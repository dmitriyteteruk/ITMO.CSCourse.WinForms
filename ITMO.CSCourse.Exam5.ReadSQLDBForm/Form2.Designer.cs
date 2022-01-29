
namespace ITMO.CSCourse.Exam5.ReadSQLDBForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label houseNameShortLabel;
			System.Windows.Forms.Label giftTextShortLabel;
			System.Windows.Forms.Label giftURLLabel;
			System.Windows.Forms.Label deliveryDateLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.giftsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.giftsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.giftsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giftsTableAdapter = new ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1TableAdapters.GiftsTableAdapter();
			this.tableAdapterManager = new ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1TableAdapters.TableAdapterManager();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.houseNameShortTextBox = new System.Windows.Forms.TextBox();
			this.giftTextShortTextBox = new System.Windows.Forms.TextBox();
			this.giftURLTextBox = new System.Windows.Forms.TextBox();
			this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonAddNewRecordToDB = new System.Windows.Forms.Button();
			this.buttonSaveChangesToDB = new System.Windows.Forms.Button();
			this.buttonDeleteRecordFromDB = new System.Windows.Forms.Button();
			firstNameLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			houseNameShortLabel = new System.Windows.Forms.Label();
			giftTextShortLabel = new System.Windows.Forms.Label();
			giftURLLabel = new System.Windows.Forms.Label();
			deliveryDateLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingNavigator)).BeginInit();
			this.giftsBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giftsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new System.Drawing.Point(12, 272);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(60, 13);
			firstNameLabel.TabIndex = 4;
			firstNameLabel.Text = "First Name:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new System.Drawing.Point(12, 298);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(61, 13);
			lastNameLabel.TabIndex = 6;
			lastNameLabel.Text = "Last Name:";
			// 
			// houseNameShortLabel
			// 
			houseNameShortLabel.AutoSize = true;
			houseNameShortLabel.Location = new System.Drawing.Point(12, 324);
			houseNameShortLabel.Name = "houseNameShortLabel";
			houseNameShortLabel.Size = new System.Drawing.Size(100, 13);
			houseNameShortLabel.TabIndex = 8;
			houseNameShortLabel.Text = "House Name Short:";
			// 
			// giftTextShortLabel
			// 
			giftTextShortLabel.AutoSize = true;
			giftTextShortLabel.Location = new System.Drawing.Point(12, 350);
			giftTextShortLabel.Name = "giftTextShortLabel";
			giftTextShortLabel.Size = new System.Drawing.Size(78, 13);
			giftTextShortLabel.TabIndex = 10;
			giftTextShortLabel.Text = "Gift Text Short:";
			// 
			// giftURLLabel
			// 
			giftURLLabel.AutoSize = true;
			giftURLLabel.Location = new System.Drawing.Point(12, 376);
			giftURLLabel.Name = "giftURLLabel";
			giftURLLabel.Size = new System.Drawing.Size(51, 13);
			giftURLLabel.TabIndex = 12;
			giftURLLabel.Text = "Gift URL:";
			// 
			// deliveryDateLabel
			// 
			deliveryDateLabel.AutoSize = true;
			deliveryDateLabel.Location = new System.Drawing.Point(12, 403);
			deliveryDateLabel.Name = "deliveryDateLabel";
			deliveryDateLabel.Size = new System.Drawing.Size(74, 13);
			deliveryDateLabel.TabIndex = 14;
			deliveryDateLabel.Text = "Delivery Date:";
			// 
			// giftsBindingNavigator
			// 
			this.giftsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.giftsBindingNavigator.BindingSource = this.giftsBindingSource;
			this.giftsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.giftsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.giftsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.giftsBindingNavigatorSaveItem});
			this.giftsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.giftsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.giftsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.giftsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.giftsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.giftsBindingNavigator.Name = "giftsBindingNavigator";
			this.giftsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.giftsBindingNavigator.Size = new System.Drawing.Size(654, 25);
			this.giftsBindingNavigator.TabIndex = 0;
			this.giftsBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// giftsBindingSource
			// 
			this.giftsBindingSource.DataMember = "Gifts";
			this.giftsBindingSource.DataSource = this.dataSet1;
			this.giftsBindingSource.CurrentChanged += new System.EventHandler(this.giftsBindingSource_CurrentChanged);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// giftsBindingNavigatorSaveItem
			// 
			this.giftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.giftsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("giftsBindingNavigatorSaveItem.Image")));
			this.giftsBindingNavigatorSaveItem.Name = "giftsBindingNavigatorSaveItem";
			this.giftsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.giftsBindingNavigatorSaveItem.Text = "Save Data";
			this.giftsBindingNavigatorSaveItem.Click += new System.EventHandler(this.giftsBindingNavigatorSaveItem_Click);
			// 
			// giftsDataGridView
			// 
			this.giftsDataGridView.AutoGenerateColumns = false;
			this.giftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.giftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.giftsDataGridView.DataSource = this.giftsBindingSource;
			this.giftsDataGridView.Location = new System.Drawing.Point(0, 28);
			this.giftsDataGridView.Name = "giftsDataGridView";
			this.giftsDataGridView.Size = new System.Drawing.Size(647, 220);
			this.giftsDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
			this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
			this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "HouseNameShort";
			this.dataGridViewTextBoxColumn4.HeaderText = "HouseNameShort";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "GiftTextShort";
			this.dataGridViewTextBoxColumn6.HeaderText = "GiftTextShort";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "GiftURL";
			this.dataGridViewTextBoxColumn7.HeaderText = "GiftURL";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "DeliveryDate";
			this.dataGridViewTextBoxColumn8.HeaderText = "DeliveryDate";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// giftsTableAdapter
			// 
			this.giftsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.GiftsTableAdapter = this.giftsTableAdapter;
			this.tableAdapterManager.HouseInformationTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ITMO.CSCourse.Exam5.ReadSQLDBForm.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "FirstName", true));
			this.firstNameTextBox.Location = new System.Drawing.Point(118, 269);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
			this.firstNameTextBox.TabIndex = 5;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "LastName", true));
			this.lastNameTextBox.Location = new System.Drawing.Point(118, 295);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
			this.lastNameTextBox.TabIndex = 7;
			// 
			// houseNameShortTextBox
			// 
			this.houseNameShortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "HouseNameShort", true));
			this.houseNameShortTextBox.Location = new System.Drawing.Point(118, 321);
			this.houseNameShortTextBox.Name = "houseNameShortTextBox";
			this.houseNameShortTextBox.Size = new System.Drawing.Size(200, 20);
			this.houseNameShortTextBox.TabIndex = 9;
			// 
			// giftTextShortTextBox
			// 
			this.giftTextShortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "GiftTextShort", true));
			this.giftTextShortTextBox.Location = new System.Drawing.Point(118, 347);
			this.giftTextShortTextBox.Name = "giftTextShortTextBox";
			this.giftTextShortTextBox.Size = new System.Drawing.Size(200, 20);
			this.giftTextShortTextBox.TabIndex = 11;
			// 
			// giftURLTextBox
			// 
			this.giftURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "GiftURL", true));
			this.giftURLTextBox.Location = new System.Drawing.Point(118, 373);
			this.giftURLTextBox.Name = "giftURLTextBox";
			this.giftURLTextBox.Size = new System.Drawing.Size(200, 20);
			this.giftURLTextBox.TabIndex = 13;
			// 
			// deliveryDateDateTimePicker
			// 
			this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.giftsBindingSource, "DeliveryDate", true));
			this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(118, 399);
			this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
			this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.deliveryDateDateTimePicker.TabIndex = 15;
			// 
			// buttonAddNewRecordToDB
			// 
			this.buttonAddNewRecordToDB.Location = new System.Drawing.Point(457, 272);
			this.buttonAddNewRecordToDB.Name = "buttonAddNewRecordToDB";
			this.buttonAddNewRecordToDB.Size = new System.Drawing.Size(169, 23);
			this.buttonAddNewRecordToDB.TabIndex = 16;
			this.buttonAddNewRecordToDB.Text = "Новая запись";
			this.buttonAddNewRecordToDB.UseVisualStyleBackColor = true;
			this.buttonAddNewRecordToDB.Click += new System.EventHandler(this.buttonAddNewRecordToDB_Click);
			// 
			// buttonSaveChangesToDB
			// 
			this.buttonSaveChangesToDB.Location = new System.Drawing.Point(457, 301);
			this.buttonSaveChangesToDB.Name = "buttonSaveChangesToDB";
			this.buttonSaveChangesToDB.Size = new System.Drawing.Size(169, 23);
			this.buttonSaveChangesToDB.TabIndex = 17;
			this.buttonSaveChangesToDB.Text = "Сохранить";
			this.buttonSaveChangesToDB.UseVisualStyleBackColor = true;
			this.buttonSaveChangesToDB.Click += new System.EventHandler(this.buttonSaveChangesToDB_Click);
			// 
			// buttonDeleteRecordFromDB
			// 
			this.buttonDeleteRecordFromDB.Location = new System.Drawing.Point(457, 331);
			this.buttonDeleteRecordFromDB.Name = "buttonDeleteRecordFromDB";
			this.buttonDeleteRecordFromDB.Size = new System.Drawing.Size(169, 23);
			this.buttonDeleteRecordFromDB.TabIndex = 18;
			this.buttonDeleteRecordFromDB.Text = "Удалить запись";
			this.buttonDeleteRecordFromDB.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 494);
			this.Controls.Add(this.buttonDeleteRecordFromDB);
			this.Controls.Add(this.buttonSaveChangesToDB);
			this.Controls.Add(this.buttonAddNewRecordToDB);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(houseNameShortLabel);
			this.Controls.Add(this.houseNameShortTextBox);
			this.Controls.Add(giftTextShortLabel);
			this.Controls.Add(this.giftTextShortTextBox);
			this.Controls.Add(giftURLLabel);
			this.Controls.Add(this.giftURLTextBox);
			this.Controls.Add(deliveryDateLabel);
			this.Controls.Add(this.deliveryDateDateTimePicker);
			this.Controls.Add(this.giftsDataGridView);
			this.Controls.Add(this.giftsBindingNavigator);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingNavigator)).EndInit();
			this.giftsBindingNavigator.ResumeLayout(false);
			this.giftsBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giftsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource giftsBindingSource;
		private DataSet1TableAdapters.GiftsTableAdapter giftsTableAdapter;
		private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator giftsBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.DataGridView giftsDataGridView;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox houseNameShortTextBox;
		private System.Windows.Forms.TextBox giftTextShortTextBox;
		private System.Windows.Forms.TextBox giftURLTextBox;
		private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
		private System.Windows.Forms.Button buttonAddNewRecordToDB;
		private System.Windows.Forms.Button buttonSaveChangesToDB;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.Button buttonDeleteRecordFromDB;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton giftsBindingNavigatorSaveItem;
	}
}