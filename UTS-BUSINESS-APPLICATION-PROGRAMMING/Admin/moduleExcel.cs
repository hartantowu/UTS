using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Admin
{
    class moduleExcel
    {
        public void ToCsV(DataGridView dgv,string tglDari, string tglSampai,string pembayaran, string title, string filename)
        {

            //========Data from textbox==========//        
            string Output = "";
            string Headers = "";

            string Title = title + "\r=================================================";
            string Tanggal = "\n Tanggal : " + tglDari + " - " + tglSampai +"\r";
            string Pembayaran = "\n Pembayaran : " +pembayaran+ "\r\n =================================================\n\n";


            Output += Title;
            Output += Tanggal;
            Output += Pembayaran;

            for (int j = 0; j < dgv.Columns.Count; j++)
            Headers = Headers.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
            Output += Headers + "\r\n";
               
            // Export data.  
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].Value) + "\t";
                Output += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(Output);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file  
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private Worksheet FindSheet(Workbook workbook, string sheet_name)
        {
            foreach (Worksheet sheet in workbook.Sheets)
            {
                if (sheet.Name == sheet_name) return sheet;
            }
            return null;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
