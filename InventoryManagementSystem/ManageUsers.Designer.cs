namespace InventoryManagementSystem
{
	partial class ManageUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.textBoxUsPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsName = new System.Windows.Forms.TextBox();
			this.buttonUserAdd = new System.Windows.Forms.Button();
			this.buttonUserEdit = new System.Windows.Forms.Button();
			this.buttonUserDelete = new System.Windows.Forms.Button();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1094, 161);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-11, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1034, 9);
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
			this.label1.Location = new System.Drawing.Point(338, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "MANAGE USERS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(199, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(615, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel2.Location = new System.Drawing.Point(0, 738);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1094, 49);
			this.panel2.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.ForeColor = System.Drawing.Color.SaddleBrown;
			this.textBoxName.Location = new System.Drawing.Point(119, 236);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(309, 38);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.Text = "Name";
			this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSurname.ForeColor = System.Drawing.Color.SaddleBrown;
			this.textBoxSurname.Location = new System.Drawing.Point(119, 326);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(309, 38);
			this.textBoxSurname.TabIndex = 7;
			this.textBoxSurname.Text = "Surname";
			this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
			this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
			// 
			// textBoxUsPassword
			// 
			this.textBoxUsPassword.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxUsPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsPassword.ForeColor = System.Drawing.Color.SaddleBrown;
			this.textBoxUsPassword.Location = new System.Drawing.Point(477, 326);
			this.textBoxUsPassword.Name = "textBoxUsPassword";
			this.textBoxUsPassword.Size = new System.Drawing.Size(309, 38);
			this.textBoxUsPassword.TabIndex = 9;
			this.textBoxUsPassword.Text = "Password";
			this.textBoxUsPassword.Enter += new System.EventHandler(this.textBoxUsPassword_Enter);
			this.textBoxUsPassword.Leave += new System.EventHandler(this.textBoxUsPassword_Leave);
			// 
			// textBoxUsName
			// 
			this.textBoxUsName.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxUsName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsName.ForeColor = System.Drawing.Color.SaddleBrown;
			this.textBoxUsName.Location = new System.Drawing.Point(477, 236);
			this.textBoxUsName.Name = "textBoxUsName";
			this.textBoxUsName.Size = new System.Drawing.Size(309, 38);
			this.textBoxUsName.TabIndex = 8;
			this.textBoxUsName.Text = "UserName";
			this.textBoxUsName.Enter += new System.EventHandler(this.textBoxUsName_Enter);
			this.textBoxUsName.Leave += new System.EventHandler(this.textBoxUsName_Leave);
			// 
			// buttonUserAdd
			// 
			this.buttonUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.buttonUserAdd.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUserAdd.ForeColor = System.Drawing.Color.White;
			this.buttonUserAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonUserAdd.Location = new System.Drawing.Point(903, 200);
			this.buttonUserAdd.Name = "buttonUserAdd";
			this.buttonUserAdd.Size = new System.Drawing.Size(92, 53);
			this.buttonUserAdd.TabIndex = 10;
			this.buttonUserAdd.Text = "ADD";
			this.buttonUserAdd.UseVisualStyleBackColor = false;
			this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
			// 
			// buttonUserEdit
			// 
			this.buttonUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.buttonUserEdit.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUserEdit.ForeColor = System.Drawing.Color.White;
			this.buttonUserEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonUserEdit.Location = new System.Drawing.Point(903, 278);
			this.buttonUserEdit.Name = "buttonUserEdit";
			this.buttonUserEdit.Size = new System.Drawing.Size(92, 53);
			this.buttonUserEdit.TabIndex = 11;
			this.buttonUserEdit.Text = "EDIT";
			this.buttonUserEdit.UseVisualStyleBackColor = false;
			this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.buttonUserDelete.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUserDelete.ForeColor = System.Drawing.Color.White;
			this.buttonUserDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonUserDelete.Location = new System.Drawing.Point(903, 353);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Size = new System.Drawing.Size(92, 53);
			this.buttonUserDelete.TabIndex = 13;
			this.buttonUserDelete.Text = "Delete";
			this.buttonUserDelete.UseVisualStyleBackColor = false;
			this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Location = new System.Drawing.Point(14, 432);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.RowHeadersWidth = 51;
			this.dataGridViewUsers.RowTemplate.Height = 24;
			this.dataGridViewUsers.Size = new System.Drawing.Size(1066, 297);
			this.dataGridViewUsers.TabIndex = 14;
			this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
			// 
			// ManageUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1094, 773);
			this.Controls.Add(this.dataGridViewUsers);
			this.Controls.Add(this.buttonUserDelete);
			this.Controls.Add(this.buttonUserEdit);
			this.Controls.Add(this.buttonUserAdd);
			this.Controls.Add(this.textBoxUsPassword);
			this.Controls.Add(this.textBoxUsName);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageUsers";
			this.Load += new System.EventHandler(this.ManageUsers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.TextBox textBoxUsPassword;
		private System.Windows.Forms.TextBox textBoxUsName;
		private System.Windows.Forms.Button buttonUserAdd;
		private System.Windows.Forms.Button buttonUserEdit;
		private System.Windows.Forms.Button buttonUserDelete;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}