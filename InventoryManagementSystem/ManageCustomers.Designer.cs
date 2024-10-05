namespace InventoryManagementSystem
{
	partial class ManageCustomers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxcusExit = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.buttonCusDelete = new System.Windows.Forms.Button();
			this.buttonCusEdit = new System.Windows.Forms.Button();
			this.buttonCusAdd = new System.Windows.Forms.Button();
			this.textBoxCusSurname = new System.Windows.Forms.TextBox();
			this.textBoxCusName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxCusPhone = new System.Windows.Forms.TextBox();
			this.dateTimePickerCusBirthdate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Firebrick;
			this.panel1.Controls.Add(this.pictureBoxcusExit);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1109, 163);
			this.panel1.TabIndex = 1;
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
			this.label2.Location = new System.Drawing.Point(1036, 10);
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
			this.label1.Location = new System.Drawing.Point(327, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "MANAGE CUSTOMERS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(199, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(615, 45);
			this.label3.TabIndex = 3;
			this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 333);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.RowHeadersWidth = 51;
			this.dataGridViewCustomers.RowTemplate.Height = 24;
			this.dataGridViewCustomers.Size = new System.Drawing.Size(1070, 382);
			this.dataGridViewCustomers.TabIndex = 23;
			this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
			// 
			// buttonCusDelete
			// 
			this.buttonCusDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonCusDelete.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCusDelete.ForeColor = System.Drawing.Color.White;
			this.buttonCusDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.buttonCusDelete.Location = new System.Drawing.Point(955, 220);
			this.buttonCusDelete.Name = "buttonCusDelete";
			this.buttonCusDelete.Size = new System.Drawing.Size(92, 53);
			this.buttonCusDelete.TabIndex = 22;
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
			this.buttonCusEdit.Location = new System.Drawing.Point(837, 220);
			this.buttonCusEdit.Name = "buttonCusEdit";
			this.buttonCusEdit.Size = new System.Drawing.Size(92, 53);
			this.buttonCusEdit.TabIndex = 21;
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
			this.buttonCusAdd.Location = new System.Drawing.Point(722, 220);
			this.buttonCusAdd.Name = "buttonCusAdd";
			this.buttonCusAdd.Size = new System.Drawing.Size(92, 53);
			this.buttonCusAdd.TabIndex = 20;
			this.buttonCusAdd.Text = "ADD";
			this.buttonCusAdd.UseVisualStyleBackColor = false;
			this.buttonCusAdd.Click += new System.EventHandler(this.buttonCusAdd_Click);
			// 
			// textBoxCusSurname
			// 
			this.textBoxCusSurname.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCusSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCusSurname.ForeColor = System.Drawing.Color.Red;
			this.textBoxCusSurname.Location = new System.Drawing.Point(371, 203);
			this.textBoxCusSurname.Name = "textBoxCusSurname";
			this.textBoxCusSurname.Size = new System.Drawing.Size(288, 38);
			this.textBoxCusSurname.TabIndex = 17;
			this.textBoxCusSurname.Text = "Surname";
			this.textBoxCusSurname.Enter += new System.EventHandler(this.textBoxCusSurname_Enter);
			this.textBoxCusSurname.Leave += new System.EventHandler(this.textBoxCusSurname_Leave);
			// 
			// textBoxCusName
			// 
			this.textBoxCusName.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCusName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCusName.ForeColor = System.Drawing.Color.Red;
			this.textBoxCusName.Location = new System.Drawing.Point(33, 203);
			this.textBoxCusName.Name = "textBoxCusName";
			this.textBoxCusName.Size = new System.Drawing.Size(288, 38);
			this.textBoxCusName.TabIndex = 16;
			this.textBoxCusName.Text = "Name";
			this.textBoxCusName.Enter += new System.EventHandler(this.textBoxCusName_Enter);
			this.textBoxCusName.Leave += new System.EventHandler(this.textBoxCusName_Leave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Firebrick;
			this.panel2.Location = new System.Drawing.Point(0, 736);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1096, 37);
			this.panel2.TabIndex = 15;
			// 
			// textBoxCusPhone
			// 
			this.textBoxCusPhone.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCusPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCusPhone.ForeColor = System.Drawing.Color.Red;
			this.textBoxCusPhone.Location = new System.Drawing.Point(371, 263);
			this.textBoxCusPhone.Name = "textBoxCusPhone";
			this.textBoxCusPhone.Size = new System.Drawing.Size(288, 38);
			this.textBoxCusPhone.TabIndex = 19;
			this.textBoxCusPhone.Text = "Phone";
			this.textBoxCusPhone.Enter += new System.EventHandler(this.textBoxCusPhone_Enter);
			this.textBoxCusPhone.Leave += new System.EventHandler(this.textBoxCusPhone_Leave);
			// 
			// dateTimePickerCusBirthdate
			// 
			this.dateTimePickerCusBirthdate.CalendarForeColor = System.Drawing.Color.Red;
			this.dateTimePickerCusBirthdate.CalendarMonthBackground = System.Drawing.Color.Red;
			this.dateTimePickerCusBirthdate.CalendarTitleBackColor = System.Drawing.Color.Red;
			this.dateTimePickerCusBirthdate.CalendarTitleForeColor = System.Drawing.Color.Red;
			this.dateTimePickerCusBirthdate.CalendarTrailingForeColor = System.Drawing.Color.Red;
			this.dateTimePickerCusBirthdate.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerCusBirthdate.Location = new System.Drawing.Point(33, 263);
			this.dateTimePickerCusBirthdate.Name = "dateTimePickerCusBirthdate";
			this.dateTimePickerCusBirthdate.Size = new System.Drawing.Size(288, 37);
			this.dateTimePickerCusBirthdate.TabIndex = 24;
			// 
			// ManageCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1094, 773);
			this.Controls.Add(this.dateTimePickerCusBirthdate);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.buttonCusDelete);
			this.Controls.Add(this.buttonCusEdit);
			this.Controls.Add(this.buttonCusAdd);
			this.Controls.Add(this.textBoxCusPhone);
			this.Controls.Add(this.textBoxCusSurname);
			this.Controls.Add(this.textBoxCusName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageCustomers";
			this.Load += new System.EventHandler(this.ManageCustomers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxcusExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewCustomers;
		private System.Windows.Forms.Button buttonCusDelete;
		private System.Windows.Forms.Button buttonCusEdit;
		private System.Windows.Forms.Button buttonCusAdd;
		private System.Windows.Forms.TextBox textBoxCusSurname;
		private System.Windows.Forms.TextBox textBoxCusName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxCusPhone;
		private System.Windows.Forms.DateTimePicker dateTimePickerCusBirthdate;
		private System.Windows.Forms.PictureBox pictureBoxcusExit;
	}
}