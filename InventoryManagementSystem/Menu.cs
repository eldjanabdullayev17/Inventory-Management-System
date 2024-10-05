using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void pictureBoxProduct_Click(object sender, EventArgs e)
		{
			ManageProducts manageProducts = new ManageProducts();
			manageProducts.Show();
			this.Hide();
		}

		private void pictureBoxCategories_Click(object sender, EventArgs e)
		{
			ManageCategories manageCategories = new ManageCategories();
			manageCategories.Show();
			this.Hide();
		}

		private void pictureBoxUsers_Click(object sender, EventArgs e)
		{
			ManageUsers manageUsers = new ManageUsers();
			manageUsers.Show();
			this.Hide();
		}

		private void pictureBoxCustomers_Click(object sender, EventArgs e)
		{
			ManageCustomers manageCustomers = new ManageCustomers();
			manageCustomers.Show();
			this.Hide();
		}

		private void buttonorderadd_Click(object sender, EventArgs e)
		{
			loginForm loginForm = new loginForm();
			loginForm.Show();
			this.Hide();
		}

		private void pictureBoxOrders_Click(object sender, EventArgs e)
		{
			ManageOrders manageOrders = new ManageOrders();	
			manageOrders.Show();
			this.Hide();
		}
	}
}
