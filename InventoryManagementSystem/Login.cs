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
using InventoryManagementSystem.PasswordHash;
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class loginForm : Form
	{
		public loginForm()
		{
			InitializeComponent();
		}

		private void tboxUserName_Enter(object sender, EventArgs e)
		{
			if (tboxUserName.Text == "UserName")
			{
				tboxUserName.Text = "";
				tboxUserName.ForeColor = Color.White;
			}
		}

		private void tboxUserName_Leave(object sender, EventArgs e)
		{
			if (tboxUserName.Text == "")
			{
				tboxUserName.Text = "UserName";
				tboxUserName.ForeColor = Color.LightGray;
			}
		}

		private void textboxPassword_Enter(object sender, EventArgs e)
		{
			if (textboxPassword.Text == "Password")
			{
				textboxPassword.Text = "";
				textboxPassword.ForeColor = Color.White;
			}
		}

		private void textboxPassword_Leave(object sender, EventArgs e)
		{
			if (textboxPassword.Text == "")
			{
				textboxPassword.Text = "Password";
				textboxPassword.ForeColor = Color.LightGray;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				textboxPassword.PasswordChar = '\0'; 
			}
			else
			{
				textboxPassword.PasswordChar = '*'; 
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			tboxUserName.Text = "";
			textboxPassword.Text = "";
		}

		private void loginForm_Load(object sender, EventArgs e)
		{

		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand("select * from Users where UserName = @pUserName and Password = @pPassword",SQLCONNECT.connection);
			
			SQLCONNECT.CheckConnection(SQLCONNECT.connection);

			string hashPassword = Sha256Hash.ComputeSha256Hash(textboxPassword.Text);

			sqlCommand.Parameters.AddWithValue("@pUserName", tboxUserName.Text);
			sqlCommand.Parameters.AddWithValue("@pPassword", hashPassword);

			SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

			DataTable dt = new DataTable();
			
			dataAdapter.Fill(dt);

			if(dt.Rows.Count > 0)
			{
				Menu menu = new Menu();
				menu.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Username or password is incorrect", "Login failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		
		}
	}
}
