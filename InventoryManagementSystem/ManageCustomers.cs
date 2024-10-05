using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class ManageCustomers : Form
	{
		public ManageCustomers()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ManageCustomers_Load(object sender, EventArgs e)
		{
			SelectCommand.LoadOrRefreshPage("Customers", dataGridViewCustomers);

			dataGridViewCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCustomers.AutoResizeColumns();

			dataGridViewCustomers.ClearSelection();

			textBoxCusName.Text = "Name";
			textBoxCusSurname.Text = "Surname";
			dateTimePickerCusBirthdate.Text = DateTime.Now.ToString();
			textBoxCusPhone.Text = "Phone";
		}

		private void textBoxCusName_Enter(object sender, EventArgs e)
		{
			if (textBoxCusName.Text == "Name")
			{
				textBoxCusName.Text = "";
				textBoxCusName.ForeColor = Color.Red;
			}
		}

		private void textBoxCusName_Leave(object sender, EventArgs e)
		{
			if (textBoxCusName.Text == "")
			{
				textBoxCusName.Text = "Name";
				textBoxCusName.ForeColor = Color.Red;
			}
		}

		private void textBoxCusSurname_Enter(object sender, EventArgs e)
		{
			if (textBoxCusSurname.Text == "Surname")
			{
				textBoxCusSurname.Text = "";
				textBoxCusSurname.ForeColor = Color.Red;
			}
		}

		private void textBoxCusSurname_Leave(object sender, EventArgs e)
		{
			if (textBoxCusSurname.Text == "")
			{
				textBoxCusSurname.Text = "Surname";
				textBoxCusSurname.ForeColor = Color.Red;
			}
		}

		private void textBoxCusPhone_Enter(object sender, EventArgs e)
		{
			if (textBoxCusPhone.Text == "Phone")
			{
				textBoxCusPhone.Text = "";
				textBoxCusPhone.ForeColor = Color.Red;
			}
		}

		private void textBoxCusPhone_Leave(object sender, EventArgs e)
		{
			if (textBoxCusPhone.Text == "")
			{
				textBoxCusPhone.Text = "Phone";
				textBoxCusPhone.ForeColor = Color.Red;
			}
		}

		int selectedId;
		private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				selectedId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["Id"].Value);

				textBoxCusName.Text = dataGridViewCustomers.CurrentRow.Cells["Name"].Value.ToString();
				textBoxCusSurname.Text = dataGridViewCustomers.CurrentRow.Cells["Surname"].Value.ToString();
				dateTimePickerCusBirthdate.Text = dataGridViewCustomers.CurrentRow.Cells["BirthDate"].Value.ToString();
				textBoxCusPhone.Text = dataGridViewCustomers.CurrentRow.Cells["Phone"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void buttonCusDelete_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Delete Customer!!",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (d == DialogResult.Yes)
			{
				SqlCommand deleteCustomer = new SqlCommand(
					"delete from Customers where Id = @pId",
					SQLCONNECT.connection);

				SQLCONNECT.CheckConnection(SQLCONNECT.connection);

				deleteCustomer.Parameters.AddWithValue("@pId", selectedId);

				deleteCustomer.ExecuteNonQuery();

				SelectCommand.LoadOrRefreshPage("Customers", dataGridViewCustomers);

				textBoxCusName.Text = "Name";
				textBoxCusSurname.Text = "Surname";
				dateTimePickerCusBirthdate.Text = DateTime.Now.ToString();
				textBoxCusPhone.Text = "Phone";
			}
		}
		private void buttonCusEdit_Click(object sender, EventArgs e)
		{
			SqlCommand editCustomer = new SqlCommand(
				"Update Customers " +
				"set Name = @pname, Surname = @psurname, BirthDate = @pBirthDate, Phone = @pPhone " +
				"where Id = @pId",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			string date = dateTimePickerCusBirthdate.Text = DateTime.Now.ToString("yyyy-MM-dd");

			editCustomer.Parameters.AddWithValue("@pId", selectedId);
			editCustomer.Parameters.AddWithValue("@pname", textBoxCusName.Text);
			editCustomer.Parameters.AddWithValue("@psurname", textBoxCusSurname.Text);
			editCustomer.Parameters.AddWithValue("@pBirthDate", date);
			editCustomer.Parameters.AddWithValue("@pPhone", textBoxCusPhone.Text);

			editCustomer.ExecuteNonQuery();

			MessageBox.Show("Customer Successfully Updated", "Update Customer",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Customers", dataGridViewCustomers);

			textBoxCusName.Text = "Name";
			textBoxCusSurname.Text = "Surname";
			dateTimePickerCusBirthdate.Text = DateTime.Now.ToString();
			textBoxCusPhone.Text = "Phone";
		}
		private void buttonCusAdd_Click(object sender, EventArgs e)
		{
			SqlCommand addCustomer = new SqlCommand(
				"insert into Customers(Name,Surname,BirthDate,Phone) values " +
				"(@pname,@psurname,@pBirthDate,@pPhone)",
				SQLCONNECT.connection);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			string date = DateTime.Now.ToString("yyyy-MM-dd");
			
			addCustomer.Parameters.AddWithValue("@pname", textBoxCusName.Text);
			addCustomer.Parameters.AddWithValue("@psurname", textBoxCusSurname.Text);
			addCustomer.Parameters.AddWithValue("@pBirthDate", date);
			addCustomer.Parameters.AddWithValue("@pPhone", textBoxCusPhone.Text);

			addCustomer.ExecuteNonQuery();

			MessageBox.Show("Customer Successfully Added", "Add Customers",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Customers", dataGridViewCustomers);

			textBoxCusName.Text = "Name";
			textBoxCusSurname.Text = "Surname";
			dateTimePickerCusBirthdate.Text = DateTime.Now.ToString();
			textBoxCusPhone.Text = "Phone";
		}

		private void pictureBoxcusExit_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}
	}
}
