using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Exam5.ReadSQLDBForm
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void giftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.giftsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dataSet1);

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.Gifts' table. You can move, or remove it, as needed.
			this.giftsTableAdapter.Fill(this.dataSet1.Gifts);

		}

		private void buttonAddNewRecordToDB_Click(object sender, EventArgs e)
		{
			giftsBindingSource.AddNew();
		}

		private void buttonSaveChangesToDB_Click(object sender, EventArgs e)
		{
			giftsBindingSource.EndEdit();
			giftsTableAdapter.Update(dataSet1);
		}

		private void giftsBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{

		}
	}
}
