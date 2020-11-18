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

namespace Admin
{
    public partial class admenuPage : Form
    {
        private string connection = "Data Source=HTT-JADG8C5\\SQLEXPRESS;Initial Catalog=DB_DATA;Integrated Security=True";
        private SqlConnection con;
        public admenuPage()
        {
            InitializeComponent();
            
            printData("Select * From menu_tb");
            filter_combo.SelectedIndex = 2;
        }
        private bool imgColumn = true;
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

            dataGridView1.Columns[0].HeaderText = "Item";
            dataGridView1.Columns[1].HeaderText = "Price";
            dataGridView1.Columns[2].HeaderText = "Category";
            dataGridView1.Columns[3].HeaderText = "Sold";
            dataGridView1.Columns[4].HeaderText = "Photo";

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
                dataGridView1[0, i - 1].Value =i;
            }

            con.Close();
            this.dataGridView1.Columns[0].Width = 40;
            this.dataGridView1.Columns[1].Width = 180;

            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol.HeaderText = "Photo";
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(dgvimgcol);
            dataGridView1.BackgroundColor = Color.White;
            addPicture();
            imgColumn = false;


            
        }
        private string selectedItem;
        private int rowIndex;

        private void addPicture()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value.ToString() != "")
                {
                    byte[] images = (byte[])row.Cells[5].Value;

                    MemoryStream mstream = new MemoryStream(images);
                    Image img = Image.FromStream(mstream);
                    this.dataGridView1.Columns[5].Visible = false;

                    ((DataGridViewImageCell)row.Cells[6]).Value = img;

                    row.Height = 80;
                }


            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {             
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    rowIndex = e.RowIndex;
                    this.editDelete.Show(this.dataGridView1, e.Location);
                    editDelete.Show(Cursor.Position);
                    selectedItem = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

            }
        }
        private void filter_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter_combo.SelectedIndex == 0)
            {
                printData("Select * From menu_tb WHERE kategori = 'Food'");
            }
            else if (filter_combo.SelectedIndex == 1)
            {
                printData("Select * From menu_tb WHERE kategori = 'Drink'");
            }
            else if (filter_combo.SelectedIndex == 3)
            {
                printData("Select * From menu_tb");
            }

        }

        private string categoryValue;
        private void getCategoryValue(int index)
        {
            if (category_combo.SelectedIndex == 0)
            {
                categoryValue = "Food";
            }
            else if (category_combo.SelectedIndex == 1)
            {
                categoryValue = "Drink";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "Food")
            {
                category_combo.SelectedIndex = 0;
            }
            else
            {
                category_combo.SelectedIndex = 1;
            }
            item_tBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            price_tBox.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();           
            sold_tBox.Text= dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

            //retrieve image
            images = (byte[])dataGridView1.Rows[rowIndex].Cells[5].Value; //set images to cell value
            MemoryStream mstream = new MemoryStream(images);
            foto_box.Image = Image.FromStream(mstream);


            addEdit_btn.Text = "Edit";
            clear_btn.Visible = false;
        }

        private void resetForm()
        {
            item_tBox.Text = "";
            price_tBox.Text = "";
            sold_tBox.Text = "";
            category_combo.SelectedIndex = -1;
            this.foto_box.Image = null;
        }

        private byte[] images = null;

        private void updateDatabase(string query, bool edit)
        {
            getCategoryValue(category_combo.SelectedIndex);
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@item1", item_tBox.Text);
                command.Parameters.AddWithValue("@price", int.Parse(price_tBox.Text));
                command.Parameters.AddWithValue("@category", categoryValue);
                command.Parameters.AddWithValue("@sold", int.Parse(sold_tBox.Text));
                command.Parameters.AddWithValue("@foto",images);
                if (edit == true)
                {
                    command.Parameters.AddWithValue("@item0", selectedItem);
                }
                command.ExecuteNonQuery();
            }
            con.Close();

        }

        private void addEdit_btn_Click(object sender, EventArgs e)
        {
            validateForm();
            if (validate == true)
            {
                if (addEdit_btn.Text == "Edit")
                {
                    if (MessageBox.Show("Are you sure?", "Edit Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //edit                    
                        string query = "UPDATE menu_tb SET item =@item1, harga= @price, kategori= @category, sold= @sold, foto=@foto WHERE item = @item0;";
                        updateDatabase(query, true);

                        resetForm();
                        clear_btn.Visible = true;
                        addEdit_btn.Text = "Add";
                        printData("Select * From menu_tb");
                        MessageBox.Show("Item berhasil di-edit.", "Edit Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (addEdit_btn.Text == "Add")
                {
                    if (MessageBox.Show("Are you sure?", "Add Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //add
                        string query = "INSERT INTO menu_tb (item,harga,kategori,sold,foto) VALUES (@item1, @price,@category,@sold,@foto)";
                        updateDatabase(query, false);

                        resetForm();
                        printData("Select * From menu_tb");
                        MessageBox.Show("Item berhasil ditambahkan.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }         
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //delete
                con.Open();
                using (SqlCommand command = new SqlCommand("Delete FROM menu_tb WHERE item =@item0", con))
                {
                    command.Parameters.AddWithValue("@item0", selectedItem);
                    command.ExecuteNonQuery();
                }
                con.Close();

                printData("Select * From menu_tb");
                MessageBox.Show("Item berhasil dihapus.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool validate = false;
        private void validateForm()
        {
            if(item_tBox.Text == "")
            {
                MessageBox.Show("Kolom Item Name masih kosong", "Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (price_tBox.Text == "")
                {
                    MessageBox.Show("Kolom Price masih kosong", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(category_combo.SelectedIndex==0 || category_combo.SelectedIndex == 1)
                    {
                        if (sold_tBox.Text == "")
                        {
                            MessageBox.Show("Kolom Sold masih kosong", "Sold", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (this.foto_box.Image != null)
                            {
                                validate = true;
                            }
                            else
                            {
                                MessageBox.Show("Pilih Foto terlebih dahulu", "Photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pilih Category terlebih dahulu", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void browse_btn_Click(object sender, EventArgs e)
        {
            using(var OpenFileDialog = new OpenFileDialog())
            {
                OpenFileDialog.Title = "Choose Image";
                OpenFileDialog.Filter = "All Files (*.*)|*.*";
                OpenFileDialog.CheckPathExists = true;
                OpenFileDialog.CheckFileExists = true;
                OpenFileDialog.Multiselect = false;
                OpenFileDialog.FileName = "";
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.foto_box.Load(OpenFileDialog.FileName);
                        this.foto_box.Tag = OpenFileDialog.FileName;

                        //addphoto
                        FileStream stream = new FileStream(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(stream);
                        images = br.ReadBytes((int)stream.Length);

                    }
                    catch
                    {
                        MessageBox.Show("Mohon memilih file berjenis gambar.", "Browse File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void price_tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate number only
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sold_tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate number only
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                item_tBox.Text = "";
                price_tBox.Text = "";
                category_combo.SelectedIndex = -1;
                sold_tBox.Text = "";
                this.foto_box.Image = null;
            }           
        }

        
    }
}
