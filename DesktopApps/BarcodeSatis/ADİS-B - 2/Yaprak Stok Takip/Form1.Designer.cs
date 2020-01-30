namespace Yaprak_Stok_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.njesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbetja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qmimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regjistrimiİMallitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malliİRiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malliRegjistrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yıllıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mallİKthimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ttoplam = new System.Windows.Forms.Label();
            this.tparaustu = new System.Windows.Forms.Label();
            this.verilentxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "BekiTrade";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.emri,
            this.njesia,
            this.mbetja,
            this.sasia,
            this.qmimi,
            this.total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(27, 611);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1672, 263);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dataGridView1_PreviewKeyDown);
            // 
            // kod
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kod.DefaultCellStyle = dataGridViewCellStyle2;
            this.kod.HeaderText = "Barcode";
            this.kod.Name = "kod";
            this.kod.Width = 180;
            // 
            // emri
            // 
            this.emri.HeaderText = "Emri i Artikujt";
            this.emri.Name = "emri";
            this.emri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.emri.Width = 450;
            // 
            // njesia
            // 
            this.njesia.HeaderText = "Njesia";
            this.njesia.Name = "njesia";
            // 
            // mbetja
            // 
            this.mbetja.HeaderText = "Mbetja";
            this.mbetja.Name = "mbetja";
            // 
            // sasia
            // 
            this.sasia.HeaderText = "Sasia";
            this.sasia.Name = "sasia";
            this.sasia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // qmimi
            // 
            this.qmimi.HeaderText = "Qmimi";
            this.qmimi.Name = "qmimi";
            // 
            // total
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.FillWeight = 120F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1038, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "12211_661496233953185_2785788443308952094_n.jpg");
            this.ımageList1.Images.SetKeyName(1, "images.jpg");
            this.ımageList1.Images.SetKeyName(2, "images.png");
            this.ımageList1.Images.SetKeyName(3, "yenilogo1.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "2012";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Arabic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kod";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1511, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 109;
            this.label8.Text = "DATA:";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(1562, 49);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(52, 17);
            this.tarih.TabIndex = 110;
            this.tarih.Text = "label9";
            this.tarih.Click += new System.EventHandler(this.tarih_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(1234, 880);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(290, 39);
            this.textBox2.TabIndex = 111;
            this.textBox2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Arabic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1068, 874);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 48);
            this.label9.TabIndex = 112;
            this.label9.Text = "Total";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistrimiİMallitToolStripMenuItem,
            this.ürünEkleToolStripMenuItem,
            this.mallİKthimitToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 123;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regjistrimiİMallitToolStripMenuItem
            // 
            this.regjistrimiİMallitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malliİRiToolStripMenuItem,
            this.malliRegjistrumToolStripMenuItem,
            this.toolStripMenuItem1});
            this.regjistrimiİMallitToolStripMenuItem.Name = "regjistrimiİMallitToolStripMenuItem";
            this.regjistrimiİMallitToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.regjistrimiİMallitToolStripMenuItem.Text = "Regjistrim";
            // 
            // malliİRiToolStripMenuItem
            // 
            this.malliİRiToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Kasa_Tahsilat32x32;
            this.malliİRiToolStripMenuItem.Name = "malliİRiToolStripMenuItem";
            this.malliİRiToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.malliİRiToolStripMenuItem.Text = "Mall i ri";
            this.malliİRiToolStripMenuItem.Click += new System.EventHandler(this.malliİRiToolStripMenuItem_Click);
            // 
            // malliRegjistrumToolStripMenuItem
            // 
            this.malliRegjistrumToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Kaydet24x24;
            this.malliRegjistrumToolStripMenuItem.Name = "malliRegjistrumToolStripMenuItem";
            this.malliRegjistrumToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.malliRegjistrumToolStripMenuItem.Text = "Mall i Regjistrum";
            this.malliRegjistrumToolStripMenuItem.Click += new System.EventHandler(this.malliRegjistrumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Yaprak_Stok_Takip.Properties.Resources.Cari_Hareket32x32;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.toolStripMenuItem1.Text = "Stoqet";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükToolStripMenuItem,
            this.haftalıkToolStripMenuItem,
            this.aylıkToolStripMenuItem,
            this.yıllıkToolStripMenuItem});
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ürünEkleToolStripMenuItem.Text = "Raportet";
            // 
            // günlükToolStripMenuItem
            // 
            this.günlükToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Cari_Hareket32x32;
            this.günlükToolStripMenuItem.Name = "günlükToolStripMenuItem";
            this.günlükToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.günlükToolStripMenuItem.Text = "Raport i Ditore";
            this.günlükToolStripMenuItem.Click += new System.EventHandler(this.günlükToolStripMenuItem_Click);
            // 
            // haftalıkToolStripMenuItem
            // 
            this.haftalıkToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Banka_Hareket32x32;
            this.haftalıkToolStripMenuItem.Name = "haftalıkToolStripMenuItem";
            this.haftalıkToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.haftalıkToolStripMenuItem.Text = "Raport i Javore";
            this.haftalıkToolStripMenuItem.Click += new System.EventHandler(this.haftalıkToolStripMenuItem_Click);
            // 
            // aylıkToolStripMenuItem
            // 
            this.aylıkToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Fatura_Satis32x32;
            this.aylıkToolStripMenuItem.Name = "aylıkToolStripMenuItem";
            this.aylıkToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.aylıkToolStripMenuItem.Text = "Raport i Mujore";
            this.aylıkToolStripMenuItem.Click += new System.EventHandler(this.aylıkToolStripMenuItem_Click);
            // 
            // yıllıkToolStripMenuItem
            // 
            this.yıllıkToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Banka_Havale32x32;
            this.yıllıkToolStripMenuItem.Name = "yıllıkToolStripMenuItem";
            this.yıllıkToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.yıllıkToolStripMenuItem.Text = "Raport i Vjetore";
            this.yıllıkToolStripMenuItem.Click += new System.EventHandler(this.yıllıkToolStripMenuItem_Click);
            // 
            // mallİKthimitToolStripMenuItem
            // 
            this.mallİKthimitToolStripMenuItem.Name = "mallİKthimitToolStripMenuItem";
            this.mallİKthimitToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.mallİKthimitToolStripMenuItem.Text = "Mall i Kthimit";
            this.mallİKthimitToolStripMenuItem.Click += new System.EventHandler(this.mallİKthimitToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::Yaprak_Stok_Takip.Properties.Resources.Kasa_Odeme32x32;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.çıkışToolStripMenuItem.Text = "Dalje";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(630, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 53);
            this.label5.TabIndex = 124;
            this.label5.Text = "Total >>";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(630, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 53);
            this.label6.TabIndex = 125;
            this.label6.Text = "Kusuri >>";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ttoplam
            // 
            this.ttoplam.AutoSize = true;
            this.ttoplam.Font = new System.Drawing.Font("Montserrat", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttoplam.ForeColor = System.Drawing.Color.Red;
            this.ttoplam.Location = new System.Drawing.Point(1274, 283);
            this.ttoplam.Name = "ttoplam";
            this.ttoplam.Size = new System.Drawing.Size(129, 53);
            this.ttoplam.TabIndex = 126;
            this.ttoplam.Text = "0.00";
            this.ttoplam.Click += new System.EventHandler(this.label7_Click);
            // 
            // tparaustu
            // 
            this.tparaustu.AutoSize = true;
            this.tparaustu.Font = new System.Drawing.Font("Montserrat", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tparaustu.ForeColor = System.Drawing.Color.Blue;
            this.tparaustu.Location = new System.Drawing.Point(1274, 369);
            this.tparaustu.Name = "tparaustu";
            this.tparaustu.Size = new System.Drawing.Size(129, 53);
            this.tparaustu.TabIndex = 128;
            this.tparaustu.Text = "0.00";
            this.tparaustu.Click += new System.EventHandler(this.label12_Click);
            // 
            // verilentxt
            // 
            this.verilentxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verilentxt.Location = new System.Drawing.Point(1209, 150);
            this.verilentxt.Name = "verilentxt";
            this.verilentxt.Size = new System.Drawing.Size(245, 38);
            this.verilentxt.TabIndex = 130;
            this.verilentxt.Text = "0";
            this.verilentxt.TextChanged += new System.EventHandler(this.verilentxt_TextChanged);
            this.verilentxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verilentxt_KeyPress);
            this.verilentxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.verilentxt_PreviewKeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1217, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 34);
            this.label13.TabIndex = 131;
            this.label13.Text = "Kesh";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Siparis_Onaylanan32x32.png");
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "e Paguar",
            "Borxhi"});
            this.comboBox1.Location = new System.Drawing.Point(1076, 489);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 37);
            this.comboBox1.TabIndex = 133;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "Siparis_Onaylanan32x32.png";
            this.button5.ImageList = this.ımageList2;
            this.button5.Location = new System.Drawing.Point(1439, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 74);
            this.button5.TabIndex = 132;
            this.button5.Text = "Shitje Kupon\r\n Printo\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 568);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(548, 37);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            this.comboBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBox2_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 969);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.verilentxt);
            this.Controls.Add(this.tparaustu);
            this.Controls.Add(this.ttoplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beki Trade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftalıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yıllıkToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ttoplam;
        private System.Windows.Forms.Label tparaustu;
        private System.Windows.Forms.TextBox verilentxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistrimiİMallitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malliİRiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malliRegjistrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem mallİKthimitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn njesia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbetja;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn qmimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

