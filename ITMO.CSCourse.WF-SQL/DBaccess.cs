using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ITMO.CSCourse.WF_SQL
{
	class DBaccess
	{
		SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Gifts;Integrated Security=true;");

		public void OpenConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
		}

		public void CloseConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
				connection.Close();
		}

		public SqlConnection GetConnection()
		{
			return connection;
		}
	}
}