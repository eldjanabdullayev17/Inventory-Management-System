using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace InventoryManagementSystem.SQL
{
	public class SQLCONNECT
	{
		public static SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=InventoryManagementSystem;Integrated Security=True");

		public static void CheckConnection(SqlConnection sqlConnection)
		{
			if(sqlConnection.State == ConnectionState.Closed)
			{
				sqlConnection.Open();
			}
			else
			{

			}
		} 
	
	}
}
