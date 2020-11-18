namespace UTS_BUSINESS_APPLICATION_PROGRAMMING
{
    partial class csmenu
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelReset = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.resetBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listorder = new System.Windows.Forms.RichTextBox();
            this.order_btn = new System.Windows.Forms.Button();
            this.bill_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clearOrder_btn = new System.Windows.Forms.Button();
            this.payment_combo = new System.Windows.Forms.ComboBox();
            this.foodFavoCheck = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(763, 680);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.labelReset);
            this.tabPage2.Controls.Add(this.resetbtn);
            this.tabPage2.Controls.Add(this.resetBox);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food";
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Location = new System.Drawing.Point(201, 268);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(356, 36);
            this.labelReset.TabIndex = 4;
            this.labelReset.Text = "Terima Kasih. Pelayan akan segera datang.\r\nPassword admin untuk reset.";
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReset.Visible = false;
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(334, 343);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 30);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Visible = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // resetBox
            // 
            this.resetBox.ForeColor = System.Drawing.Color.Silver;
            this.resetBox.Location = new System.Drawing.Point(288, 311);
            this.resetBox.Name = "resetBox";
            this.resetBox.Size = new System.Drawing.Size(168, 25);
            this.resetBox.TabIndex = 2;
            this.resetBox.Text = "for admin only";
            this.resetBox.Visible = false;
            this.resetBox.Enter += new System.EventHandler(this.resetBox_Enter_1);
            this.resetBox.Leave += new System.EventHandler(this.resetBox_Leave_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drink";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Orders";
            // 
            // listorder
            // 
            this.listorder.BackColor = System.Drawing.SystemColors.Window;
            this.listorder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listorder.Location = new System.Drawing.Point(784, 35);
            this.listorder.Name = "listorder";
            this.listorder.ReadOnly = true;
            this.listorder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.listorder.Size = new System.Drawing.Size(324, 454);
            this.listorder.TabIndex = 2;
            this.listorder.TabStop = false;
            this.listorder.Text = "";
            // 
            // order_btn
            // 
            this.order_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.Location = new System.Drawing.Point(784, 509);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(324, 36);
            this.order_btn.TabIndex = 3;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // bill_btn
            // 
            this.bill_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_btn.Location = new System.Drawing.Point(963, 637);
            this.bill_btn.Name = "bill_btn";
            this.bill_btn.Size = new System.Drawing.Size(145, 37);
            this.bill_btn.TabIndex = 4;
            this.bill_btn.Text = "Request Bill";
            this.bill_btn.UseVisualStyleBackColor = true;
            this.bill_btn.Click += new System.EventHandler(this.bill_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_____________________________________________________";
            // 
            // clearOrder_btn
            // 
            this.clearOrder_btn.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearOrder_btn.Location = new System.Drawing.Point(784, 561);
            this.clearOrder_btn.Name = "clearOrder_btn";
            this.clearOrder_btn.Size = new System.Drawing.Size(324, 36);
            this.clearOrder_btn.TabIndex = 6;
            this.clearOrder_btn.Text = "Clear Order";
            this.clearOrder_btn.UseVisualStyleBackColor = true;
            this.clearOrder_btn.Click += new System.EventHandler(this.clearOrder_btn_Click);
            // 
            // payment_combo
            // 
            this.payment_combo.AutoCompleteCustomSource.AddRange(new string[] {
            "Cash",
            "Debit",
            "Credit"});
            this.payment_combo.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.ItemHeight = 16;
            this.payment_combo.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Credit"});
            this.payment_combo.Location = new System.Drawing.Point(786, 646);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(159, 24);
            this.payment_combo.TabIndex = 8;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // foodFavoCheck
            // 
            this.foodFavoCheck.AutoSize = true;
            this.foodFavoCheck.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodFavoCheck.Location = new System.Drawing.Point(601, 13);
            this.foodFavoCheck.Name = "foodFavoCheck";
            this.foodFavoCheck.Size = new System.Drawing.Size(173, 22);
            this.foodFavoCheck.TabIndex = 5;
            this.foodFavoCheck.Text = "Sort by Favourite";
            this.foodFavoCheck.UseVisualStyleBackColor = true;
            this.foodFavoCheck.CheckedChanged += new System.EventHandler(this.foodFavoCheck_CheckedChanged);
            // 
            // csmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 686);
            this.ControlBox = false;
            this.Controls.Add(this.foodFavoCheck);
            this.Controls.Add(this.payment_combo);
            this.Controls.Add(this.clearOrder_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bill_btn);
            this.Controls.Add(this.listorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "csmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Ordering System";
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox listorder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button bill_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearOrder_btn;
        private System.Windows.Forms.ComboBox payment_combo;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.TextBox resetBox;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.CheckBox foodFavoCheck;
    }
}