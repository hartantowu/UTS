namespace Admin
{
    partial class admenu
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
            this.adminLoginBox = new System.Windows.Forms.GroupBox();
            this.passwordSalah = new System.Windows.Forms.Label();
            this.usernameSalah = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminMenuBox = new System.Windows.Forms.GroupBox();
            this.menu_btn = new System.Windows.Forms.Button();
            this.penjualan_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.adminLoginBox.SuspendLayout();
            this.adminMenuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLoginBox
            // 
            this.adminLoginBox.Controls.Add(this.passwordSalah);
            this.adminLoginBox.Controls.Add(this.usernameSalah);
            this.adminLoginBox.Controls.Add(this.login_btn);
            this.adminLoginBox.Controls.Add(this.label3);
            this.adminLoginBox.Controls.Add(this.passInput);
            this.adminLoginBox.Controls.Add(this.label2);
            this.adminLoginBox.Controls.Add(this.userInput);
            this.adminLoginBox.Controls.Add(this.label1);
            this.adminLoginBox.Location = new System.Drawing.Point(12, 12);
            this.adminLoginBox.Name = "adminLoginBox";
            this.adminLoginBox.Size = new System.Drawing.Size(286, 270);
            this.adminLoginBox.TabIndex = 0;
            this.adminLoginBox.TabStop = false;
            // 
            // passwordSalah
            // 
            this.passwordSalah.AutoSize = true;
            this.passwordSalah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSalah.ForeColor = System.Drawing.Color.Red;
            this.passwordSalah.Location = new System.Drawing.Point(85, 183);
            this.passwordSalah.Name = "passwordSalah";
            this.passwordSalah.Size = new System.Drawing.Size(81, 13);
            this.passwordSalah.TabIndex = 7;
            this.passwordSalah.Text = "Password salah";
            this.passwordSalah.Visible = false;
            // 
            // usernameSalah
            // 
            this.usernameSalah.AutoSize = true;
            this.usernameSalah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSalah.ForeColor = System.Drawing.Color.Red;
            this.usernameSalah.Location = new System.Drawing.Point(85, 106);
            this.usernameSalah.Name = "usernameSalah";
            this.usernameSalah.Size = new System.Drawing.Size(123, 13);
            this.usernameSalah.TabIndex = 6;
            this.usernameSalah.Text = "Username tidak terdaftar";
            this.usernameSalah.Visible = false;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(88, 219);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(110, 33);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login Page";
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(88, 157);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(110, 25);
            this.passInput.TabIndex = 3;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(88, 80);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(110, 25);
            this.userInput.TabIndex = 1;
            this.userInput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // adminMenuBox
            // 
            this.adminMenuBox.Controls.Add(this.menu_btn);
            this.adminMenuBox.Controls.Add(this.penjualan_btn);
            this.adminMenuBox.Controls.Add(this.label4);
            this.adminMenuBox.Location = new System.Drawing.Point(12, 6);
            this.adminMenuBox.Name = "adminMenuBox";
            this.adminMenuBox.Size = new System.Drawing.Size(286, 280);
            this.adminMenuBox.TabIndex = 1;
            this.adminMenuBox.TabStop = false;
            this.adminMenuBox.Visible = false;
            // 
            // menu_btn
            // 
            this.menu_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn.Location = new System.Drawing.Point(75, 167);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(137, 40);
            this.menu_btn.TabIndex = 2;
            this.menu_btn.Text = "Menu";
            this.menu_btn.UseVisualStyleBackColor = true;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // penjualan_btn
            // 
            this.penjualan_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penjualan_btn.Location = new System.Drawing.Point(75, 105);
            this.penjualan_btn.Name = "penjualan_btn";
            this.penjualan_btn.Size = new System.Drawing.Size(137, 40);
            this.penjualan_btn.TabIndex = 1;
            this.penjualan_btn.Text = "Penjualan";
            this.penjualan_btn.UseVisualStyleBackColor = true;
            this.penjualan_btn.Click += new System.EventHandler(this.penjualan_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin Menu";
            // 
            // admenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.adminMenuBox);
            this.Controls.Add(this.adminLoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "admenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Fast Food";
            this.adminLoginBox.ResumeLayout(false);
            this.adminLoginBox.PerformLayout();
            this.adminMenuBox.ResumeLayout(false);
            this.adminMenuBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox adminLoginBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordSalah;
        private System.Windows.Forms.Label usernameSalah;
        private System.Windows.Forms.GroupBox adminMenuBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button penjualan_btn;
    }
}

