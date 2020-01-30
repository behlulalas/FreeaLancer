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
    public partial class aylik : Form
    {
        public aylik()
        {
            InitializeComponent();
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
        private void aylik_Load(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;

            dateTimePicker1.Value = date1;
            Ara();
            topla2();
        }
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "Select * from raporlar where MONTH(tarih)=MONTH(CURDATE())";
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


            string sql = "Select * from raporlar where MONTH(tarih)=MONTH('" + selectDateAsString + "')";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Ara2();
            topla2();

        }
    }
}
