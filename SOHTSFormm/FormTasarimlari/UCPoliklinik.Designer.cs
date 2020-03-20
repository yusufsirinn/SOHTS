namespace SOHTSFormm.FormTasarimlari
{
    partial class UCPoliklinik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxGecerli = new System.Windows.Forms.CheckBox();
            this.cbPoliad = new System.Windows.Forms.ComboBox();
            this.btnpoliguncelle = new System.Windows.Forms.Button();
            this.btnYenipoliekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGecerli);
            this.groupBox1.Controls.Add(this.cbPoliad);
            this.groupBox1.Controls.Add(this.btnpoliguncelle);
            this.groupBox1.Controls.Add(this.btnYenipoliekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxGecerli
            // 
            this.checkBoxGecerli.AutoSize = true;
            this.checkBoxGecerli.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGecerli.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxGecerli.Location = new System.Drawing.Point(301, 22);
            this.checkBoxGecerli.Name = "checkBoxGecerli";
            this.checkBoxGecerli.Size = new System.Drawing.Size(67, 19);
            this.checkBoxGecerli.TabIndex = 26;
            this.checkBoxGecerli.Text = "Geçerli";
            this.checkBoxGecerli.UseVisualStyleBackColor = true;
            this.checkBoxGecerli.CheckedChanged += new System.EventHandler(this.checkBoxGecerli_CheckedChanged);
            // 
            // cbPoliad
            // 
            this.cbPoliad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliad.FormattingEnabled = true;
            this.cbPoliad.Location = new System.Drawing.Point(148, 21);
            this.cbPoliad.Name = "cbPoliad";
            this.cbPoliad.Size = new System.Drawing.Size(149, 21);
            this.cbPoliad.TabIndex = 22;
            this.cbPoliad.SelectedIndexChanged += new System.EventHandler(this.cboncekiislemler_SelectedIndexChanged);
            // 
            // btnpoliguncelle
            // 
            this.btnpoliguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpoliguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpoliguncelle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnpoliguncelle.Location = new System.Drawing.Point(374, 19);
            this.btnpoliguncelle.Name = "btnpoliguncelle";
            this.btnpoliguncelle.Size = new System.Drawing.Size(126, 20);
            this.btnpoliguncelle.TabIndex = 21;
            this.btnpoliguncelle.Text = "Polikilinik Güncelle Sil";
            this.btnpoliguncelle.UseVisualStyleBackColor = true;
            this.btnpoliguncelle.Click += new System.EventHandler(this.btnpoliguncelle_Click);
            // 
            // btnYenipoliekle
            // 
            this.btnYenipoliekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenipoliekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenipoliekle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnYenipoliekle.Location = new System.Drawing.Point(506, 19);
            this.btnYenipoliekle.Name = "btnYenipoliekle";
            this.btnYenipoliekle.Size = new System.Drawing.Size(147, 20);
            this.btnYenipoliekle.TabIndex = 21;
            this.btnYenipoliekle.Text = "Yeni Polikilinik Ekle";
            this.btnYenipoliekle.UseVisualStyleBackColor = true;
            this.btnYenipoliekle.Click += new System.EventHandler(this.btnYenipoliekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(47, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Poliklinik Adı";
            // 
            // UCPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UCPoliklinik";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCPoliklinik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPoliad;
        private System.Windows.Forms.Button btnYenipoliekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxGecerli;
        private System.Windows.Forms.Button btnpoliguncelle;
    }
}
