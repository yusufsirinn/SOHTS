namespace SOHTSFormm.FormTasarimlari
{
    partial class UCRaporlama
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
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.radioButtonTolmus = new System.Windows.Forms.RadioButton();
            this.radioButtonHepsi = new System.Windows.Forms.RadioButton();
            this.radioButtonTolmamis = new System.Windows.Forms.RadioButton();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYazdir);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSorgula);
            this.groupBox1.Controls.Add(this.radioButtonTolmus);
            this.groupBox1.Controls.Add(this.radioButtonHepsi);
            this.groupBox1.Controls.Add(this.radioButtonTolmamis);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdir.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnYazdir.Location = new System.Drawing.Point(564, 19);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(60, 60);
            this.btnYazdir.TabIndex = 14;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnTemizle.Location = new System.Drawing.Point(498, 19);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(60, 60);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSorgula.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnSorgula.Location = new System.Drawing.Point(432, 19);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(60, 60);
            this.btnSorgula.TabIndex = 14;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // radioButtonTolmus
            // 
            this.radioButtonTolmus.AutoSize = true;
            this.radioButtonTolmus.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTolmus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.radioButtonTolmus.Location = new System.Drawing.Point(296, 14);
            this.radioButtonTolmus.Name = "radioButtonTolmus";
            this.radioButtonTolmus.Size = new System.Drawing.Size(112, 20);
            this.radioButtonTolmus.TabIndex = 13;
            this.radioButtonTolmus.TabStop = true;
            this.radioButtonTolmus.Text = "Taburcu Olmuş";
            this.radioButtonTolmus.UseVisualStyleBackColor = true;
            // 
            // radioButtonHepsi
            // 
            this.radioButtonHepsi.AutoSize = true;
            this.radioButtonHepsi.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonHepsi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.radioButtonHepsi.Location = new System.Drawing.Point(296, 64);
            this.radioButtonHepsi.Name = "radioButtonHepsi";
            this.radioButtonHepsi.Size = new System.Drawing.Size(59, 20);
            this.radioButtonHepsi.TabIndex = 13;
            this.radioButtonHepsi.TabStop = true;
            this.radioButtonHepsi.Text = "Hepsi";
            this.radioButtonHepsi.UseVisualStyleBackColor = true;
            // 
            // radioButtonTolmamis
            // 
            this.radioButtonTolmamis.AutoSize = true;
            this.radioButtonTolmamis.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTolmamis.ForeColor = System.Drawing.SystemColors.GrayText;
            this.radioButtonTolmamis.Location = new System.Drawing.Point(296, 39);
            this.radioButtonTolmamis.Name = "radioButtonTolmamis";
            this.radioButtonTolmamis.Size = new System.Drawing.Size(126, 20);
            this.radioButtonTolmamis.TabIndex = 13;
            this.radioButtonTolmamis.TabStop = true;
            this.radioButtonTolmamis.Text = "Taburcu Olmamış";
            this.radioButtonTolmamis.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(162, 54);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(105, 20);
            this.dtpBitis.TabIndex = 12;
            this.dtpBitis.Value = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(162, 29);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(105, 20);
            this.dtpBaslangic.TabIndex = 12;
            this.dtpBaslangic.Value = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(10, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 455);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // UCRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCRaporlama";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCRaporlama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.RadioButton radioButtonTolmus;
        private System.Windows.Forms.RadioButton radioButtonHepsi;
        private System.Windows.Forms.RadioButton radioButtonTolmamis;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
