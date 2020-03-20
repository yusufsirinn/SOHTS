namespace SOHTSFormm.FormTasarimlari
{
    partial class UCTaburcu
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
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(319, 198);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpCikisTarihi.TabIndex = 61;
            // 
            // dtpSevkTarihi
            // 
            this.dtpSevkTarihi.Location = new System.Drawing.Point(319, 165);
            this.dtpSevkTarihi.Name = "dtpSevkTarihi";
            this.dtpSevkTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpSevkTarihi.TabIndex = 62;
            // 
            // cbOdemeSekli
            // 
            this.cbOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeSekli.FormattingEnabled = true;
            this.cbOdemeSekli.Location = new System.Drawing.Point(319, 233);
            this.cbOdemeSekli.Name = "cbOdemeSekli";
            this.cbOdemeSekli.Size = new System.Drawing.Size(125, 21);
            this.cbOdemeSekli.TabIndex = 60;
            this.cbOdemeSekli.SelectedIndexChanged += new System.EventHandler(this.cbOdemeSekli_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(225, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Çıkış Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(225, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Sevk Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(217, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ödeme Şekli";
            // 
            // mtxtDosyaNo
            // 
            this.mtxtDosyaNo.Enabled = false;
            this.mtxtDosyaNo.Location = new System.Drawing.Point(319, 130);
            this.mtxtDosyaNo.Mask = "00000";
            this.mtxtDosyaNo.Name = "mtxtDosyaNo";
            this.mtxtDosyaNo.Size = new System.Drawing.Size(125, 20);
            this.mtxtDosyaNo.TabIndex = 65;
            this.mtxtDosyaNo.ValidatingType = typeof(int);
            this.mtxtDosyaNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDosyaNo_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(238, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dosya No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(217, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Toplam Tutar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnKaydet.Location = new System.Drawing.Point(319, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 50);
            this.btnKaydet.TabIndex = 88;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl.Location = new System.Drawing.Point(345, 271);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 16);
            this.lbl.TabIndex = 53;
            // 
            // UCTaburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtDosyaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpSevkTarihi);
            this.Controls.Add(this.cbOdemeSekli);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Name = "UCTaburcu";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCOncekiIslemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpSevkTarihi;
        private System.Windows.Forms.ComboBox cbOdemeSekli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtDosyaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lbl;
    }
}
