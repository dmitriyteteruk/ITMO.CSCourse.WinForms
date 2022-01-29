using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_App_Sample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnLoadData(object sender, EventArgs e)
		{
			m_CustomersDataSet.ReadXml("GiftsDataSet.xml");
			m_CustomerGrid.DataSource = m_CustomersDataSet.Tables[0];
		}
	}
}
