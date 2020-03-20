namespace SOHTSFormm.FormTasarimlari
{
    partial class UCHastaIslemleri
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHastaIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbason = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.labeltoplamtutar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.cboncekiislemler = new System.Windows.Forms.ComboBox();
            this.dateTimePickersevktarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.btngit = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.txtkurumadi = new System.Windows.Forms.TextBox();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudbirimfiyat = new System.Windows.Forms.NumericUpDown();
            this.nudmiktar = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btkEkle = new System.Windows.Forms.Button();
            this.cbdrkod = new System.Windows.Forms.ComboBox();
            this.cbyapilanislm = new System.Windows.Forms.ComboBox();
            this.cbpoli = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsirano = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudbirimfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 572);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnbason);
            this.groupBox4.Controls.Add(this.btnYazdir);
            this.groupBox4.Controls.Add(this.btnTaburcu);
            this.groupBox4.Controls.Add(this.btnSecSil);
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.labeltoplamtutar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(20, 509);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 58);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnbason
            // 
            this.btnbason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbason.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnbason.Location = new System.Drawing.Point(588, 10);
            this.btnbason.Name = "btnbason";
            this.btnbason.Size = new System.Drawing.Size(65, 43);
            this.btnbason.TabIndex = 1;
            this.btnbason.Text = "Baskı Önizleme";
            this.btnbason.UseVisualStyleBackColor = true;
            this.btnbason.Click += new System.EventHandler(this.btnbason_Click_1);
            // 
            // btnYazdir
            // 
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnYazdir.Location = new System.Drawing.Point(515, 10);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(65, 43);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click_1);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaburcu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTaburcu.Location = new System.Drawing.Point(443, 10);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(65, 43);
            this.btnTaburcu.TabIndex = 1;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = true;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click_1);
            // 
            // btnSecSil
            // 
            this.btnSecSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecSil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSecSil.Location = new System.Drawing.Point(371, 10);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(65, 43);
            this.btnSecSil.TabIndex = 1;
            this.btnSecSil.Text = "Seç-Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnYeni.Location = new System.Drawing.Point(299, 10);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(65, 43);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(138, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "₺";
            // 
            // labeltoplamtutar
            // 
            this.labeltoplamtutar.AutoSize = true;
            this.labeltoplamtutar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltoplamtutar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labeltoplamtutar.Location = new System.Drawing.Point(110, 25);
            this.labeltoplamtutar.Name = "labeltoplamtutar";
            this.labeltoplamtutar.Size = new System.Drawing.Size(16, 16);
            this.labeltoplamtutar.TabIndex = 0;
            this.labeltoplamtutar.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(10, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Toplam Tutar : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtDosyaNo);
            this.groupBox3.Controls.Add(this.cboncekiislemler);
            this.groupBox3.Controls.Add(this.dateTimePickersevktarihi);
            this.groupBox3.Controls.Add(this.btnHastaBilgileri);
            this.groupBox3.Controls.Add(this.btngit);
            this.groupBox3.Controls.Add(this.btnbul);
            this.groupBox3.Controls.Add(this.txtkurumadi);
            this.groupBox3.Controls.Add(this.txthastasoyad);
            this.groupBox3.Controls.Add(this.txthastaad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // mtxtDosyaNo
            // 
            this.mtxtDosyaNo.Location = new System.Drawing.Point(105, 9);
            this.mtxtDosyaNo.Mask = "00000";
            this.mtxtDosyaNo.Name = "mtxtDosyaNo";
            this.mtxtDosyaNo.Size = new System.Drawing.Size(100, 20);
            this.mtxtDosyaNo.TabIndex = 50;
            this.mtxtDosyaNo.ValidatingType = typeof(int);
            this.mtxtDosyaNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDosyaNo_MaskInputRejected);
            this.mtxtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtDosyaNo_KeyDown);
            this.mtxtDosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDosyaNo_KeyPress);
            // 
            // cboncekiislemler
            // 
            this.cboncekiislemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboncekiislemler.FormattingEnabled = true;
            this.cboncekiislemler.Location = new System.Drawing.Point(105, 70);
            this.cboncekiislemler.Name = "cboncekiislemler";
            this.cboncekiislemler.Size = new System.Drawing.Size(101, 21);
            this.cboncekiislemler.TabIndex = 19;
            this.cboncekiislemler.SelectedIndexChanged += new System.EventHandler(this.cboncekiislemler_SelectedIndexChanged);
            // 
            // dateTimePickersevktarihi
            // 
            this.dateTimePickersevktarihi.Location = new System.Drawing.Point(105, 39);
            this.dateTimePickersevktarihi.Name = "dateTimePickersevktarihi";
            this.dateTimePickersevktarihi.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickersevktarihi.TabIndex = 18;
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaBilgileri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHastaBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaBilgileri.Image")));
            this.btnHastaBilgileri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaBilgileri.Location = new System.Drawing.Point(516, 11);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Padding = new System.Windows.Forms.Padding(15, 5, 15, 0);
            this.btnHastaBilgileri.Size = new System.Drawing.Size(140, 79);
            this.btnHastaBilgileri.TabIndex = 15;
            this.btnHastaBilgileri.Text = "HASTA BİLGİLERİ";
            this.btnHastaBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click_1);
            // 
            // btngit
            // 
            this.btngit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btngit.Location = new System.Drawing.Point(212, 70);
            this.btngit.Name = "btngit";
            this.btngit.Size = new System.Drawing.Size(50, 20);
            this.btngit.TabIndex = 16;
            this.btngit.Text = "GİT";
            this.btngit.UseVisualStyleBackColor = true;
            this.btngit.Click += new System.EventHandler(this.btngit_Click_1);
            // 
            // btnbul
            // 
            this.btnbul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnbul.Location = new System.Drawing.Point(212, 9);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(50, 20);
            this.btnbul.TabIndex = 17;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click_1);
            // 
            // txtkurumadi
            // 
            this.txtkurumadi.BackColor = System.Drawing.SystemColors.Window;
            this.txtkurumadi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtkurumadi.Location = new System.Drawing.Point(343, 70);
            this.txtkurumadi.Name = "txtkurumadi";
            this.txtkurumadi.Size = new System.Drawing.Size(157, 20);
            this.txtkurumadi.TabIndex = 11;
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.BackColor = System.Drawing.SystemColors.Window;
            this.txthastasoyad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txthastasoyad.Location = new System.Drawing.Point(343, 39);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(157, 20);
            this.txthastasoyad.TabIndex = 12;
            // 
            // txthastaad
            // 
            this.txthastaad.BackColor = System.Drawing.SystemColors.Window;
            this.txthastaad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txthastaad.Location = new System.Drawing.Point(343, 11);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(157, 20);
            this.txthastaad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(290, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(269, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kurum Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Önceki İşlemler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(272, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dosya No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(20, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 320);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılan Tahlil Ve İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudbirimfiyat);
            this.groupBox1.Controls.Add(this.nudmiktar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btkEkle);
            this.groupBox1.Controls.Add(this.cbdrkod);
            this.groupBox1.Controls.Add(this.cbyapilanislm);
            this.groupBox1.Controls.Add(this.cbpoli);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtsirano);
            this.groupBox1.Location = new System.Drawing.Point(20, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // nudbirimfiyat
            // 
            this.nudbirimfiyat.Enabled = false;
            this.nudbirimfiyat.Location = new System.Drawing.Point(426, 35);
            this.nudbirimfiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudbirimfiyat.Name = "nudbirimfiyat";
            this.nudbirimfiyat.Size = new System.Drawing.Size(71, 20);
            this.nudbirimfiyat.TabIndex = 5;
            // 
            // nudmiktar
            // 
            this.nudmiktar.Location = new System.Drawing.Point(353, 35);
            this.nudmiktar.Name = "nudmiktar";
            this.nudmiktar.Size = new System.Drawing.Size(67, 20);
            this.nudmiktar.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(425, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Birim Fiyat";
            // 
            // btkEkle
            // 
            this.btkEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btkEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btkEkle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btkEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btkEkle.Location = new System.Drawing.Point(516, 12);
            this.btkEkle.Name = "btkEkle";
            this.btkEkle.Padding = new System.Windows.Forms.Padding(15, 5, 15, 0);
            this.btkEkle.Size = new System.Drawing.Size(140, 45);
            this.btkEkle.TabIndex = 2;
            this.btkEkle.Text = "EKLE";
            this.btkEkle.UseVisualStyleBackColor = true;
            this.btkEkle.Click += new System.EventHandler(this.btkEkle_Click_1);
            // 
            // cbdrkod
            // 
            this.cbdrkod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdrkod.FormattingEnabled = true;
            this.cbdrkod.Location = new System.Drawing.Point(261, 35);
            this.cbdrkod.Name = "cbdrkod";
            this.cbdrkod.Size = new System.Drawing.Size(86, 21);
            this.cbdrkod.TabIndex = 4;
            // 
            // cbyapilanislm
            // 
            this.cbyapilanislm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbyapilanislm.FormattingEnabled = true;
            this.cbyapilanislm.Location = new System.Drawing.Point(160, 35);
            this.cbyapilanislm.Name = "cbyapilanislm";
            this.cbyapilanislm.Size = new System.Drawing.Size(95, 21);
            this.cbyapilanislm.TabIndex = 4;
            this.cbyapilanislm.SelectedIndexChanged += new System.EventHandler(this.cbyapilanislm_SelectedIndexChanged);
            // 
            // cbpoli
            // 
            this.cbpoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpoli.FormattingEnabled = true;
            this.cbpoli.Location = new System.Drawing.Point(6, 35);
            this.cbpoli.Name = "cbpoli";
            this.cbpoli.Size = new System.Drawing.Size(75, 21);
            this.cbpoli.TabIndex = 4;
            this.cbpoli.SelectedIndexChanged += new System.EventHandler(this.cbpoli_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(264, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doktor Kodu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(165, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yapılan İşlem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(365, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Miktar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(96, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sıra No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Poliklinik";
            // 
            // txtsirano
            // 
            this.txtsirano.BackColor = System.Drawing.SystemColors.Window;
            this.txtsirano.Enabled = false;
            this.txtsirano.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtsirano.Location = new System.Drawing.Point(87, 35);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(67, 20);
            this.txtsirano.TabIndex = 1;
            this.txtsirano.TextChanged += new System.EventHandler(this.txtsirano_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 3);
            this.panel2.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UCHastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCHastaIslemleri";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCHastaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudbirimfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmiktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnbason;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labeltoplamtutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboncekiislemler;
        private System.Windows.Forms.DateTimePicker dateTimePickersevktarihi;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Button btngit;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox txtkurumadi;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudbirimfiyat;
        private System.Windows.Forms.NumericUpDown nudmiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btkEkle;
        private System.Windows.Forms.ComboBox cbdrkod;
        private System.Windows.Forms.ComboBox cbyapilanislm;
        private System.Windows.Forms.ComboBox cbpoli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsirano;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtxtDosyaNo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
