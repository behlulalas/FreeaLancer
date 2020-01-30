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
    public partial class Guncelle : Form
    {
        public Guncelle()
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
        private void Guncelle_Load(object sender, EventArgs e)
        {
            BaglantiYap();
            VeriGetir();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[11].Visible = true;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=yaprak1; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "SELECT id, barcode as Barkod, urun as 'Ürün Adı', olcu as Ölçü, birim as Birim, Fiyat as 'BG Fiyat', t_fiyat as 'T Fiyat',p_fiyat as 'P Fiyat',Firma,Bilgi as İletişim,Yil,resim  from muhasebe where urun Like '" + arama.Text + "%' or barcode Like '" + arama.Text + "%' or firma Like '" + arama.Text + "%'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            this.Close();
        }
        public void UrunGuncelle()
        {
            baglanti.Open();
            //string sql = "Update muhasebe Set  barcode='" + textBox1.Text + "',Urun='" + textBox2.Text + "',Olcu='" + textBox3.Text + "',Birim='" + textBox4.Text + "',Fiyat='" + textBox5.Text + "',p_fiyat='" + textBox10.Text + "',t_fiyat='" + textBox5.Text + "',Firma='" + textBox6.Text + "',Bilgi='" + textBox7.Text + "',resim='" + textBox9.Text + "',Yil='" + textBox8.Text + "'  where id='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            //MySqlCommand command = new MySqlCommand(sql, baglanti);
            MySqlCommand komut = new MySqlCommand("Update muhasebe Set  barcode=@barcode,Urun=@Urun,Olcu=@Olcu,Birim=@Birim,Fiyat=@Fiyat,p_fiyat=@p_fiyat,t_fiyat=@t_fiyat,Firma=@Firma,Bilgi=@Bilgi,resim=@resim,Yil=@Yil  where id='" + dataGridView1.CurrentRow.Cells[0].Value + "'", baglanti);
            komut.Parameters.AddWithValue("@barcode", textBox1.Text);
            komut.Parameters.AddWithValue("@Urun", textBox2.Text.ToString());
            komut.Parameters.AddWithValue("@Olcu", textBox3.Text.ToString());
            komut.Parameters.AddWithValue("@Birim", textBox4.Text.ToString());
            komut.Parameters.AddWithValue("@Fiyat", textBox5.Text.ToString());
            komut.Parameters.AddWithValue("@p_fiyat", textBox10.Text.ToString());
            komut.Parameters.AddWithValue("@t_fiyat", textBox11.Text.ToString());
            komut.Parameters.AddWithValue("@Firma", textBox6.Text.ToString());
            komut.Parameters.AddWithValue("@Bilgi", textBox7.Text.ToString());
            komut.Parameters.AddWithValue("@Yil", textBox8.Text.ToString());
            komut.Parameters.AddWithValue("@resim", textBox9.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            UrunGuncelle();
            Ara();

            dataGridView1.CurrentCell = dataGridView1.Rows[secilen].Cells[0];
            dataGridView1.BeginEdit(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox9.Text = openFileDialog1.FileName;
        }
        public static string resimyolu;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Form1.pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "Delete from muhasebe where id='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            MySqlCommand command = new MySqlCommand(sql, baglanti);

            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silindi !.");
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            Ara();
            dataGridView1.CurrentCell = dataGridView1.Rows[secilen].Cells[2];
            dataGridView1.BeginEdit(true);
        }
    }
}
