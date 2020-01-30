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
    public partial class yeniEkle : Form
    {
        public yeniEkle()
        {
            InitializeComponent();
        }

        public void ekle()
        {
            try   // MySql connection
            {
                string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd = connection.CreateCommand();

                cmd.Parameters.AddWithValue("@barkod", txtbarkod.Text.ToString());
                cmd.Parameters.AddWithValue("@emri", txtilacadi.Text.ToString());
                cmd.Parameters.AddWithValue("@njesia", txtnjesia.Text.ToString());
                cmd.Parameters.AddWithValue("@sasia", txtadet.Text.ToString());
                cmd.Parameters.AddWithValue("@qmimi", txtqmimi.Text);
                cmd.Parameters.AddWithValue("@blerje", txtblerje.Text.ToString());




                cmd.CommandText = "INSERT INTO beki(barcode, emri, njesia, sasia,qmimi,qmimi_blerjes)VALUES(@barkod, @emri, @njesia, @sasia,@qmimi,@blerje)";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Regjistro Regull !.");
        }
        public void ekle2()
        {
            try   // MySql connection
            {
                string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd = connection.CreateCommand();

                cmd.Parameters.AddWithValue("@barkod", txtbarkod.Text.ToString());
                cmd.Parameters.AddWithValue("@emri", txtilacadi.Text.ToString());
                cmd.Parameters.AddWithValue("@njesia", txtnjesia.Text.ToString());
                cmd.Parameters.AddWithValue("@sasia", txtadet.Text.ToString());
                cmd.Parameters.AddWithValue("@qmimi", txtqmimi.Text);
                cmd.Parameters.AddWithValue("@blerje", txtblerje.Text.ToString());



                cmd.CommandText = "INSERT INTO stok(barcode, emri, njesia, sasia,qmimi,qmimi_blerjes)VALUES(@barkod, @emri, @njesia, @sasia,@qmimi,@blerje)";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
            ekle2();
            txtbarkod.Text = "";
            txtilacadi.Text = "";
            txtblerje.Text = "";
            txtadet.Text = "";
            txtqmimi.Text = "";
            txtnjesia.Text = "";
            txtbarkod.Focus();
        }

        private void txtilacadi_Leave(object sender, EventArgs e)
        {
            txtilacadi.Text=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtilacadi.Text);
        }

        private void txtnjesia_Leave(object sender, EventArgs e)
        {
            txtnjesia.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnjesia.Text);
        }

        private void yeniEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
