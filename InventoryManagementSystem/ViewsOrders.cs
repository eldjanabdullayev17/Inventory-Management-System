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
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class ViewsOrders : Form
	{
		public ViewsOrders()
		{
			InitializeComponent();
		}

		private void ViewsOrders_Load(object sender, EventArgs e)
		{
			SqlCommand list = new SqlCommand
				(
				"select CONCAT(c.Name,space(1),c.Surname) as CustomerName,o.OrderDate,sum(o.TotalPrice) as TotalAmount from Orders o" +
				"\r\ninner join Products p on p.Id = o.ProductId" +
				"\r\ninner join Customers c on c.Id = o.CustomerId" +
				"\r\ngroup by CONCAT(c.Name,space(1),c.Surname),o.OrderDate"
				, 
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(list);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridViewViewsOrders.DataSource = dt;

			dataGridViewViewsOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

			dataGridViewViewsOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridViewViewsOrders.AutoResizeColumns();

			dataGridViewViewsOrders.ClearSelection();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			ManageOrders manageOrders = new ManageOrders();
			manageOrders.Show();
			this.Hide();
		}
	}
}
