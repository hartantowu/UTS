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
using System.IO;

namespace UTS_BUSINESS_APPLICATION_PROGRAMMING
{
    public partial class csmenu : Form
    {
        private int noMeja;
        private string namaPelanggan;
        public csmenu(int nomormeja, string namacs)
        {
            InitializeComponent();
            getLastOrderID();
            noMeja = nomormeja;
            namaPelanggan = namacs;
            lastID = orderID;
            buildmenu(0, favo);
            


            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    MessageBox.Show("done");
            //}

            //foreach (KeyValuePair<string, string> kvp in price)
            //{
            //    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    MessageBox.Show(string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value));

            //}
        }


        private string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
        private SqlConnection con;

        private Dictionary<string, string> price = new Dictionary<string, string>();
        private Dictionary<string, string> order = new Dictionary<string, string>();
        private string orderList;
        private string paymentType = "";

        private int pointX1;
        private int pointY1;
        private int pointX2;
        private int pointY2;

        private int h_count1;
        private int h_count2;

        private int ordercount = 0;
        private int lastID;
        private int orderID;
        private int totalpayment = 0;
        private int paymentType0 = 9;

        private bool bill = false;
        private bool favo = false;

        private void getLastOrderID()
        {
            con = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 * FROM order_tb ORDER BY orderID DESC", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                orderID = int.Parse(row[0].ToString());
            }

            if (dt.Rows.Count == 0)
            {
                orderID = 1;
            }

            if (lastID != orderID)
            {
                orderList += (orderID + 1).ToString() + ",";
            }
        }

        private void buildmenu(int pageIndex, bool favo)
        {
            listorder.Text = string.Format("\n {0,19} \n", "Fast Food");
            listorder.Text += string.Format("\n------------------------------\n");
            listorder.Text += string.Format("No. Meja : {0}\n", noMeja);
            listorder.Text += string.Format("Nama Pelanggan : {0}\n", namaPelanggan);
            listorder.Text += string.Format("Tanggal : {0}", DateTime.Now);
            listorder.Text += string.Format("\n------------------------------\n\n");
            listorder.Text += string.Format("{0} \t\t {1,5} \t {2}", "Item", "Qty.", "Price\n");

            h_count1 = 0;
            pointX1 = 15;
            pointY1 = 20;

            h_count2 = 0;
            pointX2 = 15;
            pointY2 = 20;

            tabControl.SelectedIndex = pageIndex;
            payment_combo.Text = "Payment Type";

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

            if (favo == true)
            {
                SqlDataAdapter adapterSold = new SqlDataAdapter("Select * From menu_tb ORDER BY sold DESC", connection);
                DataTable dtSold = new DataTable();
                adapterSold.Fill(dtSold);

                foreach (DataRow row in dtSold.Rows)
                {
                    menubuilder(row[0].ToString(), row[1].ToString(), row[2].ToString(), (byte[])row[4]);
                }
            }
            else if (favo == false)
            {
                foreach (DataRow row in dt.Rows)
                {
                    menubuilder(row[0].ToString(), row[1].ToString(), row[2].ToString(), (byte[])row[4]);
                }
            }           
        }

        private void foodFavoCheck_CheckedChanged(object sender, EventArgs e)
        {
            int pageIndex = tabControl.SelectedIndex;
            favo = !favo;            
            this.tabControl.TabPages.Clear();
            
            TabPage tabPage1 = new TabPage("Food");
            TabPage tabPage2 = new TabPage("Drink");
            tabPage1.BackColor = Color.White;
            tabPage2.BackColor = Color.White;
            this.tabControl.TabPages.AddRange(new TabPage[] {
            tabPage1, tabPage2});
            buildmenu(pageIndex, favo);
            printReceipt();
        }


        private void menubuilder(string item, string harga, string kategori, byte[] foto)
        {
            Font gotham = new Font("Gotham", 12, FontStyle.Bold);

            PictureBox fotobox = new PictureBox();
            byte[] images = foto;
            MemoryStream mstream = new MemoryStream(images);
            fotobox.Image = Image.FromStream(mstream);
            fotobox.Width = 100;
            fotobox.Height = 100;
            fotobox.SizeMode = PictureBoxSizeMode.StretchImage;


            if (kategori == "Food")
            {
                fotobox.Location = new Point(pointX1, pointY1 - 20);
                tabControl.TabPages[0].Controls.Add(fotobox);
            }
            else if (kategori == "Drink")
            {
                fotobox.Location = new Point(pointX2, pointY2 - 20);
                tabControl.TabPages[1].Controls.Add(fotobox);
            }
            fotobox.BringToFront();


            //Item
            Label lblitem = new Label();
            lblitem.Font = gotham;
            lblitem.BackColor = Color.White;
            lblitem.AutoSize = true;
            lblitem.Text = item;

            //position
            if (kategori == "Food")
            {
                lblitem.Location = new Point(pointX1, pointY1 + 80);
                tabControl.TabPages[0].Controls.Add(lblitem);
            }
            else if (kategori == "Drink")
            {
                lblitem.Location = new Point(pointX2, pointY2 + 80);
                tabControl.TabPages[1].Controls.Add(lblitem);
            }
           
            lblitem.BringToFront();


            //Harga
            Label lblharga = new Label();
            lblharga.Font = gotham;
            lblharga.BackColor = Color.White;
            lblharga.AutoSize = true;
            lblharga.Text = "Rp. " + harga;

            //position
            if (kategori == "Food")
            {
                lblharga.Location = new Point(pointX1, pointY1 + 110);
                pointX1 += 120;
                tabControl.TabPages[0].Controls.Add(lblharga);
            }
            else if (kategori == "Drink")
            {
                lblharga.Location = new Point(pointX2, pointY2 + 110);
                pointX2 += 120;
                tabControl.TabPages[1].Controls.Add(lblharga);
            }         
            lblharga.BringToFront();
            

            //Combo Box
            ComboBox combo = new ComboBox();
            combo.Font = new Font("Gotham", 8, FontStyle.Bold);
            combo.Height = 24;
            combo.Width = 72;
            combo.MaxDropDownItems = 10;
            combo.Name = item;
            combo.Text = "Quantity";
            
            //add list to combo
            for (int i = 0; i <= 10; i++)
            {
                combo.Items.Add(i);
            }

            //position
            if (kategori == "Food")
            {
                combo.Location = new Point(pointX1, pointY1 + 106);
                pointX1 += 120;
                tabControl.TabPages[0].Controls.Add(combo);               
                h_count1 += 1;               
            }
            else if (kategori == "Drink")
            {
                combo.Location = new Point(pointX2, pointY2 + 106);
                pointX2 += 120;
                tabControl.TabPages[1].Controls.Add(combo);
                h_count2 += 1;              
            }                      
            combo.BringToFront();
            combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
            

            ////////////////////////////////////////////
            //enter position          
            if (h_count1 % 3 == 0 && h_count1 != 0)
            {
                pointY1 += 160;
                pointX1 = 15;
                h_count1 = 0;
            }

            if (h_count2 % 3 == 0 && h_count2 != 0)
            {
                pointY2 += 160;
                pointX2 = 15;
                h_count2 = 0;
            }

            //MessageBox.Show(h_count.ToString() + "-" + h_count1.ToString());
            //MessageBox.Show("Final" + pointX.ToString() + "-" + pointX1.ToString());
            //MessageBox.Show(pointY1.ToString()+"-"+ pointY2.ToString());
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            int qty = combo.SelectedIndex;
            string name = combo.Name;
            combo.SelectedIndex = qty;

            if (qty == 0)
            {
                if (order.ContainsKey(name))
                {
                    int sum = int.Parse(order[name]) * int.Parse(price[name]);
                    totalpayment -= sum;
                    order.Remove(name);
                }
            }
            else if (order.ContainsKey(name))
            {
                int sum = int.Parse(order[name]) * int.Parse(price[name]);
                totalpayment -= sum;
                order[name] = qty.ToString();
            }
            else
            {
                order.Add(name, qty.ToString());
            }

            printReceipt();
        }

        private void printReceipt()
        {
            try
            {
                listorder.Text = string.Format("\n {0,19} \n", "Fast Food");
                listorder.Text += string.Format("\n------------------------------\n");
                listorder.Text += string.Format("No. Meja : {0}\n", noMeja);
                listorder.Text += string.Format("Nama Pelanggan : {0}\n", namaPelanggan);
                listorder.Text += string.Format("Tanggal : {0}", DateTime.Now);
                listorder.Text += string.Format("\n------------------------------\n\n");
                listorder.Text += string.Format("{0} \t\t {1,5} \t {2}", "Item", "Qty.", "Price\n");

                int ordercountTemp = 0;
                if (ordercount >= 1)
                {
                    string query = "SELECT * FROM order_tb where orderID > " + lastID.ToString() + "AND namaPelanggan ='"+namaPelanggan+"'ORDER BY orderID ASC";
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

                }

                if (bill == false)
                {
                    listorder.Text += string.Format("\nOrder #{0}\n", ordercount + 1);
                    totalpayment = 0;
                    foreach (KeyValuePair<string, string> o in order)
                    {                       
                        int sum = int.Parse(order[o.Key]) * int.Parse(price[o.Key]);
                        totalpayment += sum;
                        listorder.Text += o.Key.PadRight(16, ' ') + o.Value.PadLeft(3, ' ') + sum.ToString().PadLeft(11, ' ') + Environment.NewLine;
                    }
                }
                listorder.Text += string.Format("\n------------------------------\n");

                //designing
                if ((totalpayment + finalpayment).ToString().Count() == 6)
                {
                    listorder.Text += string.Format("Total Amount {0,11}{1}", "Rp. ", totalpayment + finalpayment);
                }
                else if ((totalpayment + finalpayment).ToString().Count() == 5)
                {
                    listorder.Text += string.Format("Total Amount {0,12}{1}", "Rp. ", totalpayment + finalpayment);
                }
                else if ((totalpayment + finalpayment).ToString().Count() == 4)
                {
                    listorder.Text += string.Format("Total Amount {0,13}{1}", "Rp. ", totalpayment + finalpayment);
                }
                else if ((totalpayment + finalpayment).ToString().Count() == 7)
                {
                    listorder.Text += string.Format("Total Amount {0,10}{1}", "Rp. ", totalpayment + finalpayment);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearOrder_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Clear Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (KeyValuePair<string, string> o in order)
                {
                    int sum = int.Parse(order[o.Key]) * int.Parse(price[o.Key]);
                    totalpayment -= sum;
                }
                resetForm();               
            }
        }
        
        private void resetForm()
        {
            order.Clear();
            price.Clear();
            favo = false;
            int pageIndex = tabControl.SelectedIndex;                      
            listorder.Text = string.Format("\n {0,19} \n {1,26} \n\n", "Fast Food", "------------------------");
            listorder.Text += string.Format("{0} \t\t {1,5} \t {2}\n\n", "Item", "Qty.", "Price");
            this.Controls.Clear();
            InitializeComponent();
            buildmenu(pageIndex,favo);
            printReceipt();
        }

        private int finalpayment;
        private void order_btn_Click(object sender, EventArgs e)
        {
            if (order.Count != 0)
            {
                ordercount += 1;
                string menulist = "";
                string qtylist = "";
                int sold = 0;

                finalpayment += totalpayment;

                foreach (KeyValuePair<string, string> kvp in order)
                {
                    //make list for queryinsert
                    menulist += kvp.Key + ",";
                    qtylist += kvp.Value + ",";

                    //update sold on menu_tb
                    string query = "SELECT * FROM menu_tb WHERE item='" + kvp.Key.ToString() + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        sold = int.Parse(row[3].ToString());
                        sold += int.Parse(kvp.Value);
                    }

                    string queryUpdateSold = "UPDATE menu_tb SET sold = '" + sold.ToString() + "'" + "WHERE item = '" + kvp.Key.ToString() + "'";
                    using (SqlCommand command = new SqlCommand(queryUpdateSold, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }

                getLastOrderID();
                string queryinsert = "INSERT INTO order_tb (orderID, orderMenu, orderQuantity, namaPelanggan) VALUES (@id, @menu, @qty, @namaPelanggan)";
                con.Open();
                using (SqlCommand command = new SqlCommand(queryinsert, con))
                {
                    command.Parameters.AddWithValue("@id", orderID + 1);
                    command.Parameters.AddWithValue("@menu", menulist);
                    command.Parameters.AddWithValue("@qty", qtylist);
                    command.Parameters.AddWithValue("@namaPelanggan", namaPelanggan);
                    
                    command.ExecuteNonQuery();
                    
                }
                con.Close();
                MessageBox.Show("Makanan anda akan segera datang. Selagi menunggu anda masih bisa menambahkan order baru.", "Order Ditambahkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetForm();
            }
            else if (order.Count == 0)
            {
                MessageBox.Show("Silahkan menambahkan makanan terlebih dahulu.","Order Kosong",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            paymentType0 = 9;
        }

        private void payment_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            paymentType0 = payment_combo.SelectedIndex;

            if (paymentType0 == 0)
            {
                paymentType = "Cash";
            }
            else if (paymentType0 == 1)
            {
                paymentType = "Debit";
            }
            else if (paymentType0 == 2)
            {
                paymentType = "Credit";
            }
        }

        private void bill_btn_Click(object sender, EventArgs e)
        {
            if (ordercount==0)
            {
                MessageBox.Show("Silahkan menambahkan order terlebih dahulu.", "Order Kosong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (order.Count == 0)
                {
                    if (paymentType0 != 9)
                    {
                        if (MessageBox.Show("Are you sure?", "Request Bill", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bill = true;
                            string queryinsert = "INSERT INTO sales_tb (noMeja,namaPelanggan,orderList,tipeBayar,bayar,tanggal) values (@noMeja,@namaPelanggan,@orderList,@tipeBayar,@bayar,@date)";
                            con.Open();
                            using (SqlCommand command = new SqlCommand(queryinsert, con))
                            {
                                command.Parameters.AddWithValue("@orderList", orderList);
                                command.Parameters.AddWithValue("@noMeja", noMeja);
                                command.Parameters.AddWithValue("@namaPelanggan", namaPelanggan);
                                command.Parameters.AddWithValue("@tipeBayar", paymentType);
                                command.Parameters.AddWithValue("@bayar", finalpayment);
                                command.Parameters.AddWithValue("@date", DateTime.Now);                               
                                command.ExecuteNonQuery();                               
                            }
                            con.Close();
                            loginAgain();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silahkan memilih jenis pembayaran terlebih dahulu.", "Jenis Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Order List anda masih mempunyai item yang belum di order, mohon melakukan Order atau Clear Order sebelum melakukan Request Bill", "Order List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }    
        }

        private void loginAgain()
        {
            this.Controls.Clear();
            InitializeComponent();
            printReceipt();

            tabControl.TabPages.RemoveByKey("tabPage3");
            tabPage2.Text = @"Receipt";

            foodFavoCheck.Visible = false;
            labelReset.Visible = true;
            resetbtn.Visible = true;
            resetBox.Visible = true;
        }

        private string resetpass;

        private void tbox_Enter(TextBox textBox, string placeholder)
        {
            resetBox.UseSystemPasswordChar = true;
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
            resetpass = resetBox.Text;
        }

        private void resetBox_Leave_1(object sender, EventArgs e)
        {
            tbox_Leave(resetBox, "for admin only");
        }

        private void resetBox_Enter_1(object sender, EventArgs e)
        {
            tbox_Enter(resetBox, "for admin only");
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM admin_tb";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == resetpass)
                {
                    Owner.Show();
                    Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Password yang anda masukkan salah.", "Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
