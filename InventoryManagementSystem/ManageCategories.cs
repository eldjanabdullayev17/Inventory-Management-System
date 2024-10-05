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
	public partial class ManageCategories : Form
	{
		public ManageCategories()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void textBoxCatName_Enter(object sender, EventArgs e)
		{
			if (textBoxCatName.Text == "Category Name")
			{
				textBoxCatName.Text = "";
				textBoxCatName.ForeColor = Color.Brown;
			}
		}

		private void textBoxCatName_Leave(object sender, EventArgs e)
		{
			if (textBoxCatName.Text == "")
			{
				textBoxCatName.Text = "Category Name";
				textBoxCatName.ForeColor = Color.Brown;
			}
		}

		private void ManageCategories_Load(object sender, EventArgs e)
		{
			SelectCommand.LoadOrRefreshPage("Categories", dataGridViewCategories);


			// DatagridView-i pəncərə ölçüsünə uyğunlaşdır
			dataGridViewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

			// Sütunların avtomatik genişlənməsi üçün təyin edilir
			dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Daha yaxşı görünüş üçün formanın genişlənən xüsusiyyətlərini aktivləşdirin
			dataGridViewCategories.AutoResizeColumns();

			dataGridViewCategories.ClearSelection();

			textBoxCatName.Text = "Category Name";
		}

		private void buttonCatAdd_Click(object sender, EventArgs e)
		{
			SqlCommand addCategory = new SqlCommand(
				"insert into Categories(CategoryName) values (@pname)",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			addCategory.Parameters.AddWithValue("@pname", textBoxCatName.Text);

			addCategory.ExecuteNonQuery();

			MessageBox.Show("Category Successfully Added", "Add Category",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Categories", dataGridViewCategories);

			textBoxCatName.Text = "Category Name";

		}

		private void buttonCatEdit_Click(object sender, EventArgs e)
		{
			SqlCommand editCategory = new SqlCommand(
				"Update Categories " +
				"set CategoryName = @pname where Id = @pId",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			editCategory.Parameters.AddWithValue("@pId", selectedId);
			editCategory.Parameters.AddWithValue("@pname", textBoxCatName.Text);

			editCategory.ExecuteNonQuery();

			MessageBox.Show("Category Successfully Updated", "Update Category",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Categories", dataGridViewCategories);

			textBoxCatName.Text = "Category Name";
		}

		private void buttonCatDelete_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Delete Category!!",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (d == DialogResult.Yes)
			{
				SqlCommand deleteCategory = new SqlCommand(
					"delete from Categories where Id = @pId",
					SQLCONNECT.connection);

				SQLCONNECT.CheckConnection(SQLCONNECT.connection);

				deleteCategory.Parameters.AddWithValue("@pId", selectedId);

				deleteCategory.ExecuteNonQuery();

				SelectCommand.LoadOrRefreshPage("Categories", dataGridViewCategories);

				textBoxCatName.Text = "Category Name";
			}
		}

		int selectedId;
		private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				selectedId = Convert.ToInt32(dataGridViewCategories.CurrentRow.Cells["Id"].Value);

				textBoxCatName.Text = dataGridViewCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void pictureBoxcatExit_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}
	}
}
