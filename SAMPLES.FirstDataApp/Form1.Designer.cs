
namespace SAMPLES.FirstDataApp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.Label employeeIDLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label titleLabel;
			System.Windows.Forms.Label titleOfCourtesyLabel;
			System.Windows.Forms.Label birthDateLabel;
			System.Windows.Forms.Label hireDateLabel;
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label regionLabel;
			System.Windows.Forms.Label postalCodeLabel;
			System.Windows.Forms.Label countryLabel;
			System.Windows.Forms.Label homePhoneLabel;
			System.Windows.Forms.Label extensionLabel;
			System.Windows.Forms.Label photoLabel;
			System.Windows.Forms.Label notesLabel;
			System.Windows.Forms.Label reportsToLabel;
			System.Windows.Forms.Label photoPathLabel;
			this.northwindDataSet = new SAMPLES.FirstDataApp.NorthwindDataSet();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesTableAdapter = new SAMPLES.FirstDataApp.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
			this.tableAdapterManager = new SAMPLES.FirstDataApp.NorthwindDataSetTableAdapters.TableAdapterManager();
			this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.employeeIDTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.titleOfCourtesyTextBox = new System.Windows.Forms.TextBox();
			this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.hireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.homePhoneTextBox = new System.Windows.Forms.TextBox();
			this.extensionTextBox = new System.Windows.Forms.TextBox();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.notesTextBox = new System.Windows.Forms.TextBox();
			this.reportsToTextBox = new System.Windows.Forms.TextBox();
			this.photoPathTextBox = new System.Windows.Forms.TextBox();
			employeeIDLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			firstNameLabel = new System.Windows.Forms.Label();
			titleLabel = new System.Windows.Forms.Label();
			titleOfCourtesyLabel = new System.Windows.Forms.Label();
			birthDateLabel = new System.Windows.Forms.Label();
			hireDateLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			regionLabel = new System.Windows.Forms.Label();
			postalCodeLabel = new System.Windows.Forms.Label();
			countryLabel = new System.Windows.Forms.Label();
			homePhoneLabel = new System.Windows.Forms.Label();
			extensionLabel = new System.Windows.Forms.Label();
			photoLabel = new System.Windows.Forms.Label();
			notesLabel = new System.Windows.Forms.Label();
			reportsToLabel = new System.Windows.Forms.Label();
			photoPathLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
			this.employeesBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// northwindDataSet
			// 
			this.northwindDataSet.DataSetName = "NorthwindDataSet";
			this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.northwindDataSet;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
			this.tableAdapterManager.UpdateOrder = SAMPLES.FirstDataApp.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// employeesBindingNavigator
			// 
			this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
			this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeesBindingNavigatorSaveItem});
			this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.employeesBindingNavigator.Name = "employeesBindingNavigator";
			this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.employeesBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.employeesBindingNavigator.TabIndex = 0;
			this.employeesBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// employeesBindingNavigatorSaveItem
			// 
			this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
			this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
			this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.employeesBindingNavigatorSaveItem.Text = "Save Data";
			this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
			// 
			// employeeIDLabel
			// 
			employeeIDLabel.AutoSize = true;
			employeeIDLabel.Location = new System.Drawing.Point(30, 48);
			employeeIDLabel.Name = "employeeIDLabel";
			employeeIDLabel.Size = new System.Drawing.Size(70, 13);
			employeeIDLabel.TabIndex = 1;
			employeeIDLabel.Text = "Employee ID:";
			// 
			// employeeIDTextBox
			// 
			this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
			this.employeeIDTextBox.Location = new System.Drawing.Point(124, 45);
			this.employeeIDTextBox.Name = "employeeIDTextBox";
			this.employeeIDTextBox.Size = new System.Drawing.Size(200, 20);
			this.employeeIDTextBox.TabIndex = 2;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new System.Drawing.Point(30, 74);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(61, 13);
			lastNameLabel.TabIndex = 3;
			lastNameLabel.Text = "Last Name:";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
			this.lastNameTextBox.Location = new System.Drawing.Point(124, 71);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
			this.lastNameTextBox.TabIndex = 4;
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new System.Drawing.Point(30, 100);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(60, 13);
			firstNameLabel.TabIndex = 5;
			firstNameLabel.Text = "First Name:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
			this.firstNameTextBox.Location = new System.Drawing.Point(124, 97);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
			this.firstNameTextBox.TabIndex = 6;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Location = new System.Drawing.Point(30, 126);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new System.Drawing.Size(30, 13);
			titleLabel.TabIndex = 7;
			titleLabel.Text = "Title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Title", true));
			this.titleTextBox.Location = new System.Drawing.Point(124, 123);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(200, 20);
			this.titleTextBox.TabIndex = 8;
			// 
			// titleOfCourtesyLabel
			// 
			titleOfCourtesyLabel.AutoSize = true;
			titleOfCourtesyLabel.Location = new System.Drawing.Point(30, 152);
			titleOfCourtesyLabel.Name = "titleOfCourtesyLabel";
			titleOfCourtesyLabel.Size = new System.Drawing.Size(88, 13);
			titleOfCourtesyLabel.TabIndex = 9;
			titleOfCourtesyLabel.Text = "Title Of Courtesy:";
			// 
			// titleOfCourtesyTextBox
			// 
			this.titleOfCourtesyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "TitleOfCourtesy", true));
			this.titleOfCourtesyTextBox.Location = new System.Drawing.Point(124, 149);
			this.titleOfCourtesyTextBox.Name = "titleOfCourtesyTextBox";
			this.titleOfCourtesyTextBox.Size = new System.Drawing.Size(200, 20);
			this.titleOfCourtesyTextBox.TabIndex = 10;
			// 
			// birthDateLabel
			// 
			birthDateLabel.AutoSize = true;
			birthDateLabel.Location = new System.Drawing.Point(30, 179);
			birthDateLabel.Name = "birthDateLabel";
			birthDateLabel.Size = new System.Drawing.Size(57, 13);
			birthDateLabel.TabIndex = 11;
			birthDateLabel.Text = "Birth Date:";
			// 
			// birthDateDateTimePicker
			// 
			this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "BirthDate", true));
			this.birthDateDateTimePicker.Location = new System.Drawing.Point(124, 175);
			this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
			this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.birthDateDateTimePicker.TabIndex = 12;
			// 
			// hireDateLabel
			// 
			hireDateLabel.AutoSize = true;
			hireDateLabel.Location = new System.Drawing.Point(30, 205);
			hireDateLabel.Name = "hireDateLabel";
			hireDateLabel.Size = new System.Drawing.Size(55, 13);
			hireDateLabel.TabIndex = 13;
			hireDateLabel.Text = "Hire Date:";
			// 
			// hireDateDateTimePicker
			// 
			this.hireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "HireDate", true));
			this.hireDateDateTimePicker.Location = new System.Drawing.Point(124, 201);
			this.hireDateDateTimePicker.Name = "hireDateDateTimePicker";
			this.hireDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.hireDateDateTimePicker.TabIndex = 14;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(30, 230);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 15;
			addressLabel.Text = "Address:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(124, 227);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(200, 20);
			this.addressTextBox.TabIndex = 16;
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(30, 256);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 17;
			cityLabel.Text = "City:";
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(124, 253);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(200, 20);
			this.cityTextBox.TabIndex = 18;
			// 
			// regionLabel
			// 
			regionLabel.AutoSize = true;
			regionLabel.Location = new System.Drawing.Point(30, 282);
			regionLabel.Name = "regionLabel";
			regionLabel.Size = new System.Drawing.Size(44, 13);
			regionLabel.TabIndex = 19;
			regionLabel.Text = "Region:";
			// 
			// regionTextBox
			// 
			this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Region", true));
			this.regionTextBox.Location = new System.Drawing.Point(124, 279);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(200, 20);
			this.regionTextBox.TabIndex = 20;
			// 
			// postalCodeLabel
			// 
			postalCodeLabel.AutoSize = true;
			postalCodeLabel.Location = new System.Drawing.Point(30, 308);
			postalCodeLabel.Name = "postalCodeLabel";
			postalCodeLabel.Size = new System.Drawing.Size(67, 13);
			postalCodeLabel.TabIndex = 21;
			postalCodeLabel.Text = "Postal Code:";
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PostalCode", true));
			this.postalCodeTextBox.Location = new System.Drawing.Point(124, 305);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
			this.postalCodeTextBox.TabIndex = 22;
			// 
			// countryLabel
			// 
			countryLabel.AutoSize = true;
			countryLabel.Location = new System.Drawing.Point(30, 334);
			countryLabel.Name = "countryLabel";
			countryLabel.Size = new System.Drawing.Size(46, 13);
			countryLabel.TabIndex = 23;
			countryLabel.Text = "Country:";
			// 
			// countryTextBox
			// 
			this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Country", true));
			this.countryTextBox.Location = new System.Drawing.Point(124, 331);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(200, 20);
			this.countryTextBox.TabIndex = 24;
			// 
			// homePhoneLabel
			// 
			homePhoneLabel.AutoSize = true;
			homePhoneLabel.Location = new System.Drawing.Point(30, 360);
			homePhoneLabel.Name = "homePhoneLabel";
			homePhoneLabel.Size = new System.Drawing.Size(72, 13);
			homePhoneLabel.TabIndex = 25;
			homePhoneLabel.Text = "Home Phone:";
			// 
			// homePhoneTextBox
			// 
			this.homePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HomePhone", true));
			this.homePhoneTextBox.Location = new System.Drawing.Point(124, 357);
			this.homePhoneTextBox.Name = "homePhoneTextBox";
			this.homePhoneTextBox.Size = new System.Drawing.Size(200, 20);
			this.homePhoneTextBox.TabIndex = 26;
			// 
			// extensionLabel
			// 
			extensionLabel.AutoSize = true;
			extensionLabel.Location = new System.Drawing.Point(30, 386);
			extensionLabel.Name = "extensionLabel";
			extensionLabel.Size = new System.Drawing.Size(56, 13);
			extensionLabel.TabIndex = 27;
			extensionLabel.Text = "Extension:";
			// 
			// extensionTextBox
			// 
			this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Extension", true));
			this.extensionTextBox.Location = new System.Drawing.Point(124, 383);
			this.extensionTextBox.Name = "extensionTextBox";
			this.extensionTextBox.Size = new System.Drawing.Size(200, 20);
			this.extensionTextBox.TabIndex = 28;
			// 
			// photoLabel
			// 
			photoLabel.AutoSize = true;
			photoLabel.Location = new System.Drawing.Point(30, 409);
			photoLabel.Name = "photoLabel";
			photoLabel.Size = new System.Drawing.Size(38, 13);
			photoLabel.TabIndex = 29;
			photoLabel.Text = "Photo:";
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Photo", true));
			this.photoPictureBox.Location = new System.Drawing.Point(124, 409);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(200, 50);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.photoPictureBox.TabIndex = 30;
			this.photoPictureBox.TabStop = false;
			// 
			// notesLabel
			// 
			notesLabel.AutoSize = true;
			notesLabel.Location = new System.Drawing.Point(30, 468);
			notesLabel.Name = "notesLabel";
			notesLabel.Size = new System.Drawing.Size(38, 13);
			notesLabel.TabIndex = 31;
			notesLabel.Text = "Notes:";
			// 
			// notesTextBox
			// 
			this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Notes", true));
			this.notesTextBox.Location = new System.Drawing.Point(124, 465);
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.Size = new System.Drawing.Size(200, 20);
			this.notesTextBox.TabIndex = 32;
			// 
			// reportsToLabel
			// 
			reportsToLabel.AutoSize = true;
			reportsToLabel.Location = new System.Drawing.Point(30, 494);
			reportsToLabel.Name = "reportsToLabel";
			reportsToLabel.Size = new System.Drawing.Size(63, 13);
			reportsToLabel.TabIndex = 33;
			reportsToLabel.Text = "Reports To:";
			// 
			// reportsToTextBox
			// 
			this.reportsToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ReportsTo", true));
			this.reportsToTextBox.Location = new System.Drawing.Point(124, 491);
			this.reportsToTextBox.Name = "reportsToTextBox";
			this.reportsToTextBox.Size = new System.Drawing.Size(200, 20);
			this.reportsToTextBox.TabIndex = 34;
			// 
			// photoPathLabel
			// 
			photoPathLabel.AutoSize = true;
			photoPathLabel.Location = new System.Drawing.Point(30, 520);
			photoPathLabel.Name = "photoPathLabel";
			photoPathLabel.Size = new System.Drawing.Size(63, 13);
			photoPathLabel.TabIndex = 35;
			photoPathLabel.Text = "Photo Path:";
			// 
			// photoPathTextBox
			// 
			this.photoPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PhotoPath", true));
			this.photoPathTextBox.Location = new System.Drawing.Point(124, 517);
			this.photoPathTextBox.Name = "photoPathTextBox";
			this.photoPathTextBox.Size = new System.Drawing.Size(200, 20);
			this.photoPathTextBox.TabIndex = 36;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 557);
			this.Controls.Add(employeeIDLabel);
			this.Controls.Add(this.employeeIDTextBox);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(titleLabel);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(titleOfCourtesyLabel);
			this.Controls.Add(this.titleOfCourtesyTextBox);
			this.Controls.Add(birthDateLabel);
			this.Controls.Add(this.birthDateDateTimePicker);
			this.Controls.Add(hireDateLabel);
			this.Controls.Add(this.hireDateDateTimePicker);
			this.Controls.Add(addressLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(cityLabel);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(regionLabel);
			this.Controls.Add(this.regionTextBox);
			this.Controls.Add(postalCodeLabel);
			this.Controls.Add(this.postalCodeTextBox);
			this.Controls.Add(countryLabel);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(homePhoneLabel);
			this.Controls.Add(this.homePhoneTextBox);
			this.Controls.Add(extensionLabel);
			this.Controls.Add(this.extensionTextBox);
			this.Controls.Add(photoLabel);
			this.Controls.Add(this.photoPictureBox);
			this.Controls.Add(notesLabel);
			this.Controls.Add(this.notesTextBox);
			this.Controls.Add(reportsToLabel);
			this.Controls.Add(this.reportsToTextBox);
			this.Controls.Add(photoPathLabel);
			this.Controls.Add(this.photoPathTextBox);
			this.Controls.Add(this.employeesBindingNavigator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
			this.employeesBindingNavigator.ResumeLayout(false);
			this.employeesBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox employeeIDTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.TextBox titleOfCourtesyTextBox;
		private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker hireDateDateTimePicker;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox homePhoneTextBox;
		private System.Windows.Forms.TextBox extensionTextBox;
		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.TextBox notesTextBox;
		private System.Windows.Forms.TextBox reportsToTextBox;
		private System.Windows.Forms.TextBox photoPathTextBox;
	}
}

