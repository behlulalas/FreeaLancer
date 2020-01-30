namespace Yaprak_Stok_Takip
{
    partial class frmguncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmguncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.Label();
            this.ilacadet = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.ilacadi = new System.Windows.Forms.Label();
            this.txtilacadi = new System.Windows.Forms.TextBox();
            this.barkod = new System.Windows.Forms.Label();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.blerje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "No";
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtno.Location = new System.Drawing.Point(204, 59);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(61, 30);
            this.txtno.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 328);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1584, 544);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(989, 74);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(120, 30);
            this.txtfiyat.TabIndex = 25;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.Location = new System.Drawing.Point(1018, 54);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(52, 17);
            this.fiyat.TabIndex = 31;
            this.fiyat.Text = "Qmimi";
            // 
            // ilacadet
            // 
            this.ilacadet.AutoSize = true;
            this.ilacadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacadet.Location = new System.Drawing.Point(1022, 182);
            this.ilacadet.Name = "ilacadet";
            this.ilacadet.Size = new System.Drawing.Size(48, 17);
            this.ilacadet.TabIndex = 30;
            this.ilacadet.Text = "Sasia";
            // 
            // txtadet
            // 
            this.txtadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadet.Location = new System.Drawing.Point(989, 202);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(120, 30);
            this.txtadet.TabIndex = 26;
            // 
            // ilacadi
            // 
            this.ilacadi.AutoSize = true;
            this.ilacadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacadi.Location = new System.Drawing.Point(686, 119);
            this.ilacadi.Name = "ilacadi";
            this.ilacadi.Size = new System.Drawing.Size(40, 17);
            this.ilacadi.TabIndex = 29;
            this.ilacadi.Text = "Emri";
            // 
            // txtilacadi
            // 
            this.txtilacadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilacadi.Location = new System.Drawing.Point(459, 139);
            this.txtilacadi.Name = "txtilacadi";
            this.txtilacadi.Size = new System.Drawing.Size(461, 30);
            this.txtilacadi.TabIndex = 24;
            // 
            // barkod
            // 
            this.barkod.AutoSize = true;
            this.barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkod.Location = new System.Drawing.Point(672, 54);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(68, 17);
            this.barkod.TabIndex = 28;
            this.barkod.Text = "Barcode";
            // 
            // txtbarkod
            // 
            this.txtbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkod.Location = new System.Drawing.Point(459, 74);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(461, 30);
            this.txtbarkod.TabIndex = 23;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Fatura_Alis.ico");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "Fatura_Alis.ico";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(813, 255);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(181, 54);
            this.button1.TabIndex = 27;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(248, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Barcode";
            // 
            // aratxt
            // 
            this.aratxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aratxt.Location = new System.Drawing.Point(90, 255);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(416, 30);
            this.aratxt.TabIndex = 35;
            this.aratxt.TextChanged += new System.EventHandler(this.aratxt_TextChanged);
            // 
            // blerje
            // 
            this.blerje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blerje.Location = new System.Drawing.Point(993, 139);
            this.blerje.Name = "blerje";
            this.blerje.Size = new System.Drawing.Size(116, 30);
            this.blerje.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1002, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Qmimi Blerjes";
            // 
            // frmguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 925);
            this.Controls.Add(this.blerje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aratxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.ilacadet);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.ilacadi);
            this.Controls.Add(this.txtilacadi);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mall i Regjistrum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label ilacadet;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label ilacadi;
        private System.Windows.Forms.TextBox txtilacadi;
        private System.Windows.Forms.Label barkod;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.TextBox blerje;
        private System.Windows.Forms.Label label3;
    }
}