using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.PasswordHash;
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class ManageUsers : Form
	{
		public ManageUsers()
		{
			InitializeComponent();
		}

		private void ManageUsers_Load(object sender, EventArgs e)
		{
			SelectCommand.LoadOrRefreshPage("Users",dataGridViewUsers);

			dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

			// Sütunların avtomatik genişlənməsi üçün təyin edilir
			dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Minimum pəncərə ölçüsü təyin edilir ki, pəncərə çox kiçilməsin
			this.MinimumSize = new Size(800, 600); // Burada 800x600 ilə minimal ölçü verilir

			// Daha yaxşı görünüş üçün formanın genişlənən xüsusiyyətlərini aktivləşdirin
			dataGridViewUsers.AutoResizeColumns();

			dataGridViewUsers.ClearSelection();

			textBoxName.Text = "Name";
			textBoxSurname.Text = "Surname";
			textBoxUsName.Text = "UserName";
			textBoxUsPassword.Text = "Password";
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBoxName_Enter(object sender, EventArgs e)
		{
			if(textBoxName.Text == "Name")
			{
				textBoxName.Text = "";
				textBoxName.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxName_Leave(object sender, EventArgs e)
		{
			if (textBoxName.Text == "")
			{
				textBoxName.Text = "Name";
				textBoxName.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxSurname_Enter(object sender, EventArgs e)
		{
			if (textBoxSurname.Text == "Surname")
			{
				 textBoxSurname.Text = "";
				textBoxSurname.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxSurname_Leave(object sender, EventArgs e)
		{
			if (textBoxSurname.Text == "")
			{
				textBoxSurname.Text = "Surname";
				textBoxSurname.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxUsName_Enter(object sender, EventArgs e)
		{
			if (textBoxUsName.Text == "UserName")
			{
				textBoxUsName.Text = "";
				textBoxUsName.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxUsName_Leave(object sender, EventArgs e)
		{
			if (textBoxUsName.Text == "")
			{
				textBoxUsName.Text = "UserName";
				textBoxUsName.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxUsPassword_Enter(object sender, EventArgs e)
		{
			if (textBoxUsPassword.Text == "Password")
			{
				textBoxUsPassword.Text = "";
				textBoxUsPassword.ForeColor = Color.SaddleBrown;
			}
		}

		private void textBoxUsPassword_Leave(object sender, EventArgs e)
		{
			if (textBoxUsPassword.Text == "")
			{
				textBoxUsPassword.Text = "Password";
				textBoxUsPassword.ForeColor = Color.SaddleBrown;
			}
		}

		private void buttonUserAdd_Click(object sender, EventArgs e)
		{
			SqlCommand insertUser = new SqlCommand
				("insert into Users(Name,Surname,UserName,Password) values " +
				"(@pname,@psurname,@pusername,@ppassword)",
				SQLCONNECT.connection);

			string hashPassword = Sha256Hash.ComputeSha256Hash(textBoxUsPassword.Text);

			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			insertUser.Parameters.AddWithValue("@pname",textBoxName.Text);
			insertUser.Parameters.AddWithValue("@psurname",textBoxSurname.Text);
			insertUser.Parameters.AddWithValue("@pusername",textBoxUsName.Text);
			insertUser.Parameters.AddWithValue("@ppassword", hashPassword);

			insertUser.ExecuteNonQuery();

			MessageBox.Show("User Successfully Added", "Add User",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Users",dataGridViewUsers);

			textBoxName.Text = "Name";
			textBoxSurname.Text = "Surname";
			textBoxUsName.Text = "UserName";		
			textBoxUsPassword.Text = "Password";
		}

		int selectedId;

		private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				selectedId = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["Id"].Value);

				textBoxName.Text = dataGridViewUsers.CurrentRow.Cells["Name"].Value.ToString();
				textBoxSurname.Text = dataGridViewUsers.CurrentRow.Cells["Surname"].Value.ToString();
				textBoxUsName.Text = dataGridViewUsers.CurrentRow.Cells["UserName"].Value.ToString();
				textBoxUsPassword.Text = dataGridViewUsers.CurrentRow.Cells["Password"].Value.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show($"{ex.Message}", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Are you sure you want to delete?", "Delete User!!",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if(d == DialogResult.Yes)
			{
				SqlCommand deleteUsers = new SqlCommand(
					"delete from Users where Id = @pId",
					SQLCONNECT.connection);

				SQLCONNECT.CheckConnection(SQLCONNECT.connection);

				deleteUsers.Parameters.AddWithValue("@pId", selectedId);

				deleteUsers.ExecuteNonQuery();


				SelectCommand.LoadOrRefreshPage("Users", dataGridViewUsers);

				textBoxName.Text = "Name";
				textBoxSurname.Text = "Surname";
				textBoxUsName.Text = "UserName";
				textBoxUsPassword.Text = "Password";

			}
		}

		private void buttonUserEdit_Click(object sender, EventArgs e)
		{

			SqlCommand editUsers = new SqlCommand(
				"Update Users " +
				"set Name = @pname, Surname = @psurname, UserName = @pusername, Password = @ppassword " +
				"where Id = @pId",
				SQLCONNECT.connection);

			string hashPassword = Sha256Hash.ComputeSha256Hash(textBoxUsPassword.Text);


			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			editUsers.Parameters.AddWithValue("@pId", selectedId);
			editUsers.Parameters.AddWithValue("@pname", textBoxName.Text);
			editUsers.Parameters.AddWithValue("@psurname", textBoxSurname.Text);
			editUsers.Parameters.AddWithValue("@pusername", textBoxUsName.Text);
			editUsers.Parameters.AddWithValue("@ppassword", hashPassword);

			editUsers.ExecuteNonQuery();

			MessageBox.Show("User Successfully Updated", "Update User",
			MessageBoxButtons.OK,
			MessageBoxIcon.None);

			SelectCommand.LoadOrRefreshPage("Users", dataGridViewUsers);

			textBoxName.Text = "Name";
			textBoxSurname.Text = "Surname";
			textBoxUsName.Text = "UserName";
			textBoxUsPassword.Text = "Password";

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}
	}
}
