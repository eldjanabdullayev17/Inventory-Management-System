using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class ManageProducts : Form
	{
		public ManageProducts()
		{
			InitializeComponent();
		}

		private void ManageProducts_Load(object sender, EventArgs e)
		{
			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewProducts.AutoResizeColumns();

			dataGridViewProducts.ClearSelection();

			SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryName FROM Categories", SQLCONNECT.connection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			comboBoxCategory.DataSource = dt;
			comboBoxCategory.DisplayMember = "CategoryName";
			comboBoxCategory.ValueMember = "CategoryName";

			comboBoxProductSearch.DataSource = dt;
			comboBoxProductSearch.DisplayMember = "CategoryName";
			comboBoxProductSearch.ValueMember = "CategoryName";

			textBoxProductDescription.Text = "Description";
			textBoxProductName.Text = "Product Name";
			textBoxProductQuantity.Text = "Quantity";
			textBoxProductPrice.Text = "Price";
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBoxProductName_Enter(object sender, EventArgs e)
		{
			if (textBoxProductName.Text == "Product Name")
			{	
				textBoxProductName.Text = "";
				textBoxProductName.ForeColor = Color.Red;
			}
		}

		private void textBoxProductQuantity_Enter(object sender, EventArgs e)
		{
			if (textBoxProductQuantity.Text == "Quantity")
			{
				textBoxProductQuantity.Text = "";
				textBoxProductQuantity.ForeColor = Color.Red;
			}
		}

		private void textBoxProductPrice_Enter(object sender, EventArgs e)
		{
			if (textBoxProductPrice.Text == "Price")
			{
				textBoxProductPrice.Text = "";
				textBoxProductPrice.ForeColor = Color.Red;
			}
		}

		private void textBoxProductDescription_Enter(object sender, EventArgs e)
		{
			if(textBoxProductDescription.Text == "Description")
			{
				textBoxProductDescription.Text = "";
				textBoxProductDescription.ForeColor = Color.Red;
			}
		}

		private void textBoxProductName_Leave(object sender, EventArgs e)
		{
			if (textBoxProductName.Text == "")
			{
				textBoxProductName.Text = "Product Name";
				textBoxProductName.ForeColor = Color.Red;
			}
		}

		private void textBoxProductQuantity_Leave(object sender, EventArgs e)
		{
			if (textBoxProductQuantity.Text == "")
			{
				textBoxProductQuantity.Text = "Quantity";
				textBoxProductQuantity.ForeColor = Color.Red;
			}
		}

		private void textBoxProductPrice_Leave(object sender, EventArgs e)
		{
			if (textBoxProductPrice.Text == "")
			{
				textBoxProductPrice.Text = "Price";
				textBoxProductPrice.ForeColor = Color.Red;
			}
		}

		private void textBoxProductDescription_Leave(object sender, EventArgs e)
		{
			if (textBoxProductDescription.Text == "")
			{
				textBoxProductDescription.Text = "Description";
				textBoxProductDescription.ForeColor = Color.Red;
			}
		}

		int selectedId;
		private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
		{

			try
			{
				selectedId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["Id"].Value);

				textBoxProductName.Text = dataGridViewProducts.CurrentRow.Cells["ProductName"].Value.ToString();
				textBoxProductPrice.Text = dataGridViewProducts.CurrentRow.Cells["Price"].Value.ToString();
				textBoxProductQuantity.Text = dataGridViewProducts.CurrentRow.Cells["ProductQuantity"].Value.ToString();
				textBoxProductDescription.Text = dataGridViewProducts.CurrentRow.Cells["Description"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCusAdd_Click(object sender, EventArgs e)
		{
			SqlCommand addProduct = new SqlCommand(
				"insert into Products(ProductName,ProductQuantity,Price,Description,CategoryId) values"+
				"(@pProductName,@pProductQuantity,@pPrice,@pDescription,@pCategoryId)",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			string category = comboBoxCategory.Text;

			// 2. Id-ni alırıq
			int categoryId=0;
			using (SqlCommand id = new SqlCommand("SELECT Id FROM Categories WHERE CategoryName = @CategoryName", SQLCONNECT.connection))
			{
				id.Parameters.AddWithValue("@CategoryName", category);

				// 3. Id-ni alırıq
				object result = id.ExecuteScalar();
				if (result != null)
				{
					categoryId = (int)result;
				}
				else
				{
					// Category tapılmadı
					MessageBox.Show("Category not found.");
				}
			}


			addProduct.Parameters.AddWithValue("@pProductName", textBoxProductName.Text);
			addProduct.Parameters.AddWithValue("@pProductQuantity", Convert.ToInt32(textBoxProductQuantity.Text));
			addProduct.Parameters.AddWithValue("@pPrice", Convert.ToDecimal(textBoxProductPrice.Text));
			addProduct.Parameters.AddWithValue("@pDescription", textBoxProductDescription.Text);
			addProduct.Parameters.AddWithValue("@pCategoryId", categoryId);

			addProduct.ExecuteNonQuery();

			MessageBox.Show("Product Successfully Added", "Add Products",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			textBoxProductDescription.Text = "Description";
			textBoxProductName.Text = "Product Name";
			textBoxProductQuantity.Text = "Quantity";
			textBoxProductPrice.Text = "Price";
		}

		private void buttonCusEdit_Click(object sender, EventArgs e)
		{
			SqlCommand editProduct = new SqlCommand(
				"Update Products " +
				"set ProductName = @pProductName, ProductQuantity = @pProductQuantity, Price = @pPrice, Description = @pDescription, CategoryId = @pCategoryId " +
				"where Id = @pId",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			string category = comboBoxCategory.Text;

			// 2. Id-ni alırıq
			int categoryId = 0;
			using (SqlCommand id = new SqlCommand("SELECT Id FROM Categories WHERE CategoryName = @CategoryName", SQLCONNECT.connection))
			{
				id.Parameters.AddWithValue("@CategoryName", category);

				// 3. Id-ni alırıq
				object result = id.ExecuteScalar();
				if (result != null)
				{
					categoryId = (int)result;
				}
				else
				{
					// Category tapılmadı
					MessageBox.Show("Category not found.");
				}
			}

			editProduct.Parameters.AddWithValue("@pId", selectedId);
			editProduct.Parameters.AddWithValue("@pProductName", textBoxProductName.Text);
			editProduct.Parameters.AddWithValue("@pProductQuantity", Convert.ToInt32(textBoxProductQuantity.Text));
			editProduct.Parameters.AddWithValue("@pPrice", Convert.ToDecimal(textBoxProductPrice.Text));
			editProduct.Parameters.AddWithValue("@pDescription", textBoxProductDescription.Text);
			editProduct.Parameters.AddWithValue("@pCategoryId", categoryId);

			editProduct.ExecuteNonQuery();

			MessageBox.Show("Product Successfully Updated", "Update Products",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			textBoxProductDescription.Text = "Description";
			textBoxProductName.Text = "Product Name";
			textBoxProductQuantity.Text = "Quantity";
			textBoxProductPrice.Text = "Price";
		}

		private void buttonCusDelete_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Delete Product!!",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (d == DialogResult.Yes)
			{
				SqlCommand deleteProduct = new SqlCommand(
					"delete from Products where Id = @pId",
					SQLCONNECT.connection);

				SQLCONNECT.CheckConnection(SQLCONNECT.connection);

				deleteProduct.Parameters.AddWithValue("@pId", selectedId);

				deleteProduct.ExecuteNonQuery();

				SelectCommand.ProductRefreshPage(dataGridViewProducts);

				textBoxProductDescription.Text = "Description";
				textBoxProductName.Text = "Product Name";
				textBoxProductQuantity.Text = "Quantity";
				textBoxProductPrice.Text = "Price";
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			int categoryIndex = comboBoxCategory.SelectedIndex + 1;

			SqlCommand sqlCommand = new SqlCommand
				($"select p.Id,p.ProductName,p.ProductQuantity,p.Price,p.Description,c.CategoryName from Products p" +
				$"\r\ninner join Categories c on c.Id = p.CategoryId\r\nwhere p.CategoryId = {categoryIndex}",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable();

			da.Fill(dt);

			dataGridViewProducts.DataSource = dt;

			textBoxProductDescription.Text = "Description";
			textBoxProductName.Text = "Product Name";
			textBoxProductQuantity.Text = "Quantity";
			textBoxProductPrice.Text = "Price";

		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			SelectCommand.ProductRefreshPage(dataGridViewProducts);

			textBoxProductDescription.Text = "Description";
			textBoxProductName.Text = "Product Name";
			textBoxProductQuantity.Text = "Quantity";
			textBoxProductPrice.Text = "Price";
		}

		private void pictureBoxcusExit_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}
	}
}
