using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.SQL;

namespace InventoryManagementSystem
{
	public partial class Test : Form
	{
		public Test()
		{
			InitializeComponent();
		}

		private void Test_Load(object sender, EventArgs e)
		{
			

			SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryName FROM Categories", SQLCONNECT.connection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			comboBox1.DataSource = dt;
			comboBox1.DisplayMember = "CategoryName";
			comboBox1.ValueMember = "CategoryName";
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex;
			label1.Text = index.ToString();
		}
	}
}
