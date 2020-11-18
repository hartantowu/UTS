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
    public partial class adpenjualanReceipt : Form
    {
        public adpenjualanReceipt(string noMeja, string namaPelanggan,string orderList, string tipeBayar, string bayar, string tanggal)
        {
            InitializeComponent();
            buildPriceDict();
            printReceipt(noMeja, namaPelanggan, orderList, tipeBayar, bayar, tanggal);

            this.Text = "Receipt : " + namaPelanggan;

        }
        private string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
        private SqlConnection con;

        private Dictionary<string, string> price = new Dictionary<string, string>();

        private string noMeja, namaPelanggan, orderList, tipeBayar, bayar, tanggal;

        private void buildPriceDict()
        {
            con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From menu_tb", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (!price.ContainsKey(row[0].ToString()))
                {
                    price.Add(row[0].ToString(), row[1].ToString());
                }
            }
            con.Close();
        }

        private void printReceipt(string noMeja, string namaPelanggan, string orderList, string tipeBayar, string bayar, string tanggal)
        {
            try
            {
                listorder.Text = string.Format("\n {0,19} \n", "Fast Food");
                listorder.Text += string.Format("\n------------------------------\n");
                listorder.Text += string.Format("No. Meja : {0}\n", noMeja);
                listorder.Text += string.Format("Nama Pelanggan : {0}\n", namaPelanggan);
                listorder.Text += string.Format("Tanggal : {0}\n", tanggal);
                listorder.Text += string.Format("Jenis Pembayaran : {0}", tipeBayar);
                listorder.Text += string.Format("\n------------------------------\n\n");
                listorder.Text += string.Format("{0} \t\t {1,5} \t {2}", "Item", "Qty.", "Price\n");
                int ordercountTemp = 0;


                string[] order = orderList.Split(new string[] { "," }, StringSplitOptions.None);
                int lastIndex = order.Length - 2;


                string query = "SELECT * FROM order_tb WHERE orderID BETWEEN '" + order[0] + "'AND'" + order[lastIndex] + "'ORDER BY orderID ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    listorder.Text += string.Format("\nOrder #{0}\n", ordercountTemp += 1);

                    string itemlist = row[1].ToString();
                    string qtylist = row[2].ToString();

                    string[] item = itemlist.Split(new string[] { "," }, StringSplitOptions.None);
                    string[] qty = qtylist.Split(new string[] { "," }, StringSplitOptions.None);

                    for (int r = 0; r < item.Count(); r++)
                    {
                        if (item[r] != "")
                        {
                            int sum = int.Parse(qty[r]) * int.Parse(price[item[r]]);
                            listorder.Text += item[r].PadRight(16, ' ') + qty[r].PadLeft(3, ' ') + sum.ToString().PadLeft(11, ' ') + Environment.NewLine;
                        }

                    }
                }


                listorder.Text += string.Format("\n------------------------------\n");

                //designing
                if (bayar.ToString().Count() == 6)
                {
                    listorder.Text += string.Format("Total Amount {0,11}{1}", "Rp. ", bayar);
                }
                else if (bayar.ToString().Count() == 5)
                {
                    listorder.Text += string.Format("Total Amount {0,12}{1}", "Rp. ", bayar);
                }
                else if (bayar.ToString().Count() == 4)
                {
                    listorder.Text += string.Format("Total Amount {0,13}{1}", "Rp. ", bayar);
                }
                else if (bayar.ToString().Count() == 7)
                {
                    listorder.Text += string.Format("Total Amount {0,10}{1}", "Rp. ", bayar);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
