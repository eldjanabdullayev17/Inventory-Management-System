using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.SQL;
using System.Windows.Forms;

namespace InventoryManagementSystem.SQL
{
	public class SelectCommand
	{
		public static void LoadOrRefreshPage(string tableName, DataGridView dataGridView)
		{
			SqlCommand list = new SqlCommand($"select * from {tableName}", SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(list);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridView.DataSource = dt;
		}

		public static void ProductRefreshPage(DataGridView dataGridView)
		{
			SqlCommand list = new SqlCommand
				("select p.Id,p.ProductName,p.ProductQuantity,p.Price,p.Description,c.CategoryName from Products p" +
				"\r\ninner join Categories c on c.Id = p.CategoryId", SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(list);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridView.DataSource = dt;
		}

		public static void OrderRefreshPage(DataGridView dataGridView)
		{
			SqlCommand list = new SqlCommand
				(
				"select p.ProductName,o.OrderQuantity,p.Price,(p.Price*o.OrderQuantity) as TotalPrice from Orders o" +
				"\r\ninner join Products p on p.Id = o.ProductId" +
				"\r\ninner join Customers c on c.Id = o.CustomerId"
				, 
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(list);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridView.DataSource = dt;

		}

	}
}
