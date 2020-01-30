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
        //private static int faturaNo = 0;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            oto();
            faturanoup();
            faturano();
            
            printDocument1.PrinterSettings.Copies = 2;
            printDialog1.PrinterSettings.Copies = 2;
            
            //faturaNo++;
            //textBox5.Text = faturaNo.ToString("000");
            tarih.Text = DateTime.Now.ToString("dd/MM/yyy");
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "yaprak";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            /*bleresit.CharacterCasing = CharacterCasing.Upper;
            vendi.CharacterCasing = CharacterCasing.Upper;
            adressa.CharacterCasing = CharacterCasing.Upper;*/




        }
        public void oto()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "yaprak";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT * FROM alicilar where musteri_adi  Like '" + comboBox1.Text+ "%'";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["musteri_adi"]);
                
            }
             
            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }
        public void faturano()
        {
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT * FROM fatura";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int fatura = int.Parse(dr["fatura_no"].ToString());
                textBox5.Text = fatura.ToString("000");





            }

            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }
        public void faturanoup()
        {
            baglanti.Open();
            string sql = "INSERT INTO fatura (fatura_no, bos) VALUES (NULL, '2')";
            MySqlCommand command = new MySqlCommand(sql, baglanti);

            command.ExecuteNonQuery();
            baglanti.Close();
           
        }
        public void Listele()
        {
            string sql = "SELECT * FROM urunler";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;
            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void Ara()
        {
            baglanti.Open();

            string sql = "Select * from urunler where Kod Like '" + textBox1.Text + "%'";
            MySqlCommand command = new MySqlCommand(sql,baglanti);

            MySqlDataReader rdr = command.ExecuteReader();
            if (!rdr.Read())
            {
                
            }
            else
            {
                // Kullanıcı varsa sütunda ki verileri labellere yazdırıyoruz.
                // Tırnak içindekiler sütunda ki ismi geçen yazılardır.
                
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = rdr["kod"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = rdr["Emri"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = rdr["njesia"].ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = rdr["qmimi"].ToString();
                
                

            }
            // Her şey tamam ise bağlantıları kapatıyoruz..
            rdr.Close();
            
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
            DialogResult result = MessageBox.Show("Fatura Numarası arttırılsın mı ?", "Fatura NO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                faturanoup();
                faturano();
            }
            else if (result == DialogResult.No)
            {
                faturano();
            }
            else
            {
                //...
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Arial", 28, FontStyle.Bold);
            Font myFont1 = new Font("Arial", 15, FontStyle.Italic);
            Font Firma = new Font("Calibri", 36, FontStyle.Underline);
            Font bilgiler = new Font("Calibri", 12);
            Font faturano = new Font("Calibri", 18);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen üstcizgiler = new Pen(Color.Black,3);
            Pen sagkare = new Pen(Color.Black);

            e.Graphics.DrawImage(Properties.Resources.sonlogo1, 10, 10);
            e.Graphics.DrawString("n.p.t  \"YAPRAK\"", Firma, sbrush, 95, 10);
            e.Graphics.DrawString("Adresa: MAMUSHE", bilgiler, sbrush, 25, 85);
            e.Graphics.DrawString("Mob: (044) 415-864 338-758 718-500", bilgiler, sbrush, 25, 105);
            e.Graphics.DrawString("Tel: (029) 273-073 Fax (029) 273-072", bilgiler, sbrush, 25, 125);
            e.Graphics.DrawString("Email:yaprak_mamusa@hotmail.com", bilgiler, sbrush, 25, 145);
            e.Graphics.DrawString("Web:www.yaprak-ks.com", bilgiler, sbrush, 25, 165);
            e.Graphics.DrawString("Facebook: /yaprak.mamusa", bilgiler, sbrush, 25, 185);
            e.Graphics.DrawString("DATA:", bilgiler, sbrush, 25, 350);
            e.Graphics.DrawString("FATURA-INVOICE", bilgiler, sbrush, 80, 245);
            e.Graphics.DrawString("NR:FATURES:", bilgiler, sbrush, 25, 285);
            e.Graphics.DrawString(textBox5.Text, faturano,sbrush, 120, 295);
            e.Graphics.DrawString("NR:INVOICE:", bilgiler, sbrush, 25, 305);
            
            e.Graphics.DrawString(tarih.Text, bilgiler, sbrush, 80, 350);
            /* Birinci Kare */
            e.Graphics.DrawLine(sagkare, 450, 60, 750, 60);//sağ üst 1.yatay kısa çizgi
            e.Graphics.DrawLine(sagkare, 450, 60, 450, 200);//sol üst dikey kısa çizgi
            e.Graphics.DrawLine(sagkare, 450, 200, 750, 200);//sağ alt 1.yatay kısa çizgi
            e.Graphics.DrawLine(sagkare, 750, 60, 750, 200);//sağ üst dikey kısa çizgi
            e.Graphics.DrawString("Nr.FISKAL:    60077665", bilgiler, sbrush, 480, 65);
            e.Graphics.DrawString("Nr.BIZNISIT:  80383959", bilgiler, sbrush, 480, 85);
            e.Graphics.DrawString("BANKAT", bilgiler, sbrush, 480, 130);
            e.Graphics.DrawString("TEB:                     2028000023743335", bilgiler, sbrush, 480, 160);
            e.Graphics.DrawString("Pro Credit Bank: 1120127325000166", bilgiler, sbrush, 480, 180);

            /* Birinci Kare */

            /* İkinci Kare */
            e.Graphics.DrawLine(sagkare, 350, 220, 755, 220);//sağ üst 1.yatay kısa çizgi
            e.Graphics.DrawLine(sagkare, 350, 220, 350, 370);//sağ üst dikey kısa çizgi
            e.Graphics.DrawLine(sagkare, 350, 370, 755, 370);//sağ alt 1.yatay kısa çizgi
            e.Graphics.DrawLine(sagkare, 755, 220, 755, 370);//sağ üst dikey kısa çizgi
            e.Graphics.DrawString("Detaje e Bleresit ", bilgiler, sbrush, 380, 250);
            e.Graphics.DrawString(comboBox1.Text, bilgiler, sbrush, 508, 250);
            e.Graphics.DrawString("Adressa :", bilgiler, sbrush, 380, 280);
            e.Graphics.DrawString(adressa.Text, bilgiler, sbrush, 450, 280);
            e.Graphics.DrawString("Vendi :", bilgiler, sbrush, 380, 300);
            e.Graphics.DrawString(vendi.Text, bilgiler, sbrush, 450, 300);
            e.Graphics.DrawString("Nr.FISKAL :", bilgiler, sbrush, 380, 320);
            e.Graphics.DrawString(fiskal.Text, bilgiler, sbrush, 460, 320);
           
            /* İkinci Kare */
            e.Graphics.DrawLine(üstcizgiler, 15, 10, 800, 10);//enüstteki yatay çizgi
            e.Graphics.DrawLine(üstcizgiler, 15, 400, 800, 400);//alttaki yatay çizgi
            e.Graphics.DrawLine(üstcizgiler, 15, 10, 15, 400);//sol dikey çizgi
            e.Graphics.DrawLine(üstcizgiler, 800, 10, 800, 400);//sağ dikey çizgi

            myFont = new Font("Arial", 12);
            Font emertimi = new Font("Arial", 12);
            Font total = new Font("Arial", 12,FontStyle.Bold);






            int y = 480;
            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Near;
            StringFormat myStringFormat1 = new StringFormat();
            myStringFormat1.Alignment = StringAlignment.Far;
            StringFormat myStringFormat2 = new StringFormat();
            myStringFormat2.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("Kodi", total, sbrush, 55, 482);
            e.Graphics.DrawString("Emri i Artikujt", total, sbrush, 235, 482);
            e.Graphics.DrawString("Njesia", total, sbrush, 528, 482);
            e.Graphics.DrawString("Sasia", total, sbrush, 590, 482);
            e.Graphics.DrawString("Qmimi", total, sbrush, 650, 482);
            e.Graphics.DrawString("Total", total, sbrush, 735, 482);
            e.Graphics.DrawLine(sagkare, 50, 500, 800, 500);//baştaki yatay çizgi


            e.Graphics.DrawString("Pranoi:________________", myFont, sbrush, 120, 970);
            e.Graphics.DrawString("Dorezoi:_________________", myFont, sbrush, 540, 970);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawLine(sagkare, 50, 480, 50, y + 40);//en baştaki dik çizgi
                e.Graphics.DrawLine(sagkare, 100, 480, 100, y+40);//1.DİK ÇİZGİ
                e.Graphics.DrawLine(sagkare, 525, 480, 525, y + 40);//2. dik çizgi
                e.Graphics.DrawLine(sagkare, 580, 480, 580, y + 40);//3. dik çizgi
                e.Graphics.DrawLine(sagkare, 645, 480, 645, y + 40);//4. dik çizgi 
                e.Graphics.DrawLine(sagkare, 710, 480, 710, y + 40);//5. dik cizgi
                e.Graphics.DrawLine(sagkare, 800, 480, 800, y + 40);//en sondaki dik çizgi
              


                e.Graphics.DrawLine(sagkare, 50, y+40, 800, y+40);//ortadaki yatay çizgiler
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), myFont, sbrush, 75, y+20, myStringFormat2);//id
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), emertimi, sbrush, 105, y+20, myStringFormat);//Emri
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), myFont, sbrush, 530, y+20, myStringFormat);//Njesia
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), myFont, sbrush, 600, y+20, myStringFormat);//Sasia
                    e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 650, y + 20, myStringFormat);//Qmimi
                    //e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), myFont, sbrush, 710, y+20, myStringFormat);//Total

                e.Graphics.DrawString(dataGridView1.Text, myFont, sbrush, 220, y);
               
                y += 20;


            }
            e.Graphics.DrawLine(sagkare, 50, 480, 800, 480);//baştaki yatay çizgi
            e.Graphics.DrawLine(sagkare, 50, y, 800, y);//dipdeki yatay çizgi
            e.Graphics.DrawString(textBox2.Text, total, sbrush, 630, y + 30, myStringFormat);
            e.Graphics.DrawString("TOTAL:", total, sbrush, 550, y + 30, myStringFormat);



    



        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

    

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal gTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    gTotal += fiyat;
                    
                    

                }

                textBox2.Text = gTotal.ToString("c");
            }
        }

        private void bleresit_TextChanged(object sender, EventArgs e)
        {
            oto();
        }

        private void bleresit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
            {
                comboBox1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(comboBox1.Text);
                adressa.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adressa.Text);
                vendi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vendi.Text);

            }
        }

        private void adressa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {               
                adressa.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adressa.Text);                
            }
        }

        private void vendi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                vendi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vendi.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void musterikaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "INSERT INTO alicilar (musteri_adi, musteri_yer, musteri_fiskal, musteri_ulke, musteri_biznis) VALUES ( '"+comboBox1.Text+"', '"+adressa.Text+"', '"+fiskal.Text+"', '"+vendi.Text+"', '"+biznis.Text+"')";
            MySqlCommand command = new MySqlCommand(sql,baglanti);    
            
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri eklendi !");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT * FROM alicilar where musteri_adi Like '" + comboBox1.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adressa.Text = dr["musteri_yer"].ToString();
                vendi.Text = dr["musteri_ulke"].ToString();
                fiskal.Text = dr["musteri_fiskal"].ToString();
                biznis.Text = dr["musteri_biznis"].ToString();

            }

            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)//datagridview satırlarını aldık             
            {

                try   // MySql connection
                {
                    string MyConnectionString = "Server=localhost; Database=yaprak; Uid=root; Pwd=mamusa123";
                    MySqlConnection connection = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = connection.CreateCommand();
                    if (row.IsNewRow) continue;
                    cmd.Parameters.AddWithValue("@invoice", row.Cells["kod"].Value);
                    cmd.Parameters.AddWithValue("@jobOrder", row.Cells["emri"].Value);
                    cmd.Parameters.AddWithValue("@dateTime", row.Cells["njesia"].Value);
                    cmd.Parameters.AddWithValue("@clientCode", row.Cells["sasia"].Value);
                    cmd.Parameters.AddWithValue("@clientName", row.Cells["qmimi"].Value);
                   

                    cmd.CommandText = "INSERT INTO urunler(kod, Emri, Njesia, Sasia, Qmimi)VALUES(@invoice, @jobOrder, @dateTime, @clientCode, @clientName)";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Yeni ürün Eklendi !.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
