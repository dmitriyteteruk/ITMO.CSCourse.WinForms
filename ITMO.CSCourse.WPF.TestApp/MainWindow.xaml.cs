using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ITMO.CSCourse.WPF.TestApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, RoutedEventArgs e)
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
							//for (int i = 0; i < reader.FieldCount; ++i)
							//lbResultData.Items.Add(reader[i].ToString() + " ");
							//lbResultData.Items.Add(reader[i] + " ");
							lbResultData.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4] + " " + reader[5] + " " + reader[6] + " " + reader[7]);
						}
					}
				}
			}
		}

		private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Button_CleanResultWindow_Click(object sender, RoutedEventArgs e)
		{
			lbResultData.Items.Clear();
		}

		private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}