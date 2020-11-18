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

namespace Admin
{
    public partial class admenu : Form
    {
        admenuPage menuPage;
        adpenjualan penjualanPage;
        public admenu()
        {
            InitializeComponent();
            //adminLoginBox.Visible = false;
            //adminMenu();
        }

        private string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
        private SqlConnection con;

        private void login_btn_Click(object sender, EventArgs e)
        {
            usernameSalah.Visible = false;
            passwordSalah.Visible = false;
            string username = userInput.Text;
            string password = passInput.Text;

            con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM admin_tb WHERE username='"+username+"'", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == password)
                    {
                        adminLoginBox.Visible = false;
                        adminMenu();
                    }
                    else
                    {
                        passwordSalah.Visible = true;
                    }
                }
            }
            else
            {
                usernameSalah.Visible = true;
            }
            con.Close();

            
        }
        private void adminMenu()
        {
            adminMenuBox.Visible = true;
        }
        

        private void menu_btn_Click(object sender, EventArgs e)
        {
            if (menuPage == null)
            {
                menuPage = new admenuPage();   //Create form if not created
                menuPage.FormClosed += menuPage_FormClosed;  //Add eventhandler to cleanup after form closes
                InitializeComponent();
                menuPage.Show(this);  //Show Form assigning this form as the forms owner
            }
        }
        void menuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPage = null;
            Show();
        }

        private void penjualan_btn_Click(object sender, EventArgs e)
        {
            if (penjualanPage == null)
            {
                penjualanPage = new adpenjualan();   //Create form if not created
                penjualanPage.FormClosed += penjualanPage_FormClosed;  //Add eventhandler to cleanup after form closes
                InitializeComponent();
                penjualanPage.Show(this);  //Show Form assigning this form as the forms owner
            }
        }

        void penjualanPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            penjualanPage = null;
            Show();
        }
    }
}
