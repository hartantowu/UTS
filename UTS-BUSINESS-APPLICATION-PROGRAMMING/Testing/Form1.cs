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

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From menu_tb", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ItemList");
            dataGridView1.DataSource = ds.Tables["ItemList"].DefaultView;
            con.Close();
        }
        
    }
}