using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_BUSINESS_APPLICATION_PROGRAMMING
{
    public partial class cslogin : Form
    {
        csmenu menuform;
        public cslogin()
        {
            InitializeComponent();
        }

        private void tbox_Enter(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.ForeColor = Color.FromName("black");
                textBox.Text = "";
            }
        }

        private void tbox_Leave(TextBox textBox, string placeholder)
        {
            if (textBox.Text == "" || String.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.FromName("silver");
                textBox.Text = placeholder;
            }
            else if (textBox.Text == placeholder)
            {
                textBox.ForeColor = Color.FromName("silver");
            }
        }

        private void nomor_tbox_Enter(object sender, EventArgs e)
        {
            tbox_Enter(nomor_tbox, "ex: 101");
        }

        private void nomor_tbox_Leave(object sender, EventArgs e)
        {
            tbox_Leave(nomor_tbox, "ex: 101");
        }

        private void nama_tbox_Enter(object sender, EventArgs e)
        {
            tbox_Enter(nama_tbox, "your name");
        }

        private void nama_tbox_Leave(object sender, EventArgs e)
        {
            tbox_Leave(nama_tbox, "your name");
        }

        private void nomor_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate number only
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int nomormeja = int.Parse(nomor_tbox.Text);
                int pjgnomor = nomor_tbox.Text.Length;
                string namacs = nama_tbox.Text;

                if (pjgnomor != 3)
                {
                    MessageBox.Show("Maaf, Nomor Meja salah. Nomor Meja mempunyai 3 digit angka.", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (namacs == "your name")
                {
                    MessageBox.Show("Maaf, isi nama terlebih dahulu.", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pjgnomor == 3 && namacs != "your name")
                {
                    string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();

                    bool namecheck = true;
                    int namecount = 0;
                    while (namecheck == true)
                    {                      
                        string query = "Select * From sales_tb WHERE namaPelanggan ='" + namacs + "'";
                        
                        if(namecount > 0)
                        {
                            query = "Select * From sales_tb WHERE namaPelanggan ='" + namacs+namecount.ToString()+ "'";
                        }                       
                        
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                namecount += 1;
                            }
                        }
                        else if (dt.Rows.Count == 0 && namecount!=0)
                        {
                            namacs = namacs + namecount.ToString();
                            namecheck = false;
                        }
                        else
                        {
                            namecheck = false;
                        }
                    }
                    string message = "Halo " + namacs + ", kamu sudah bisa order makananmu sekarang.";
                    MessageBox.Show(message, "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    menuform = new csmenu(nomormeja, namacs);   //Create form if not created
                    menuform.FormClosed += menuform_FormClosed;  //Add eventhandler to cleanup after form closes
                    this.Controls.Clear();
                    InitializeComponent();
                    menuform.Show(this);  //Show Form assigning this form as the forms owner
                    Hide();
                 

                    //csmenu menuform = new csmenu(nomormeja, namacs);
                    //menuform.Tag = this;
                    //menuform.Show(this);
                    //Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaf, nomor meja salah.", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void menuform_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuform = null;
            Show();
        }

        
    }
}
