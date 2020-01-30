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
	public partial class Guvenlik : Form
	{
		public Guvenlik()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox3.Text == "yaprak1221." || textBox3.Text == "YAPRAK1221.")
			{
				this.Hide();
				Form1 form1 = new Form1();
				form1.ShowDialog();
			}
			else
			{
				MessageBox.Show("Parola Hatalı !", "Giriş Başarısız.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (textBox3.Text == "yaprak1221" || textBox3.Text == "YAPRAK1221")
				{
					this.Hide();
					Form1 form1 = new Form1();
					form1.ShowDialog();
				}
				else
				{
					MessageBox.Show("Parola Hatalı !", "Giriş Başarısız.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}
	}
}
