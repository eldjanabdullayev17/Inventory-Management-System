namespace InventoryManagementSystem
{
	partial class ManageProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxcusExit = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxProductPrice = new System.Windows.Forms.TextBox();
			this.textBoxProductDescription = new System.Windows.Forms.TextBox();
			this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.buttonCusDelete = new System.Windows.Forms.Button();
			this.buttonCusEdit = new System.Windows.Forms.Button();
			this.buttonCusAdd = new System.Windows.Forms.Button();
			this.comboBoxProductSearch = new System.Windows.Forms.ComboBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Firebrick;
			this.panel1.Controls.Add(this.pictureBoxcusExit);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1194, 170);
			this.panel1.TabIndex = 2;
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
			this.label2.Location = new System.Drawing.Point(1133, 6);
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
			this.label1.Location = new System.Drawing.Point(371, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "MANAGE PRODUCTS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(254, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(615, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// textBoxProductPrice
			// 
			this.textBoxProductPrice.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxProductPrice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductPrice.ForeColor = System.Drawing.Color.Red;
			this.textBoxProductPrice.Location = new System.Drawing.Point(28, 386);
			this.textBoxProductPrice.Name = "textBoxProductPrice";
			this.textBoxProductPrice.Size = new System.Drawing.Size(325, 43);
			this.textBoxProductPrice.TabIndex = 17;
			this.textBoxProductPrice.Text = "Price";
			this.textBoxProductPrice.Enter += new System.EventHandler(this.textBoxProductPrice_Enter);
			this.textBoxProductPrice.Leave += new System.EventHandler(this.textBoxProductPrice_Leave);
			// 
			// textBoxProductDescription
			// 
			this.textBoxProductDescription.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxProductDescription.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductDescription.ForeColor = System.Drawing.Color.Red;
			this.textBoxProductDescription.Location = new System.Drawing.Point(28, 449);
			this.textBoxProductDescription.Name = "textBoxProductDescription";
			this.textBoxProductDescription.Size = new System.Drawing.Size(325, 43);
			this.textBoxProductDescription.TabIndex = 18;
			this.textBoxProductDescription.Text = "Description";
			this.textBoxProductDescription.Enter += new System.EventHandler(this.textBoxProductDescription_Enter);
			this.textBoxProductDescription.Leave += new System.EventHandler(this.textBoxProductDescription_Leave);
			// 
			// textBoxProductQuantity
			// 
			this.textBoxProductQuantity.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxProductQuantity.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductQuantity.ForeColor = System.Drawing.Color.Red;
			this.textBoxProductQuantity.Location = new System.Drawing.Point(28, 320);
			this.textBoxProductQuantity.Name = "textBoxProductQuantity";
			this.textBoxProductQuantity.Size = new System.Drawing.Size(325, 43);
			this.textBoxProductQuantity.TabIndex = 19;
			this.textBoxProductQuantity.Text = "Quantity";
			this.textBoxProductQuantity.Enter += new System.EventHandler(this.textBoxProductQuantity_Enter);
			this.textBoxProductQuantity.Leave += new System.EventHandler(this.textBoxProductQuantity_Leave);
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductName.ForeColor = System.Drawing.Color.Red;
			this.textBoxProductName.Location = new System.Drawing.Point(28, 257);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(325, 43);
			this.textBoxProductName.TabIndex = 20;
			this.textBoxProductName.Text = "Product Name";
			this.textBoxProductName.Enter += new System.EventHandler(this.textBoxProductName_Enter);
			this.textBoxProductName.Leave += new System.EventHandler(this.textBoxProductName_Leave);
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(28, 517);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(325, 45);
			this.comboBoxCategory.TabIndex = 21;
			// 
			// buttonCusDelete
			// 
			this.buttonCusDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonCusDelete.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCusDelete.ForeColor = System.Drawing.Color.White;
			this.buttonCusDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCusDelete.Location = new System.Drawing.Point(261, 590);
			this.buttonCusDelete.Name = "buttonCusDelete";
			this.buttonCusDelete.Size = new System.Drawing.Size(92, 53);
			this.buttonCusDelete.TabIndex = 25;
			this.buttonCusDelete.Text = "Delete";
			this.buttonCusDelete.UseVisualStyleBackColor = false;
			this.buttonCusDelete.Click += new System.EventHandler(this.buttonCusDelete_Click);
			// 
			// buttonCusEdit
			// 
			this.buttonCusEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonCusEdit.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCusEdit.ForeColor = System.Drawing.Color.White;
			this.buttonCusEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCusEdit.Location = new System.Drawing.Point(143, 590);
			this.buttonCusEdit.Name = "buttonCusEdit";
			this.buttonCusEdit.Size = new System.Drawing.Size(92, 53);
			this.buttonCusEdit.TabIndex = 24;
			this.buttonCusEdit.Text = "EDIT";
			this.buttonCusEdit.UseVisualStyleBackColor = false;
			this.buttonCusEdit.Click += new System.EventHandler(this.buttonCusEdit_Click);
			// 
			// buttonCusAdd
			// 
			this.buttonCusAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonCusAdd.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCusAdd.ForeColor = System.Drawing.Color.White;
			this.buttonCusAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCusAdd.Location = new System.Drawing.Point(28, 590);
			this.buttonCusAdd.Name = "buttonCusAdd";
			this.buttonCusAdd.Size = new System.Drawing.Size(92, 53);
			this.buttonCusAdd.TabIndex = 23;
			this.buttonCusAdd.Text = "ADD";
			this.buttonCusAdd.UseVisualStyleBackColor = false;
			this.buttonCusAdd.Click += new System.EventHandler(this.buttonCusAdd_Click);
			// 
			// comboBoxProductSearch
			// 
			this.comboBoxProductSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.comboBoxProductSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxProductSearch.FormattingEnabled = true;
			this.comboBoxProductSearch.Location = new System.Drawing.Point(610, 197);
			this.comboBoxProductSearch.Name = "comboBoxProductSearch";
			this.comboBoxProductSearch.Size = new System.Drawing.Size(325, 45);
			this.comboBoxProductSearch.TabIndex = 26;
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonSearch.Location = new System.Drawing.Point(946, 193);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(108, 57);
			this.buttonSearch.TabIndex = 27;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRefresh.ForeColor = System.Drawing.Color.White;
			this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonRefresh.Location = new System.Drawing.Point(1060, 193);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(106, 57);
			this.buttonRefresh.TabIndex = 28;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Location = new System.Drawing.Point(412, 257);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.RowHeadersWidth = 51;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.Size = new System.Drawing.Size(754, 547);
			this.dataGridViewProducts.TabIndex = 29;
			this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Firebrick;
			this.panel2.Location = new System.Drawing.Point(-1, 822);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1194, 39);
			this.panel2.TabIndex = 10;
			// 
			// ManageProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1190, 860);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxProductSearch);
			this.Controls.Add(this.buttonCusDelete);
			this.Controls.Add(this.buttonCusEdit);
			this.Controls.Add(this.buttonCusAdd);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.textBoxProductPrice);
			this.Controls.Add(this.textBoxProductDescription);
			this.Controls.Add(this.textBoxProductQuantity);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageProducts";
			this.Load += new System.EventHandler(this.ManageProducts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxcusExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxProductPrice;
		private System.Windows.Forms.TextBox textBoxProductDescription;
		private System.Windows.Forms.TextBox textBoxProductQuantity;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button buttonCusDelete;
		private System.Windows.Forms.Button buttonCusEdit;
		private System.Windows.Forms.Button buttonCusAdd;
		private System.Windows.Forms.ComboBox comboBoxProductSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Panel panel2;
	}
}