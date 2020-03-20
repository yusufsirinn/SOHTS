namespace SOHTSFormm.FormTasarimlari
{
    partial class UCHastaBilgileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtKurumSicilNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxttc = new System.Windows.Forms.MaskedTextBox();
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtYKurumSicilNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtyakintel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtyakinkurumad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cbmedenihal = new System.Windows.Forms.ComboBox();
            this.cbcinciyet = new System.Windows.Forms.ComboBox();
            this.cbkangrubu = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdogumyeri = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.tctad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtannead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkurumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbabaad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtDosyaNo);
            this.groupBox1.Controls.Add(this.mtxtKurumSicilNo);
            this.groupBox1.Controls.Add(this.mtxttc);
            this.groupBox1.Controls.Add(this.mtxttel);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.dtpdogumtarihi);
            this.groupBox1.Controls.Add(this.cbmedenihal);
            this.groupBox1.Controls.Add(this.cbcinciyet);
            this.groupBox1.Controls.Add(this.cbkangrubu);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdogumyeri);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.tctad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtannead);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtkurumad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbabaad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtxtDosyaNo
            // 
            this.mtxtDosyaNo.Enabled = false;
            this.mtxtDosyaNo.Location = new System.Drawing.Point(197, 19);
            this.mtxtDosyaNo.Mask = "00000";
            this.mtxtDosyaNo.Name = "mtxtDosyaNo";
            this.mtxtDosyaNo.Size = new System.Drawing.Size(125, 20);
            this.mtxtDosyaNo.TabIndex = 49;
            this.mtxtDosyaNo.ValidatingType = typeof(int);
            // 
            // mtxtKurumSicilNo
            // 
            this.mtxtKurumSicilNo.Enabled = false;
            this.mtxtKurumSicilNo.Location = new System.Drawing.Point(432, 125);
            this.mtxtKurumSicilNo.Mask = "00000";
            this.mtxtKurumSicilNo.Name = "mtxtKurumSicilNo";
            this.mtxtKurumSicilNo.Size = new System.Drawing.Size(125, 20);
            this.mtxtKurumSicilNo.TabIndex = 49;
            this.mtxtKurumSicilNo.ValidatingType = typeof(int);
            // 
            // mtxttc
            // 
            this.mtxttc.Enabled = false;
            this.mtxttc.Location = new System.Drawing.Point(432, 20);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(125, 20);
            this.mtxttc.TabIndex = 49;
            // 
            // mtxttel
            // 
            this.mtxttel.Location = new System.Drawing.Point(197, 185);
            this.mtxttel.Mask = "(999) 000-0000";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(125, 20);
            this.mtxttel.TabIndex = 49;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnGuncelle.Location = new System.Drawing.Point(447, 486);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 50);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtYKurumSicilNo);
            this.groupBox2.Controls.Add(this.mtxtyakintel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtyakinkurumad);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(67, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 103);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YAKINI";
            // 
            // mtxtYKurumSicilNo
            // 
            this.mtxtYKurumSicilNo.Enabled = false;
            this.mtxtYKurumSicilNo.Location = new System.Drawing.Point(127, 62);
            this.mtxtYKurumSicilNo.Mask = "00000";
            this.mtxtYKurumSicilNo.Name = "mtxtYKurumSicilNo";
            this.mtxtYKurumSicilNo.Size = new System.Drawing.Size(125, 22);
            this.mtxtYKurumSicilNo.TabIndex = 49;
            this.mtxtYKurumSicilNo.ValidatingType = typeof(int);
            // 
            // mtxtyakintel
            // 
            this.mtxtyakintel.Location = new System.Drawing.Point(365, 30);
            this.mtxtyakintel.Mask = "(999) 000-0000";
            this.mtxtyakintel.Name = "mtxtyakintel";
            this.mtxtyakintel.Size = new System.Drawing.Size(125, 22);
            this.mtxtyakintel.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(20, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Kurum SicilNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(44, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kurum Adı";
            // 
            // txtyakinkurumad
            // 
            this.txtyakinkurumad.Location = new System.Drawing.Point(127, 31);
            this.txtyakinkurumad.Name = "txtyakinkurumad";
            this.txtyakinkurumad.Size = new System.Drawing.Size(125, 22);
            this.txtyakinkurumad.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(298, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Telefon";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(197, 251);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(360, 67);
            this.txtadres.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label17.Location = new System.Drawing.Point(138, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Adres";
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Location = new System.Drawing.Point(432, 155);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpdogumtarihi.TabIndex = 44;
            // 
            // cbmedenihal
            // 
            this.cbmedenihal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmedenihal.FormattingEnabled = true;
            this.cbmedenihal.Location = new System.Drawing.Point(432, 215);
            this.cbmedenihal.Name = "cbmedenihal";
            this.cbmedenihal.Size = new System.Drawing.Size(125, 21);
            this.cbmedenihal.TabIndex = 42;
            // 
            // cbcinciyet
            // 
            this.cbcinciyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcinciyet.FormattingEnabled = true;
            this.cbcinciyet.Location = new System.Drawing.Point(432, 185);
            this.cbcinciyet.Name = "cbcinciyet";
            this.cbcinciyet.Size = new System.Drawing.Size(125, 21);
            this.cbcinciyet.TabIndex = 41;
            this.cbcinciyet.SelectedIndexChanged += new System.EventHandler(this.cbcinciyet_SelectedIndexChanged);
            // 
            // cbkangrubu
            // 
            this.cbkangrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkangrubu.FormattingEnabled = true;
            this.cbkangrubu.Location = new System.Drawing.Point(197, 215);
            this.cbkangrubu.Name = "cbkangrubu";
            this.cbkangrubu.Size = new System.Drawing.Size(125, 21);
            this.cbkangrubu.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label16.Location = new System.Drawing.Point(342, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Medeni Hal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(362, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Cinsiyet";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(110, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Kan Grubu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(128, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefon";
            // 
            // txtdogumyeri
            // 
            this.txtdogumyeri.Location = new System.Drawing.Point(197, 155);
            this.txtdogumyeri.Name = "txtdogumyeri";
            this.txtdogumyeri.Size = new System.Drawing.Size(125, 20);
            this.txtdogumyeri.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(332, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(103, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dogum Yeri";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(432, 49);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(125, 20);
            this.txtsoyad.TabIndex = 36;
            // 
            // tctad
            // 
            this.tctad.Location = new System.Drawing.Point(197, 49);
            this.tctad.Name = "tctad";
            this.tctad.Size = new System.Drawing.Size(125, 20);
            this.tctad.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(370, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Soyadı";
            // 
            // txtannead
            // 
            this.txtannead.Location = new System.Drawing.Point(197, 125);
            this.txtannead.Name = "txtannead";
            this.txtannead.Size = new System.Drawing.Size(125, 20);
            this.txtannead.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(152, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(325, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Kurum SicilNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(119, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Anne Adı";
            // 
            // txtkurumad
            // 
            this.txtkurumad.Location = new System.Drawing.Point(432, 94);
            this.txtkurumad.Name = "txtkurumad";
            this.txtkurumad.Size = new System.Drawing.Size(125, 20);
            this.txtkurumad.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(335, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tc Kimlik No";
            // 
            // txtbabaad
            // 
            this.txtbabaad.Location = new System.Drawing.Point(197, 95);
            this.txtbabaad.Name = "txtbabaad";
            this.txtbabaad.Size = new System.Drawing.Size(125, 20);
            this.txtbabaad.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dosya No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(349, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kurum Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(119, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Baba Adı";
            // 
            // UCHastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCHastaBilgileri";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCHastaBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.ComboBox cbmedenihal;
        private System.Windows.Forms.ComboBox cbcinciyet;
        private System.Windows.Forms.ComboBox cbkangrubu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdogumyeri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtannead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbabaad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox tctad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkurumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtyakinkurumad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox mtxttel;
        private System.Windows.Forms.MaskedTextBox mtxtyakintel;
        private System.Windows.Forms.MaskedTextBox mtxtKurumSicilNo;
        private System.Windows.Forms.MaskedTextBox mtxttc;
        private System.Windows.Forms.MaskedTextBox mtxtYKurumSicilNo;
        private System.Windows.Forms.MaskedTextBox mtxtDosyaNo;
    }
}
