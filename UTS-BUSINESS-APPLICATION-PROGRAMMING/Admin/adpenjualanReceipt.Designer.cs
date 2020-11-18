namespace Admin
{
    partial class adpenjualanReceipt
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
            this.listorder = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listorder
            // 
            this.listorder.BackColor = System.Drawing.SystemColors.Window;
            this.listorder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listorder.Location = new System.Drawing.Point(12, 12);
            this.listorder.Name = "listorder";
            this.listorder.ReadOnly = true;
            this.listorder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.listorder.Size = new System.Drawing.Size(324, 626);
            this.listorder.TabIndex = 3;
            this.listorder.TabStop = false;
            this.listorder.Text = "";
            // 
            // adpenjualanReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 650);
            this.Controls.Add(this.listorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adpenjualanReceipt";
            this.Text = "Receipt : ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox listorder;
    }
}