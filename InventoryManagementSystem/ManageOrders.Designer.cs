namespace InventoryManagementSystem
{
	partial class ManageOrders
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxcusExit = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
			this.buttonorderadd = new System.Windows.Forms.Button();
			this.textBoxorderQuantity = new System.Windows.Forms.TextBox();
			this.buttonvieworder = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Firebrick;
			this.panel1.Controls.Add(this.pictureBoxcusExit);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1190, 131);
			this.panel1.TabIndex = 3;
			// 
			// pictureBoxcusExit
			// 
			this.pictureBoxcusExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcusExit.Image")));
			this.pictureBoxcusExit.Location = new System.Drawing.Point(-16, 3);
			this.pictureBoxcusExit.Name = "pictureBoxcusExit";
			this.pictureBoxcusExit.Size = new System.Drawing.Size(76, 47);
			this.pictureBoxcusExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxcusExit.TabIndex = 9;
			this.pictureBoxcusExit.TabStop = false;
			this.pictureBoxcusExit.Click += new System.EventHandler(this.pictureBoxcusExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1141, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 50);
			this.label2.TabIndex = 5;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(394, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "MANAGE ORDERS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(254, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(615, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Location = new System.Drawing.Point(12, 212);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.RowHeadersWidth = 51;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.Size = new System.Drawing.Size(528, 255);
			this.dataGridViewProducts.TabIndex = 32;
			this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonSearch.Location = new System.Drawing.Point(432, 145);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(108, 49);
			this.buttonSearch.TabIndex = 31;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// comboBox
			// 
			this.comboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.comboBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(96, 147);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(325, 45);
			this.comboBox.TabIndex = 30;
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 527);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.RowHeadersWidth = 51;
			this.dataGridViewCustomers.RowTemplate.Height = 24;
			this.dataGridViewCustomers.Size = new System.Drawing.Size(528, 255);
			this.dataGridViewCustomers.TabIndex = 33;
			this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(184, 476);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 41);
			this.label4.TabIndex = 10;
			this.label4.Text = "Customers";
			// 
			// dataGridViewOrder
			// 
			this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrder.Location = new System.Drawing.Point(574, 212);
			this.dataGridViewOrder.Name = "dataGridViewOrder";
			this.dataGridViewOrder.RowHeadersWidth = 51;
			this.dataGridViewOrder.RowTemplate.Height = 24;
			this.dataGridViewOrder.Size = new System.Drawing.Size(585, 479);
			this.dataGridViewOrder.TabIndex = 34;
			// 
			// buttonorderadd
			// 
			this.buttonorderadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonorderadd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonorderadd.ForeColor = System.Drawing.Color.White;
			this.buttonorderadd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonorderadd.Location = new System.Drawing.Point(962, 142);
			this.buttonorderadd.Name = "buttonorderadd";
			this.buttonorderadd.Size = new System.Drawing.Size(197, 60);
			this.buttonorderadd.TabIndex = 36;
			this.buttonorderadd.Text = "ADD TO ORDER";
			this.buttonorderadd.UseVisualStyleBackColor = false;
			this.buttonorderadd.Click += new System.EventHandler(this.buttonorderadd_Click);
			// 
			// textBoxorderQuantity
			// 
			this.textBoxorderQuantity.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxorderQuantity.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxorderQuantity.ForeColor = System.Drawing.Color.Red;
			this.textBoxorderQuantity.Location = new System.Drawing.Point(574, 147);
			this.textBoxorderQuantity.Name = "textBoxorderQuantity";
			this.textBoxorderQuantity.Size = new System.Drawing.Size(382, 51);
			this.textBoxorderQuantity.TabIndex = 35;
			this.textBoxorderQuantity.Text = "Quantity";
			this.textBoxorderQuantity.Enter += new System.EventHandler(this.textBoxorderQuantity_Enter);
			this.textBoxorderQuantity.Leave += new System.EventHandler(this.textBoxorderQuantity_Leave);
			// 
			// buttonvieworder
			// 
			this.buttonvieworder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonvieworder.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonvieworder.ForeColor = System.Drawing.Color.White;
			this.buttonvieworder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonvieworder.Location = new System.Drawing.Point(853, 705);
			this.buttonvieworder.Name = "buttonvieworder";
			this.buttonvieworder.Size = new System.Drawing.Size(306, 77);
			this.buttonvieworder.TabIndex = 37;
			this.buttonvieworder.Text = "View Order";
			this.buttonvieworder.UseVisualStyleBackColor = false;
			this.buttonvieworder.Click += new System.EventHandler(this.buttonvieworder_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Firebrick;
			this.panel2.Location = new System.Drawing.Point(0, 800);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1190, 27);
			this.panel2.TabIndex = 10;
			// 
			// ManageOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 824);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.buttonvieworder);
			this.Controls.Add(this.buttonorderadd);
			this.Controls.Add(this.textBoxorderQuantity);
			this.Controls.Add(this.dataGridViewOrder);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageOrders";
			this.Load += new System.EventHandler(this.ManageOrders_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxcusExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.DataGridView dataGridViewCustomers;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridViewOrder;
		private System.Windows.Forms.Button buttonorderadd;
		private System.Windows.Forms.TextBox textBoxorderQuantity;
		private System.Windows.Forms.Button buttonvieworder;
		private System.Windows.Forms.Panel panel2;
	}
}