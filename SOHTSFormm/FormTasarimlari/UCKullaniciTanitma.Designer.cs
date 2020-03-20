namespace SOHTSFormm.FormTasarimlari
{
    partial class UCKullaniciTanitma
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
            this.cbKullaniciId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKullaniciGüncelleSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKullaniciId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnKullaniciGüncelleSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbKullaniciId
            // 
            this.cbKullaniciId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciId.FormattingEnabled = true;
            this.cbKullaniciId.Location = new System.Drawing.Point(208, 19);
            this.cbKullaniciId.Name = "cbKullaniciId";
            this.cbKullaniciId.Size = new System.Drawing.Size(101, 21);
            this.cbKullaniciId.TabIndex = 22;
            this.cbKullaniciId.SelectedIndexChanged += new System.EventHandler(this.cboncekiislemler_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(449, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "Yeni Kullanıcı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // btnKullaniciGüncelleSil
            // 
            this.btnKullaniciGüncelleSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKullaniciGüncelleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciGüncelleSil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnKullaniciGüncelleSil.Location = new System.Drawing.Point(315, 19);
            this.btnKullaniciGüncelleSil.Name = "btnKullaniciGüncelleSil";
            this.btnKullaniciGüncelleSil.Size = new System.Drawing.Size(128, 20);
            this.btnKullaniciGüncelleSil.TabIndex = 21;
            this.btnKullaniciGüncelleSil.Text = "Kullanıcı Güncelle Sil";
            this.btnKullaniciGüncelleSil.UseVisualStyleBackColor = true;
            this.btnKullaniciGüncelleSil.Click += new System.EventHandler(this.btnKullaniciGüncelleSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(107, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kullanıcı Kodu";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 500);
            this.panel1.TabIndex = 0;
            // 
            // UCKullaniciTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCKullaniciTanitma";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCKullaniciTanitma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbKullaniciId;
        private System.Windows.Forms.Button btnKullaniciGüncelleSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
