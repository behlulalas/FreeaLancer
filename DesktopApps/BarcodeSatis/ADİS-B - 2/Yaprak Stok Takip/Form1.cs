using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;
namespace Yaprak_Stok_Takip
{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti;
       

        public Form1()
        {
            InitializeComponent();
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            doldur();
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "bekitrade";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            tarih.Text = DateTime.Now.ToString("yyyy/MM/dd");
            comboBox1.Text = "E Paguar";
            /*bleresit.CharacterCasing = CharacterCasing.Upper;
            vendi.CharacterCasing = CharacterCasing.Upper;
            adressa.CharacterCasing = CharacterCasing.Upper;*/




        }
     
     
        public void Ara()
        {
            baglanti.Open();

            string sql = "Select * from beki where barcode ='" + comboBox2.Text + "' ";
            MySqlCommand command = new MySqlCommand(sql,baglanti);

            MySqlDataReader rdr = command.ExecuteReader();
            if (!rdr.Read())
            {
                
            }
            else
            {
                // Kullanıcı varsa sütunda ki verileri labellere yazdırıyoruz.
                // Tırnak içindekiler sütunda ki ismi geçen yazılardır.



                
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = rdr["barcode"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = rdr["Emri"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = rdr["njesia"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = rdr["sasia"].ToString();
                
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = rdr["qmimi"].ToString();


            }
            // Her şey tamam ise bağlantıları kapatıyoruz..
            rdr.Close();
            
            baglanti.Close();
            
        }
        public void doldur ()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "bekitrade";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT * FROM beki where emri  Like '" + comboBox2.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["emri"]);

            }

            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Ara();
            
            
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
           


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont11 = new Font("2A03", 12, FontStyle.Bold);
            Font myFont1 = new Font("Arial", 15, FontStyle.Italic);
            Font Firma = new Font("Calibri", 12);
            Font bilgiler = new Font("VCR OSD MONO", 9);
            Font bilgiler1 = new Font("2A03", 10);
            Font bilgiler11 = new Font("2A03", 12);
            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Near;
            StringFormat myStringFormat1 = new StringFormat();
            myStringFormat1.Alignment = StringAlignment.Far;
            StringFormat myStringFormat2 = new StringFormat();
            myStringFormat2.Alignment = StringAlignment.Center;


            SolidBrush sbrush = new SolidBrush(Color.Black);
            
            Pen üstcizgiler = new Pen(Color.Black,3);
            Pen sagkare = new Pen(Color.Black);
            e.Graphics.DrawString("--------------------------------", bilgiler, sbrush, 10, 5);
            e.Graphics.DrawString("\"BekiTrade\" Sh.P.K", Firma, sbrush, 35, 13);
            e.Graphics.DrawString("Zym-Dragash", bilgiler, sbrush, 85, 30,myStringFormat2);
            e.Graphics.DrawString("Mob:044 & 049 345 605", bilgiler, sbrush, 90, 60, myStringFormat2);
            
           
           
            
            
        
          
            e.Graphics.DrawString("Nr.FISKAL   :810088246", bilgiler, sbrush, 90, 95,myStringFormat2);
            e.Graphics.DrawString("Nr.BIZNISIT :810088246", bilgiler, sbrush, 90, 110,myStringFormat2);
            e.Graphics.DrawString("Nr.Tvsh     :810088246", bilgiler, sbrush, 90, 125, myStringFormat2);
           

         
            

           
            Font total = new Font("Arial", 12,FontStyle.Bold);






            int y = 250;
            int x = 222;




            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
              
              


             
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString());
                
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), bilgiler1, sbrush, 10,x+70);//Emri
          
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), bilgiler1, sbrush, 60, y+55, myStringFormat);//Sasia
                e.Graphics.DrawString(" x ", bilgiler1, sbrush, 70, y + 55, myStringFormat);//x
                e.Graphics.DrawString(fiyat.ToString(), bilgiler1, sbrush, 100, y + 55, myStringFormat);//Qmimi
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), bilgiler1, sbrush, 150, y+55, myStringFormat);//Total
                e.Graphics.DrawString(i+1+"  -------------------------------------", bilgiler1, sbrush, 0, y + 61, myStringFormat);//Total



                x += 25;
                y += 25;


            }
            string sadecesaat;
            sadecesaat = DateTime.Now.ToShortTimeString();
            DateTime data = DateTime.Now;            
            e.Graphics.DrawString(ttoplam.Text, bilgiler, sbrush, 120, y + 70, myStringFormat);
            e.Graphics.DrawString("TOTAL:", bilgiler, sbrush, 70, y + 70, myStringFormat);
            e.Graphics.DrawString("------------------------", bilgiler, sbrush, 0, y + 80);
            
            e.Graphics.DrawString("DATA:", bilgiler, sbrush, 15, y + 100);
            e.Graphics.DrawString(data.ToShortDateString()+"   "+sadecesaat, bilgiler, sbrush, 50, y+100);
            e.Graphics.DrawString("------------------------", bilgiler, sbrush, 0, y + 140);
            e.Graphics.DrawString("Ju Faleminderit.", myFont11, sbrush, 100, y + 120,myStringFormat2);
            e.Graphics.DrawString("Mall i bler kthehet vetem me fakture", bilgiler1, sbrush, 100, y + 155, myStringFormat2);
            e.Graphics.DrawString("2018", myFont11, sbrush, 100, y + 170,myStringFormat2);
            e.Graphics.DrawString(comboBox1.Text.ToString(), bilgiler1, sbrush, 80, y + 190);
            e.Graphics.DrawString("-", myFont11, sbrush, 100, y + 210,myStringFormat2);





        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
        public void total2()
        {
            decimal toplam = Convert.ToDecimal(textBox2.Text);

            ttoplam.Text = toplam.ToString("c");
        }
        public void paraustu1()
        {
            decimal toplam = Convert.ToDecimal(textBox2.Text);

            decimal verilen = Convert.ToDecimal(verilentxt.Text);

            tparaustu.Text = (verilen - toplam).ToString("C");
        }
        public void topla2()
        {
            decimal gTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                gTotal += fiyat;

                dataGridView1.Rows[i].Cells[6].Value = fiyat.ToString("c");

            }

            textBox2.Text = gTotal.ToString();
            verilentxt.SelectAll();
            verilentxt.Focus();
            total2();
        }
        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                topla2();

            }
        }

        private void bleresit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bleresit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void adressa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void vendi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void musterikaydet_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4];
                dataGridView1.BeginEdit(true);
            }
        }

        private void tarih_Click(object sender, EventArgs e)
        {

        }
     

        private void verilentxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void verilentxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void verilentxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                paraustu1();
                comboBox2.SelectAll();
                comboBox2.Focus();

            }
        }
        public void raporla()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)//datagridview satırlarını aldık             
            {

                try   // MySql connection
                {
                    string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                    MySqlConnection connection = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = connection.CreateCommand();
                    if (row.IsNewRow) continue;
                    cmd.Parameters.AddWithValue("@ilacisim", row.Cells["emri"].Value);
                    cmd.Parameters.AddWithValue("@adet", row.Cells["sasia"].Value);
                    cmd.Parameters.AddWithValue("@fiyat", row.Cells["qmimi"].Value);
                    cmd.Parameters.AddWithValue("@toplam", row.Cells["total"].Value);
                    cmd.Parameters.AddWithValue("@tarih", tarih.Text);



                    cmd.CommandText = "INSERT INTO raporlar(emri, tarih, sasia, qmimi,total)VALUES(@ilacisim, @tarih, @adet, @fiyat, @toplam)";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

            private void button5_Click(object sender, EventArgs e)
            {

               
            double [] satilan =new double[100];
            double[] kalan =new double[100];
            bool durum = true;
           
            foreach (DataGridViewRow row in dataGridView1.Rows)//datagridview satırlarını aldık             
            {

                try   // MySql connection
                {
                    
                    if (row.IsNewRow) continue;
                    for (int i = 0; i <dataGridView1.Rows.Count-1; i++)
                    {
                        satilan[i] = Convert.ToDouble(row.Cells["sasia"].Value);
                        kalan[i] = Convert.ToDouble(row.Cells["mbetja"].Value);
                        if (satilan[i] > kalan[i])
                        {
                            durum = false;
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (durum==false)
            {
                MessageBox.Show("Kjo artikuj nuk ka ma shume");
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123");
                cnn.Open();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    
                        string adi = dataGridView1.Rows[i].Cells[0].Value.ToString(); // ilk kolon urun adi
                        decimal miktar = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value); // ikinci kolon adedi
                                                                                            // dGV2'deki her ürünün miktarı kadar DB'deki o ürünün miktarından çıkarıyoruz.
                        MySqlCommand cmd = new MySqlCommand("Update beki set sasia=(sasia-@miktar) where barcode=@adi", cnn);
                        cmd.Parameters.AddWithValue("@miktar", miktar);
                        cmd.Parameters.AddWithValue("@adi", adi);
                        cmd.ExecuteNonQuery();
                    


                }


                
                MessageBox.Show("Shitje OK !", "Shitje !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                raporla();
                printDocument1.Print();
                dataGridView1.Rows.Clear();
                

                }

            paraustu1();

            comboBox2.Text = "";
            ttoplam.Text = "0,00";
            tparaustu.Text = "0,00";
            textBox2.Text = "0,00";


        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
     
        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris3 og = new ozelgiris3();
            og.Show();
        }

        private void haftalıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris4 og = new ozelgiris4();
            og.Show();
        }

        private void aylıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris5 og = new ozelgiris5();
            og.Show();
        }

        private void yıllıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris6 og = new ozelgiris6();
            og.Show();

        }
        
        private void malliİRiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris og = new ozelgiris();
            og.Show();
           
        }

        private void malliRegjistrumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris1 og = new ozelgiris1();
            og.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ozelgiris2 og = new ozelgiris2();
            og.Show();
        }

        private void mallİKthimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelgiris7 og = new ozelgiris7();
            og.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT * FROM beki where emri Like '" + comboBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = dr["barcode"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = dr["Emri"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = dr["njesia"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = dr["sasia"].ToString();

                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = dr["qmimi"].ToString();

            }

            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }

        private void comboBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4];
                dataGridView1.BeginEdit(true);
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
            Ara();
        }
    }
    
}
