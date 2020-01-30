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

namespace Yaprak_Stok_Takip
{
    public partial class frmguncelle : Form
    {
        public frmguncelle()
        {
            InitializeComponent();
        }
        public void guncelle222()
        {
            try
            {
                
                int miktar = Convert.ToInt32(txtadet.Text);
                string baglanti = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                string sorgu = "UPDATE beki SET barcode='" + txtbarkod.Text + "',emri='" + txtilacadi.Text + "',sasia=sasia+'"+miktar+"',qmimi='" + txtfiyat.Text + "',qmimi_blerjes='" + blerje.Text + "' where kod='" + txtno.Text + "';";
                MySqlConnection baglanti2 = new MySqlConnection(baglanti);
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti2);
                MySqlDataReader MyReader2;
                baglanti2.Open();
                MyReader2 = komut.ExecuteReader();
               
                while (MyReader2.Read())
                {
                }
                baglanti2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          


        }
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "Select * from beki where barcode = '" + aratxt.Text + "' or emri Like '" + aratxt.Text + "%'";
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
        public void guncelle111()
        {
            
            int miktar = Convert.ToInt32(txtadet.Text);
            try
            {

                string baglanti = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                string sorgu = "UPDATE stok SET barcode='" + txtbarkod.Text + "',emri='" + txtilacadi.Text + "',sasia=sasia+'" + miktar + "',qmimi='" + txtfiyat.Text + "',qmimi_blerjes='" + blerje.Text + "' where kod='" + txtno.Text + "';";
                MySqlConnection baglanti2 = new MySqlConnection(baglanti);
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti2);
                MySqlDataReader MyReader2;
                baglanti2.Open();
                MyReader2 = komut.ExecuteReader();
                
                MessageBox.Show("Regull !.");
                while (MyReader2.Read())
                {
                }
                baglanti2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtadet.Text = "0";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            guncelle222();
            guncelle111();
            Listele();
            
        }
        public void Listele()
        {
            string MyConnectionString = "Server=sql213.byetcluster.com; Port=3306; Database=epiz_21477598_makineler; Uid=epiz_21477598; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();
            DataTable dt = new DataTable();
            dt.Clear();
            string sql = "SELECT * FROM adminler";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = connection;
            adapter.SelectCommand = command;
            connection.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
            txtno.Text = "";
            txtbarkod.Text = "";
            txtilacadi.Text = "";
            txtfiyat.Text = "";
            aratxt.Text = "";
        }
        private void frmguncelle_Load(object sender, EventArgs e)
        {
           

            Listele();
            txtadet.Text = "0";
            txtno.Text = "";
            txtbarkod.Text = "";
            txtilacadi.Text = "";
            txtfiyat.Text = "";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            txtno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbarkod.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtilacadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            blerje.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void aratxt_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }
    }
}
