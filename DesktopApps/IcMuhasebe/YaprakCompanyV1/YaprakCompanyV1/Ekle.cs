using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaprakCompanyV1
{
    public partial class Ekle : Form
    {
        MySqlConnection baglanti;
        public void BaglantiYap()
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "mamusa123";
            build.Database = "yaprak1";
            build.Server = "localhost";
            bag = build.ToString();
            baglanti = new MySqlConnection(bag);
        }
        public Ekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            this.Hide();
        }
        public void urunEkle()
        {
            baglanti.Open();
            //string sql = "INSERT INTO muhasebe (barcode,Urun,Olcu,Birim,Fiyat,p_fiyat,t_fiyat,Firma,Bilgi,Yil,resim) VALUES ('" + textBox8.Text + "','" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text.ToString() + "')";
            //MySqlCommand command = new MySqlCommand(sql, baglanti);
            MySqlCommand komut = new MySqlCommand("INSERT INTO muhasebe(barcode, Urun, Olcu, Birim, Fiyat, p_fiyat, t_fiyat, Firma,Bilgi,Yil,resim) VALUES (@barcode,@Urun,@Olcu,@Birim,@Fiyat,@p_fiyat,@t_fiyat,@Firma,@Bilgi,@Yil,@resim)", baglanti);
            komut.Parameters.AddWithValue("@barcode", textBox8.Text);
            komut.Parameters.AddWithValue("@Urun", textBox1.Text.ToString());
            komut.Parameters.AddWithValue("@Olcu", textBox2.Text.ToString());
            komut.Parameters.AddWithValue("@Birim", textBox3.Text.ToString());
            komut.Parameters.AddWithValue("@Fiyat", textBox4.Text.ToString());
            komut.Parameters.AddWithValue("@p_fiyat", textBox9.Text.ToString());
            komut.Parameters.AddWithValue("@t_fiyat", textBox10.Text.ToString());
            komut.Parameters.AddWithValue("@Firma", textBox5.Text.ToString());
            komut.Parameters.AddWithValue("@Bilgi", textBox6.Text.ToString());
            komut.Parameters.AddWithValue("@Yil", textBox7.Text.ToString());
            komut.Parameters.AddWithValue("@resim", textBox11.Text.ToString());

            
            komut.ExecuteNonQuery();
            //command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Ürün Eklendi !.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from muhasebe where urun='"+textBox1.Text+"'", baglanti);
                MySqlDataReader bilgigetir = komut.ExecuteReader();

                if (bilgigetir.Read())
                {
                    baglanti.Close();
                    DialogResult dialogResult = MessageBox.Show("Bu kayıt zaten var! Eklemek istiyor musun?", "Aynı Kayıt", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        urunEkle();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }
                    
                        

                    
                }
                else
                {
                    baglanti.Close();

                    urunEkle();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";

                }
               
                   
            }
            else
            {
                MessageBox.Show("Alanları boş Brakamazsınız. !");
            }
           
           
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            BaglantiYap();
        }

   

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox11.Text = openFileDialog1.FileName;

        }
    }
}
