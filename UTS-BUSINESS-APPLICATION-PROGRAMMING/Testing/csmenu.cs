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
    public partial class csmenu : Form
    {
        private Dictionary<string, string> price = new Dictionary<string, string>();
        public csmenu()
        {
            InitializeComponent();
            string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    MessageBox.Show("done");
            //}

            listorder.Text = string.Format("\n {0,19} \n {1,26} \n\n", "Fast Food", "------------------------");
            listorder.Text += string.Format("{0} \t\t {1,5} \t {2}\n\n", "Item", "Qty.", "Price");

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From menu_tb", connection);
            adapter.Fill(dt);

            
            foreach (DataRow row in dt.Rows)
            {
                //foreach (var item in row.ItemArray)
                //{

                //    MessageBox.Show(item.ToString());
                //}
                //MessageBox.Show(row.ToString());

                menubuilder(row[0].ToString(), row[1].ToString());
                price.Add(row[0].ToString(), row[1].ToString());

            }

            //foreach (KeyValuePair<string,string> kvp in price)
            //{
            //    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    MessageBox.Show(string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value));
                    
            //}

        }


        private int pointX = 35;
        private int pointY = 50;
        private int h_count = 3;

        private void menubuilder(string item, string harga)
        {
            Font gotham = new Font("Gotham", 12, FontStyle.Bold);
            
            //Item
            Label lblitem = new Label();

            lblitem.Font = gotham;
            lblitem.BackColor = Color.White;
            lblitem.AutoSize = true;

            lblitem.Name = "lbl_" + item;
            lblitem.Text = item;
            lblitem.Location = new Point(pointX, pointY);
            pointX += 100;
            this.Controls.Add(lblitem);
            pointX -= 100;
            lblitem.BringToFront();


            //Harga
            Label lblharga = new Label();

            lblharga.Font = gotham;
            lblharga.BackColor = Color.White;
            lblharga.AutoSize = true;

            lblharga.Name = "lbl_" + harga;
            lblharga.Text = "Rp. "+harga;
            lblharga.Location = new Point(pointX, pointY + 30);
            pointX += 130;
            this.Controls.Add(lblharga);
            lblharga.BringToFront();


            //Combo Box
            ComboBox combo = new ComboBox();

            combo.Font = new Font("Gotham", 8, FontStyle.Bold);
            combo.Height = 24;
            combo.Width = 72;
            combo.MaxDropDownItems = 10;

            combo.Name = item;
            combo.Text = "Quantity";
            combo.Location = new Point(pointX, pointY + 26);
            pointX += 80;
            //add list
            for (int i = 0; i <= 10; i++)
            {
                combo.Items.Add(i);
            }
            this.Controls.Add(combo);
            combo.BringToFront();

            combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);

            //enter
            h_count = h_count + 1;
            if (h_count % 3 == 0)
            {
                pointY += 80;
                pointX = 35;
            }
            else
            {
                pointX += 50;
            }


            //Button
            //Button btn = new Button();

            //btn.Font = new Font("Gotham", 10, FontStyle.Bold);
            //btn.BackColor = Color.Chartreuse;
            //btn.AutoSize = true;
            //btn.Height = 24;
            //btn.Width = 50;

            //btn.Name = item;
            //btn.Text = "Add";
            //btn.Location = new Point(pointX, pointY + 26);
            //pointX += 130;
            //this.Controls.Add(btn);
            //btn.BringToFront();
        }

        private Dictionary<string, string> order = new Dictionary<string, string>();
        

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            int qty = combo.SelectedIndex;
            string name = combo.Name;
            
            if (qty == 0)
            {
                if(order.ContainsKey(name))
                {
                    order.Remove(name);
                }
            }
           else if (order.ContainsKey(name))
            {
                order[name] = qty.ToString();
            }
            else
            {
                order.Add(name, qty.ToString());

            }

            try
            {
                

                int ordercount = 1;

                listorder.Text = string.Format("\n {0,19} \n {1,26} \n\n", "Fast Food", "------------------------");
                listorder.Text += string.Format("{0} \t\t {1,5} \t {2}\n\n", "Item", "Qty.", "Price");
                listorder.Text += string.Format("Order #{0}\n", ordercount);

                int totalpayment = 0;

                foreach (KeyValuePair<string, string> o in order)
                {
                    int sum = int.Parse(order[o.Key]) * int.Parse(price[o.Key]);
                    totalpayment += sum;
                    listorder.Text += o.Key.PadRight(16, ' ') + o.Value.PadLeft(3, ' ') + sum.ToString().PadLeft(11, ' ') + Environment.NewLine;
                }
                listorder.Text += string.Format("\n------------------------------\n");

                int space = 0;
                if (totalpayment.ToString().Count() == 6)
                {
                    listorder.Text += string.Format("Total Amount {0,11}{1}", "Rp. ", totalpayment);
                }
                else if (totalpayment.ToString().Count() == 5)
                {
                    listorder.Text += string.Format("Total Amount {0,12}{1}", "Rp. ", totalpayment);
                }
                else if (totalpayment.ToString().Count() == 4)
                {
                    listorder.Text += string.Format("Total Amount {0,13}{1}", "Rp. ", totalpayment);
                }
                else if (totalpayment.ToString().Count() == 7)
                {
                    listorder.Text += string.Format("Total Amount {0,10}{1}", "Rp. ", totalpayment);
                }

                

            }
            catch
            {

            }

        }
    }
}
