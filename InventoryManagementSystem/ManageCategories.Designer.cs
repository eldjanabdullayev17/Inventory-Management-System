namespace InventoryManagementSystem
{
	partial class ManageCategories
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
			this.textBoxCatName = new System.Windows.Forms.TextBox();
			this.buttonCatDelete = new System.Windows.Forms.Button();
			this.buttonCatEdit = new System.Windows.Forms.Button();
			this.buttonCatAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxcatExit = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcatExit)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(-3, 655);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1062, 57);
			this.panel2.TabIndex = 9;
			// 
			// dataGridViewCategories
			// 
			this.dataGridViewCategories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCategories.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridViewCategories.Location = new System.Drawing.Point(417, 177);
			this.dataGridViewCategories.Name = "dataGridViewCategories";
			this.dataGridViewCategories.RowHeadersWidth = 51;
			this.dataGridViewCategories.RowTemplate.Height = 24;
			this.dataGridViewCategories.Size = new System.Drawing.Size(603, 461);
			this.dataGridViewCategories.TabIndex = 10;
			this.dataGridViewCategories.SelectionChanged += new System.EventHandler(this.dataGridViewCategories_SelectionChanged);
			// 
			// textBoxCatName
			// 
			this.textBoxCatName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textBoxCatName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCatName.ForeColor = System.Drawing.Color.Brown;
			this.textBoxCatName.Location = new System.Drawing.Point(32, 287);
			this.textBoxCatName.Name = "textBoxCatName";
			this.textBoxCatName.Size = new System.Drawing.Size(336, 51);
			this.textBoxCatName.TabIndex = 17;
			this.textBoxCatName.Text = "Name";
			this.textBoxCatName.Enter += new System.EventHandler(this.textBoxCatName_Enter);
			this.textBoxCatName.Leave += new System.EventHandler(this.textBoxCatName_Leave);
			// 
			// buttonCatDelete
			// 
			this.buttonCatDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonCatDelete.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCatDelete.ForeColor = System.Drawing.Color.White;
			this.buttonCatDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCatDelete.Location = new System.Drawing.Point(270, 374);
			this.buttonCatDelete.Name = "buttonCatDelete";
			this.buttonCatDelete.Size = new System.Drawing.Size(98, 66);
			this.buttonCatDelete.TabIndex = 25;
			this.buttonCatDelete.Text = "Delete";
			this.buttonCatDelete.UseVisualStyleBackColor = false;
			this.buttonCatDelete.Click += new System.EventHandler(this.buttonCatDelete_Click);
			// 
			// buttonCatEdit
			// 
			this.buttonCatEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonCatEdit.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCatEdit.ForeColor = System.Drawing.Color.White;
			this.buttonCatEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCatEdit.Location = new System.Drawing.Point(151, 374);
			this.buttonCatEdit.Name = "buttonCatEdit";
			this.buttonCatEdit.Size = new System.Drawing.Size(102, 66);
			this.buttonCatEdit.TabIndex = 24;
			this.buttonCatEdit.Text = "EDIT";
			this.buttonCatEdit.UseVisualStyleBackColor = false;
			this.buttonCatEdit.Click += new System.EventHandler(this.buttonCatEdit_Click);
			// 
			// buttonCatAdd
			// 
			this.buttonCatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonCatAdd.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCatAdd.ForeColor = System.Drawing.Color.White;
			this.buttonCatAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCatAdd.Location = new System.Drawing.Point(32, 374);
			this.buttonCatAdd.Name = "buttonCatAdd";
			this.buttonCatAdd.Size = new System.Drawing.Size(103, 66);
			this.buttonCatAdd.TabIndex = 23;
			this.buttonCatAdd.Text = "ADD";
			this.buttonCatAdd.UseVisualStyleBackColor = false;
			this.buttonCatAdd.Click += new System.EventHandler(this.buttonCatAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(251, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(385, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "MANAGE CATEGORIES";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(999, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 50);
			this.label2.TabIndex = 5;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(146, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(615, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// pictureBoxcatExit
			// 
			this.pictureBoxcatExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcatExit.Image")));
			this.pictureBoxcatExit.Location = new System.Drawing.Point(-15, 3);
			this.pictureBoxcatExit.Name = "pictureBoxcatExit";
			this.pictureBoxcatExit.Size = new System.Drawing.Size(76, 47);
			this.pictureBoxcatExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxcatExit.TabIndex = 8;
			this.pictureBoxcatExit.TabStop = false;
			this.pictureBoxcatExit.Click += new System.EventHandler(this.pictureBoxcatExit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBoxcatExit);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 149);
			this.panel1.TabIndex = 7;
			// 
			// ManageCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1054, 712);
			this.Controls.Add(this.buttonCatDelete);
			this.Controls.Add(this.buttonCatEdit);
			this.Controls.Add(this.buttonCatAdd);
			this.Controls.Add(this.textBoxCatName);
			this.Controls.Add(this.dataGridViewCategories);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageCategories";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageCategories";
			this.Load += new System.EventHandler(this.ManageCategories_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcatExit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridViewCategories;
		private System.Windows.Forms.TextBox textBoxCatName;
		private System.Windows.Forms.Button buttonCatDelete;
		private System.Windows.Forms.Button buttonCatEdit;
		private System.Windows.Forms.Button buttonCatAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxcatExit;
		private System.Windows.Forms.Panel panel1;
	}
}