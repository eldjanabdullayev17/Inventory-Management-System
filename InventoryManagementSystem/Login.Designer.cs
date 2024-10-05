namespace InventoryManagementSystem
{
	partial class loginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textboxPassword = new System.Windows.Forms.TextBox();
			this.tboxUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.buttonLogin);
			this.panel1.Controls.Add(this.textboxPassword);
			this.panel1.Controls.Add(this.tboxUserName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(115, 92);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(433, 513);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(124, 84);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(175, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(77, 420);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 31);
			this.label3.TabIndex = 6;
			this.label3.Text = "Clear";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(201, 421);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(180, 32);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Show Password";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.White;
			this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.Color.Black;
			this.buttonLogin.Location = new System.Drawing.Point(69, 337);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(300, 63);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "LOGIN";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textboxPassword
			// 
			this.textboxPassword.BackColor = System.Drawing.SystemColors.InfoText;
			this.textboxPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxPassword.ForeColor = System.Drawing.Color.White;
			this.textboxPassword.Location = new System.Drawing.Point(69, 264);
			this.textboxPassword.Multiline = true;
			this.textboxPassword.Name = "textboxPassword";
			this.textboxPassword.PasswordChar = '*';
			this.textboxPassword.Size = new System.Drawing.Size(300, 49);
			this.textboxPassword.TabIndex = 2;
			this.textboxPassword.Text = "Password";
			this.textboxPassword.WordWrap = false;
			this.textboxPassword.Enter += new System.EventHandler(this.textboxPassword_Enter);
			this.textboxPassword.Leave += new System.EventHandler(this.textboxPassword_Leave);
			// 
			// tboxUserName
			// 
			this.tboxUserName.BackColor = System.Drawing.SystemColors.InfoText;
			this.tboxUserName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tboxUserName.ForeColor = System.Drawing.Color.White;
			this.tboxUserName.Location = new System.Drawing.Point(69, 188);
			this.tboxUserName.Multiline = true;
			this.tboxUserName.Name = "tboxUserName";
			this.tboxUserName.Size = new System.Drawing.Size(300, 49);
			this.tboxUserName.TabIndex = 1;
			this.tboxUserName.Text = "UserName";
			this.tboxUserName.Enter += new System.EventHandler(this.tboxUserName_Enter);
			this.tboxUserName.Leave += new System.EventHandler(this.tboxUserName_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(158, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(15, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(615, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(684, 668);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "loginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.loginForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tboxUserName;
		private System.Windows.Forms.TextBox textboxPassword;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

