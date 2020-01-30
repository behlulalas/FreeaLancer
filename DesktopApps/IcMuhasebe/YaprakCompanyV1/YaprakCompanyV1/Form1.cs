using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YaprakCompanyV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti;
        public void BaglantiYap()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "yaprak1";
            build.Server = "localhost";
            build.SslMode = MySqlSslMode.None;
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
        }
        public void VeriGetir()
        {
            string sql = "SELECT id, barcode as Barkod, urun as 'Ürün Adı', olcu as Ölçü, birim as Birim, Fiyat as 'BG Fiyat', t_fiyat as 'T Fiyat',p_fiyat as 'P Fiyat',Firma,Bilgi as İletişim,Yil,resim FROM muhasebe";
            DataTable dt = new DataTable();
            dt.Clear();
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
        private void button1_Click(object sender, EventArgs e)
        {
            //hoverpanel.Height = button1.Height;
            //hoverpanel.Top = button1.Top;
            //label5.Visible = true;
            //dataGridView1.Visible = false;
            //textBox1.Visible = false;
            //label8.Visible = false;
            //button6.Visible = false;
            //arama.Visible = false;
            //label9.Visible = false;
            //pictureBox1.Visible = false;
        }
        //public void Total()
        //{
        //    decimal gTotal = 0;
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
        //        gTotal += fiyat;

                

        //    }

        //    label7.Text = gTotal.ToString("c");
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            arama.Items.Clear();
            doldur();
            hoverpanel.Height = button2.Height;
            hoverpanel.Top = button2.Top;
            dataGridView1.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;
            button6.Visible = true;
            arama.Visible = true;
            label9.Visible = true;
            label5.Visible = false;
            pictureBox1.Visible = true;
            VeriGetir();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns[11].Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
           
            label8.Visible = false;
            button6.Visible = false;
            arama.Visible = false;
            label9.Visible = false;
            Ekle frm2 = new Ekle();
            textBox1.Visible = false;
            hoverpanel.Height = button3.Height;
            hoverpanel.Top = button3.Top;
            frm2.ShowDialog();
            pictureBox1.Visible = false;
            

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            BaglantiYap();
            
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            label8.Visible = false;
            button6.Visible = false;
            arama.Visible = false;
            
            //doldur();
        }
        public void klasortemizle()
        {
            FileInfo fileInfo;
            string uzanti = ".sql";

            foreach (string dosya in Directory.GetFiles("F:\\PROGRAMYEDEK"))
            {
                fileInfo = new FileInfo(dosya);
                if (fileInfo.Extension == uzanti) // Dosya Uzantısı ve sizin uzantınız aynımı ??
                {
                    fileInfo.Delete();
                }
            }
        }
        public void yedekal()
        {


            string conn = "Server=localhost; Database=yaprak1; Uid=root; Pwd=mamusa123; SSLMode=none";
            string file = "F:\\PROGRAMYEDEK\\muhasebe.sql";
            MySqlConnection con = new MySqlConnection(conn);

            MySqlCommand cmd = new MySqlCommand();

            MySqlBackup mb = new MySqlBackup(cmd);



            cmd.Connection = con;
            con.Open();
            mb.ExportToFile(file);
            con.Close();


            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "Delete from muhasebe where id='"+ dataGridView1.CurrentRow.Cells[0].Value + "'";
            MySqlCommand command = new MySqlCommand(sql, baglanti);

            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silindi !.");
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (textBox1.Text=="")
            {
                Ara();
            }
            else if(arama.Text=="")
            {
                urunAra();
            }
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[secilen].Cells[2];
                dataGridView1.BeginEdit(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
           
           
            
            
        }
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=yaprak1; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "SELECT id, barcode as Barkod, urun as 'Ürün Adı', olcu as Ölçü, birim as Birim, Fiyat as 'BG Fiyat', t_fiyat as 'T Fiyat',p_fiyat as 'P Fiyat',Firma,Bilgi as İletişim,Yil,resim from muhasebe where Firma Like '%" + arama.Text.Trim()+ "%'";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = connection;
            adapter.SelectCommand = command;
            connection.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        private void arama_TextChanged(object sender, EventArgs e)
        {
            Ara();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.ShowDialog();
            arama.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            dataGridView1.Visible = false;
            button6.Visible = false;
            

        }
        public void doldur()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "yaprak1";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            baglanti.Open();
            MySqlDataReader dr;
            string mysql = "SELECT firma from muhasebe group by firma";
            MySqlCommand cmd = new MySqlCommand(mysql, baglanti);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                arama.Items.Add(dr["firma"]);

            }

            //comboBox1.AutoCompleteCustomSource = col;
            baglanti.Close();
        }
        private void arama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ara();
            
        }
        public void urunAra()
        {
            string MyConnectionString = "Server=localhost; Database=yaprak1; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "SELECT id, barcode as Barkod, urun as 'Ürün Adı', olcu as Ölçü, birim as Birim, Fiyat as 'BG Fiyat', t_fiyat as 'T Fiyat',p_fiyat as 'P Fiyat',Firma,Bilgi as İletişim,Yil,resim from muhasebe where urun Like '" + textBox1.Text + "%' or barcode Like '" + textBox1.Text + "%'";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = connection;
            adapter.SelectCommand = command;
            connection.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            urunAra();
        }

        private void arama_TextChanged_1(object sender, EventArgs e)
        {
            Ara();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            klasortemizle();
            yedekal();
        }
    }
}
