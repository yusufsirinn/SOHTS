namespace SOHTSFormm.FormTasarimlari
{
    partial class UCKullaniciGuncelleme
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
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.checkBoxYetkili = new System.Windows.Forms.CheckBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.ddpIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.cbmedenihal = new System.Windows.Forms.ComboBox();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.cbkangrubu = new System.Windows.Forms.ComboBox();
            this.cbUnan = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.textBoxDogumYeri = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAnneAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBabaAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxttc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtKullaniciKod = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxttel
            // 
            this.mtxttel.Location = new System.Drawing.Point(223, 174);
            this.mtxttel.Mask = "(999) 000-0000";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(125, 20);
            this.mtxttel.TabIndex = 90;
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSil.Location = new System.Drawing.Point(473, 426);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 50);
            this.btnSil.TabIndex = 88;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnGuncelle.Location = new System.Drawing.Point(349, 426);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 50);
            this.btnGuncelle.TabIndex = 87;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // checkBoxYetkili
            // 
            this.checkBoxYetkili.AutoSize = true;
            this.checkBoxYetkili.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxYetkili.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxYetkili.Location = new System.Drawing.Point(223, 85);
            this.checkBoxYetkili.Name = "checkBoxYetkili";
            this.checkBoxYetkili.Size = new System.Drawing.Size(131, 19);
            this.checkBoxYetkili.TabIndex = 86;
            this.checkBoxYetkili.Text = "   Yetkili Kullanıcı";
            this.checkBoxYetkili.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(458, 174);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpDogumTarihi.TabIndex = 84;
            // 
            // ddpIseBaslama
            // 
            this.ddpIseBaslama.Location = new System.Drawing.Point(458, 144);
            this.ddpIseBaslama.Name = "ddpIseBaslama";
            this.ddpIseBaslama.Size = new System.Drawing.Size(125, 20);
            this.ddpIseBaslama.TabIndex = 85;
            // 
            // cbmedenihal
            // 
            this.cbmedenihal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmedenihal.FormattingEnabled = true;
            this.cbmedenihal.Location = new System.Drawing.Point(458, 234);
            this.cbmedenihal.Name = "cbmedenihal";
            this.cbmedenihal.Size = new System.Drawing.Size(125, 21);
            this.cbmedenihal.TabIndex = 83;
            // 
            // cbcinsiyet
            // 
            this.cbcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Location = new System.Drawing.Point(458, 204);
            this.cbcinsiyet.Name = "cbcinsiyet";
            this.cbcinsiyet.Size = new System.Drawing.Size(125, 21);
            this.cbcinsiyet.TabIndex = 80;
            // 
            // cbkangrubu
            // 
            this.cbkangrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkangrubu.FormattingEnabled = true;
            this.cbkangrubu.Location = new System.Drawing.Point(223, 234);
            this.cbkangrubu.Name = "cbkangrubu";
            this.cbkangrubu.Size = new System.Drawing.Size(125, 21);
            this.cbkangrubu.TabIndex = 81;
            // 
            // cbUnan
            // 
            this.cbUnan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnan.FormattingEnabled = true;
            this.cbUnan.Location = new System.Drawing.Point(458, 24);
            this.cbUnan.Name = "cbUnan";
            this.cbUnan.Size = new System.Drawing.Size(125, 21);
            this.cbUnan.TabIndex = 82;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(223, 308);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(360, 67);
            this.txtAdres.TabIndex = 77;
            // 
            // textBoxDogumYeri
            // 
            this.textBoxDogumYeri.Location = new System.Drawing.Point(223, 204);
            this.textBoxDogumYeri.Name = "textBoxDogumYeri";
            this.textBoxDogumYeri.Size = new System.Drawing.Size(125, 20);
            this.textBoxDogumYeri.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label16.Location = new System.Drawing.Point(368, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 67;
            this.label16.Text = "Medeni Hal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(388, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 68;
            this.label14.Text = "Cinsiyet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(164, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 16);
            this.label17.TabIndex = 65;
            this.label17.Text = "Adres";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(136, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 64;
            this.label15.Text = "Kan Grubu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(129, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Dogum Yeri";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(358, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(134, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Telefon No";
            // 
            // textBoxAnneAd
            // 
            this.textBoxAnneAd.Location = new System.Drawing.Point(223, 144);
            this.textBoxAnneAd.Name = "textBoxAnneAd";
            this.textBoxAnneAd.Size = new System.Drawing.Size(125, 20);
            this.textBoxAnneAd.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(365, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 60;
            this.label12.Text = "İşe Başlama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(145, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Anne Adı";
            // 
            // textBoxBabaAd
            // 
            this.textBoxBabaAd.Location = new System.Drawing.Point(223, 114);
            this.textBoxBabaAd.Name = "textBoxBabaAd";
            this.textBoxBabaAd.Size = new System.Drawing.Size(125, 20);
            this.textBoxBabaAd.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(404, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(145, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Baba Adı";
            // 
            // textBoxKullaniciAd
            // 
            this.textBoxKullaniciAd.Location = new System.Drawing.Point(223, 390);
            this.textBoxKullaniciAd.Name = "textBoxKullaniciAd";
            this.textBoxKullaniciAd.Size = new System.Drawing.Size(125, 20);
            this.textBoxKullaniciAd.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(406, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(122, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(458, 390);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 20);
            this.txtSifre.TabIndex = 69;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(458, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtSoyad.TabIndex = 74;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(458, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 20);
            this.txtAd.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(400, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 54;
            this.label18.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(420, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tc Kimlik Numrası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(400, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Unvan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(112, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kullanıcı Kodu";
            // 
            // mtxttc
            // 
            this.mtxttc.Enabled = false;
            this.mtxttc.Location = new System.Drawing.Point(223, 54);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(125, 20);
            this.mtxttc.TabIndex = 91;
            // 
            // mtxtKullaniciKod
            // 
            this.mtxtKullaniciKod.Enabled = false;
            this.mtxtKullaniciKod.Location = new System.Drawing.Point(223, 25);
            this.mtxtKullaniciKod.Mask = "00000";
            this.mtxtKullaniciKod.Name = "mtxtKullaniciKod";
            this.mtxtKullaniciKod.Size = new System.Drawing.Size(125, 20);
            this.mtxtKullaniciKod.TabIndex = 91;
            this.mtxtKullaniciKod.ValidatingType = typeof(int);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(458, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown1.TabIndex = 92;
            // 
            // UCKullaniciGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.mtxtKullaniciKod);
            this.Controls.Add(this.mtxttc);
            this.Controls.Add(this.mtxttel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.checkBoxYetkili);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.ddpIseBaslama);
            this.Controls.Add(this.cbmedenihal);
            this.Controls.Add(this.cbcinsiyet);
            this.Controls.Add(this.cbkangrubu);
            this.Controls.Add(this.cbUnan);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.textBoxDogumYeri);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAnneAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBabaAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKullaniciAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Name = "UCKullaniciGuncelleme";
            this.Size = new System.Drawing.Size(674, 500);
            this.Load += new System.EventHandler(this.UCKullaniciGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxttel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox checkBoxYetkili;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.DateTimePicker ddpIseBaslama;
        private System.Windows.Forms.ComboBox cbmedenihal;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.ComboBox cbkangrubu;
        private System.Windows.Forms.ComboBox cbUnan;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox textBoxDogumYeri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAnneAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBabaAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKullaniciAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxttc;
        private System.Windows.Forms.MaskedTextBox mtxtKullaniciKod;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
