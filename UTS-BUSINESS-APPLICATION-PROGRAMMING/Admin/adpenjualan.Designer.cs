namespace Admin
{
    partial class adpenjualan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dari_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sampai_Date = new System.Windows.Forms.DateTimePicker();
            this.filter_combo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.penjualan_lbl = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(679, 262);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Penjualan";
            // 
            // dari_Date
            // 
            this.dari_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dari_Date.Location = new System.Drawing.Point(24, 107);
            this.dari_Date.Name = "dari_Date";
            this.dari_Date.Size = new System.Drawing.Size(93, 20);
            this.dari_Date.TabIndex = 21;
            this.dari_Date.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            this.dari_Date.ValueChanged += new System.EventHandler(this.dari_Date_ValueChanged);
            this.dari_Date.Enter += new System.EventHandler(this.dari_Date_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sampai";
            // 
            // sampai_Date
            // 
            this.sampai_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sampai_Date.Location = new System.Drawing.Point(138, 107);
            this.sampai_Date.Name = "sampai_Date";
            this.sampai_Date.Size = new System.Drawing.Size(93, 20);
            this.sampai_Date.TabIndex = 24;
            this.sampai_Date.Value = new System.DateTime(2020, 11, 18, 0, 0, 0, 0);
            this.sampai_Date.ValueChanged += new System.EventHandler(this.sampai_Date_ValueChanged);
            this.sampai_Date.Enter += new System.EventHandler(this.sampai_Date_Enter);
            // 
            // filter_combo
            // 
            this.filter_combo.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_combo.FormattingEnabled = true;
            this.filter_combo.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Credit",
            "All"});
            this.filter_combo.Location = new System.Drawing.Point(25, 212);
            this.filter_combo.Name = "filter_combo";
            this.filter_combo.Size = new System.Drawing.Size(113, 26);
            this.filter_combo.TabIndex = 27;
            this.filter_combo.SelectedIndexChanged += new System.EventHandler(this.filter_combo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 36);
            this.label11.TabIndex = 26;
            this.label11.Text = "Filter Data by\r\nJenis Pembayaran";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "_________________________________";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 80);
            this.label4.TabIndex = 29;
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(205, 194);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(93, 49);
            this.print_btn.TabIndex = 30;
            this.print_btn.Text = "Export Excel";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // penjualan_lbl
            // 
            this.penjualan_lbl.AutoSize = true;
            this.penjualan_lbl.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penjualan_lbl.Location = new System.Drawing.Point(204, 167);
            this.penjualan_lbl.Name = "penjualan_lbl";
            this.penjualan_lbl.Size = new System.Drawing.Size(91, 18);
            this.penjualan_lbl.TabIndex = 31;
            this.penjualan_lbl.Text = "Records : ";
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(251, 84);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(93, 44);
            this.show_btn.TabIndex = 32;
            this.show_btn.Text = "Show\r\nAll";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // adpenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 311);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.penjualan_lbl);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filter_combo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sampai_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dari_Date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adpenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Fast Food : Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dari_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sampai_Date;
        private System.Windows.Forms.ComboBox filter_combo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label penjualan_lbl;
        private System.Windows.Forms.Button show_btn;
    }
}