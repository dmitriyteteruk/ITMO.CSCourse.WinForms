using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMTO.CSCourse.SQL_connection
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WindowsForms;Data Source=DESKTOP-JAMOVG3\\SQLEXPRESS"))
			{
				cn.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Gifts", cn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							lbResultData.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + reader[3] + " " + reader[4] + " " + reader[5] + " " + reader[6] + " " + reader[7]);
						}
					}
				}
			}
		}
	}
}
