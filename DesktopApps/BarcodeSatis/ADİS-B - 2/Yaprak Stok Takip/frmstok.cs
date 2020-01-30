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
    public partial class frmstok : Form
    {
        public frmstok()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();
            DataTable dt = new DataTable();
            dt.Clear();
            string sql = "SELECT * FROM stok";
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
        public void Ara()
        {
            string MyConnectionString = "Server=localhost; Database=bekitrade; Uid=root; Pwd=mamusa123";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();


            string sql = "Select * from stok where barcode = '" + txtbarkod.Text + "' or emri Like '" + txtbarkod.Text + "%'";
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
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                gTotal += fiyat;



            }

            textBox2.Text = gTotal.ToString("c");

        }
        public void topla3()
        {
            decimal gTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                gTotal += fiyat;



            }

            textBox1.Text = gTotal.ToString("c");

        }
        private void frmstok_Load(object sender, EventArgs e)
        {
            Listele();
            topla2();
            topla3();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            Ara();
            topla2();
            topla3();
        }
    }
}
