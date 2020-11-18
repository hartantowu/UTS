namespace UTS_BUSINESS_APPLICATION_PROGRAMMING
{
    partial class cslogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cslogin));
            this.label1 = new System.Windows.Forms.Label();
            this.nomor_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nama_tbox = new System.Windows.Forms.TextBox();
            this.nomor = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nomor_tbox
            // 
            this.nomor_tbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.nomor_tbox, "nomor_tbox");
            this.nomor_tbox.ForeColor = System.Drawing.Color.Silver;
            this.nomor_tbox.Name = "nomor_tbox";
            this.nomor_tbox.Enter += new System.EventHandler(this.nomor_tbox_Enter);
            this.nomor_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomor_tbox_KeyPress);
            this.nomor_tbox.Leave += new System.EventHandler(this.nomor_tbox_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // nama_tbox
            // 
            this.nama_tbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.nama_tbox, "nama_tbox");
            this.nama_tbox.ForeColor = System.Drawing.Color.Silver;
            this.nama_tbox.Name = "nama_tbox";
            this.nama_tbox.Enter += new System.EventHandler(this.nama_tbox_Enter);
            this.nama_tbox.Leave += new System.EventHandler(this.nama_tbox_Leave);
            // 
            // nomor
            // 
            resources.ApplyResources(this.nomor, "nomor");
            this.nomor.Name = "nomor";
            // 
            // login_btn
            // 
            resources.ApplyResources(this.login_btn, "login_btn");
            this.login_btn.Name = "login_btn";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.nomor);
            this.groupBox1.Controls.Add(this.nama_tbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nomor_tbox);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cslogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "cslogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomor_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama_tbox;
        private System.Windows.Forms.Label nomor;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

