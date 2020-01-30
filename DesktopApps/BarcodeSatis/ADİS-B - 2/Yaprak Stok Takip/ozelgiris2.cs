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
    public partial class ozelgiris2 : Form
    {
        public ozelgiris2()
        {
            InitializeComponent();
        }
        frmstok fs = new frmstok();
        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == "beki1981")
                {
                    fs.ShowDialog();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
