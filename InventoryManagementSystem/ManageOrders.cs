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
	public partial class ManageOrders : Form
	{
		public ManageOrders()
		{
			InitializeComponent();
		}

		private void ManageOrders_Load(object sender, EventArgs e)
		{
			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewProducts.AutoResizeColumns();

			dataGridViewProducts.ClearSelection();

			SelectCommand.LoadOrRefreshPage("Customers", dataGridViewCustomers);

			dataGridViewCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCustomers.AutoResizeColumns();

			dataGridViewCustomers.ClearSelection();

			SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryName FROM Categories", SQLCONNECT.connection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			comboBox.DataSource = dt;
			comboBox.DisplayMember = "CategoryName";
			comboBox.ValueMember = "CategoryName";

			textBoxorderQuantity.Text = "Quantity";

			SelectCommand.OrderRefreshPage(dataGridViewOrder);
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			int categoryIndex = comboBox.SelectedIndex + 1;

			SqlCommand sqlCommand = new SqlCommand
				($"select p.Id,p.ProductName,p.ProductQuantity,p.Price,p.Description,c.CategoryName from Products p" +
				$"\r\ninner join Categories c on c.Id = p.CategoryId\r\nwhere p.CategoryId = {categoryIndex}",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridViewProducts.DataSource = dt;
		}

		private void textBoxorderQuantity_Enter(object sender, EventArgs e)
		{
			if (textBoxorderQuantity.Text == "Quantity")
			{
				textBoxorderQuantity.Text = "";
				textBoxorderQuantity.ForeColor = Color.Red;
			}
		}

		private void textBoxorderQuantity_Leave(object sender, EventArgs e)
		{
			if (textBoxorderQuantity.Text == "")
			{
				textBoxorderQuantity.Text = "Quantity";
				textBoxorderQuantity.ForeColor = Color.Red;
			}
		}

		int productSelectedId;
		decimal productPrice;
		int customerSelectedId;
		private void buttonorderadd_Click(object sender, EventArgs e)
		{
			SqlCommand addOrder = new SqlCommand
				(
				"insert into Orders(ProductId,CustomerId,OrderQuantity,OrderDate,TotalPrice)" +
				"\r\nvalues" +
				"\r\n(@ProductId,@CustomerId,@OrderQuantity,@OrderDate,@TotalPrice)"
				, SQLCONNECT.connection);

			SQLCONNECT.CheckConnection (SQLCONNECT.connection);

			string orderDate = DateTime.Now.ToString("yyyy-MM-dd");

			addOrder.Parameters.AddWithValue("@ProductId", productSelectedId);
			addOrder.Parameters.AddWithValue("@CustomerId",customerSelectedId);
			addOrder.Parameters.AddWithValue("@OrderQuantity",Convert.ToInt32(textBoxorderQuantity.Text));
			addOrder.Parameters.AddWithValue("@OrderDate", orderDate );
			addOrder.Parameters.AddWithValue("@TotalPrice", (Convert.ToDecimal(textBoxorderQuantity.Text)*productPrice));

			addOrder.ExecuteNonQuery();

			MessageBox.Show("Order Successfully Added", "Add Orders",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.OrderRefreshPage(dataGridViewOrder);

			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			textBoxorderQuantity.Text = "Quantity";

		}

		private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				productSelectedId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["Id"].Value);
				productPrice = Convert.ToDecimal(dataGridViewProducts.CurrentRow.Cells["Price"].Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				customerSelectedId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["Id"].Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void pictureBoxcusExit_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}

		private void buttonvieworder_Click(object sender, EventArgs e)
		{
			ViewsOrders viewsOrders = new ViewsOrders();
			viewsOrders.Show();
		}
	}
}
