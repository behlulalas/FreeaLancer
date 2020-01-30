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
    public partial class gunluk : Form
    {
        public gunluk()
        {
            InitializeComponent();
        }
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "Select * from raporlar where tarih=CURDATE()";
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
        public void Ara2()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();
            string selectDateAsString = dateTimePicker1.Value.ToString("yyyy-MM-dd");


            string sql = "Select * from raporlar where tarih='" + selectDateAsString + "'";
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
        public void topla2()
        {
            decimal gTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                gTotal += fiyat;

                dataGridView1.Rows[i].Cells[5].Value = fiyat.ToString("c");

            }

            textBox2.Text = gTotal.ToString("c");

        }
        public void iadeet()
        {

            

                try   // MySql connection
                {
                    string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                    MySqlConnection connection = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = connection.CreateCommand();
                   
                    
                    cmd.Parameters.AddWithValue("@isim", dataGridView1.CurrentRow.Cells[1].Value);
                    
                    cmd.Parameters.AddWithValue("@tarih", dataGridView1.CurrentRow.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@adet", dataGridView1.CurrentRow.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@fiyat", dataGridView1.CurrentRow.Cells[4].Value);
                    cmd.Parameters.AddWithValue("@total", dataGridView1.CurrentRow.Cells[5].Value);


                cmd.CommandText = "INSERT INTO iade(emri, tarih, sasia, qmimi, total)VALUES(@isim, @tarih, @adet, @fiyat,@total)";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
       

        }
        public void iadeetekle()
        {



            try   // MySql connection
            {
                string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd = connection.CreateCommand();


                cmd.Parameters.AddWithValue("@adet", dataGridView1.CurrentRow.Cells[3].Value);
                cmd.Parameters.AddWithValue("@adi", dataGridView1.CurrentRow.Cells[1].Value);



                cmd.CommandText = "UPDATE beki SET sasia=(sasia+@adet) WHERE emri=@adi";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           



        }
        public void iadesil()
        {
            if (MessageBox.Show("A po du me kthej", "Kthej", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try   // MySql connection
                {
                    string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
                    MySqlConnection connection = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = connection.CreateCommand();


                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);

                 


                    cmd.CommandText = "DELETE FROM raporlar WHERE id=@id";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Mall i Ktehet !.");

            }
            else
            {

            }
        }
        private void gunluk_Load(object sender, EventArgs e)
        {
            DateTime date1= DateTime.Now;
            dateTimePicker1.Value = date1;
            Ara();
            topla2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Ara2();
            topla2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iadeet();
            iadeetekle();
            iadesil();
            Ara();
            topla2();

        }
    }
}
