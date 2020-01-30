using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaprak_Stok_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BekiTrade" && textBox2.Text == "1" || textBox1.Text == "1" && textBox2.Text == "2")
            {
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "BekiTrade" && textBox2.Text == "1" || textBox1.Text == "1" && textBox2.Text == "2")
                {
                    frm.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
