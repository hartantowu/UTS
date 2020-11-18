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
    public partial class adpenjualan : Form
    {
        moduleExcel excelImp = new moduleExcel();

        private string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
        private SqlConnection con;
        private bool resetDateKey = false;
        public adpenjualan()
        {
            InitializeComponent();
            printData("Select * From sales_tb ORDER BY tanggal DESC");
            filter_combo.SelectedIndex = 3;
            resetDate();
        }

        private void printData(string query)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataColumn dc in dt.Columns)
            {

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());

            }
            dataGridView1.Columns[0].HeaderText = "No. Meja";
            dataGridView1.Columns[1].HeaderText = "Nama Pelanggan";
            dataGridView1.Columns[2].HeaderText = "Order List";
            dataGridView1.Columns[3].HeaderText = "Jenis Bayar";
            dataGridView1.Columns[4].HeaderText = "Total Bayar";
            dataGridView1.Columns[5].HeaderText = "Tanggal";

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
            }


            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Name = "number";
            newColumn.HeaderText = "No.";
            dataGridView1.Columns.Insert(0, newColumn);

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                dataGridView1[0, i - 1].Value = i;
            }

            con.Close();
            this.dataGridView1.Columns[0].Width = 40;
            this.dataGridView1.Columns[1].Width = 60;
            this.dataGridView1.Columns[2].Width = 110;
            this.dataGridView1.Columns[3].Width = 140; //orderlist
            this.dataGridView1.Columns[4].Width = 80;
            this.dataGridView1.Columns[5].Width = 86;
            this.dataGridView1.Columns[6].Width = 125;

            penjualan_lbl.Text = "Records : " + dataGridView1.Rows.Count.ToString();
        }


        private void resetDate()
        {
            resetDateKey = true;
            dari_Date.CustomFormat = " ";
            dari_Date.Format = DateTimePickerFormat.Custom;
            sampai_Date.CustomFormat = " ";
            sampai_Date.Format = DateTimePickerFormat.Custom;
            printData("Select * From sales_tb ORDER BY tanggal DESC");
            resetDateKey = false;
        }

        private void dari_Date_ValueChanged(object sender, EventArgs e)
        {
            if (resetDateKey== false)
            {
                filter_combo.SelectedIndex = 3;
                printData("SELECT * FROM sales_tb WHERE tanggal BETWEEN'" + dari_Date.Value.ToString() + "' AND '" + sampai_Date.Value.ToString() + "' ORDER BY tanggal DESC");
            }
        }

        private void sampai_Date_ValueChanged(object sender, EventArgs e)
        {
            if (resetDateKey == false)
            {
                filter_combo.SelectedIndex = 3;
                printData("SELECT * FROM sales_tb WHERE tanggal BETWEEN'" + dari_Date.Value.ToString() + "' AND '" + sampai_Date.Value.ToString() + "'ORDER BY tanggal DESC");
            }
        }

        private void dari_Date_Enter(object sender, EventArgs e)
        {
            dari_Date.CustomFormat = "dd-MMM-yy";
        }

        private void sampai_Date_Enter(object sender, EventArgs e)
        {
            sampai_Date.CustomFormat = "dd-MMM-yy";
        }

        private string filter = "";
        private void filter_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (dari_Date.CustomFormat == " ")
            {
                if (filter_combo.SelectedIndex == 3)
                {
                    filter = "All Type";
                    printData("Select * From sales_tb ORDER BY tanggal DESC");
                }
                else
                {
                    if (filter_combo.SelectedIndex == 0)
                    {
                        filter = "Cash";
                    }
                    else if (filter_combo.SelectedIndex == 1)
                    {
                        filter = "Debit";
                    }
                    else if (filter_combo.SelectedIndex == 2)
                    {
                        filter = "Credit";
                    }
                    printData("SELECT * FROM sales_tb WHERE tipeBayar ='" + filter + "'ORDER BY tanggal DESC");
                }
            }
            else
            {
                if (filter_combo.SelectedIndex == 3)
                {
                    filter = "All Type";
                    printData("SELECT * FROM sales_tb WHERE tanggal BETWEEN'" + dari_Date.Value.ToString() + "' AND '" + sampai_Date.Value.ToString() + "'ORDER BY tanggal DESC");
                }
                else
                {
                    if (filter_combo.SelectedIndex == 0)
                    {
                        filter = "Cash";
                    }
                    else if (filter_combo.SelectedIndex == 1)
                    {
                        filter = "Debit";
                    }
                    else if (filter_combo.SelectedIndex == 2)
                    {
                        filter = "Credit";
                    }
                    printData("SELECT * FROM sales_tb WHERE tanggal BETWEEN'" + dari_Date.Value.ToString() + "' AND '" + sampai_Date.Value.ToString() + "' AND tipeBayar ='" + filter + "'ORDER BY tanggal DESC");

                }
            }           
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            resetDate();
            filter_combo.SelectedIndex = 3;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string noMeja = row.Cells[1].Value.ToString();
                string namaPelanggan = row.Cells[2].Value.ToString();
                string orderList = row.Cells[3].Value.ToString();
                string tipeBayar = row.Cells[4].Value.ToString();
                string bayar = row.Cells[5].Value.ToString();
                string tanggal = row.Cells[6].Value.ToString();

                adpenjualanReceipt receiptForm = new adpenjualanReceipt(noMeja,namaPelanggan,orderList,tipeBayar,bayar,tanggal);
                receiptForm.Show();
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string title = "Fast Food Penjualan";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "fastfood.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelImp.ToCsV(dataGridView1, dari_Date.Value.ToString(), sampai_Date.Value.ToString(), filter, title, sfd.FileName);
                MessageBox.Show("Data telah berhasil di-export.");
            }
        }
    }
}
