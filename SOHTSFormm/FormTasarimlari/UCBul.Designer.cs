namespace SOHTSFormm.FormTasarimlari
{
    partial class UCBul
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxVe = new System.Windows.Forms.CheckBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.cbaramaKriteri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Bul";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxVe);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.btnbul);
            this.groupBox2.Controls.Add(this.cbaramaKriteri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 58);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxVe
            // 
            this.checkBoxVe.AutoSize = true;
            this.checkBoxVe.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxVe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxVe.Location = new System.Drawing.Point(370, 20);
            this.checkBoxVe.Name = "checkBoxVe";
            this.checkBoxVe.Size = new System.Drawing.Size(40, 19);
            this.checkBoxVe.TabIndex = 29;
            this.checkBoxVe.Text = "Ve";
            this.checkBoxVe.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(421, 20);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 20);
            this.txt2.TabIndex = 28;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(233, 20);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 20);
            this.txt1.TabIndex = 27;
            // 
            // btnbul
            // 
            this.btnbul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnbul.Location = new System.Drawing.Point(600, 20);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(50, 20);
            this.btnbul.TabIndex = 26;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // cbaramaKriteri
            // 
            this.cbaramaKriteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbaramaKriteri.FormattingEnabled = true;
            this.cbaramaKriteri.Location = new System.Drawing.Point(102, 20);
            this.cbaramaKriteri.Name = "cbaramaKriteri";
            this.cbaramaKriteri.Size = new System.Drawing.Size(104, 21);
            this.cbaramaKriteri.TabIndex = 25;
            this.cbaramaKriteri.SelectedIndexChanged += new System.EventHandler(this.cbaramaKriteri_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Arama Kriteri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 453);
            this.dataGridView1.TabIndex = 27;
            // 
            // UCBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCBul";
            this.Size = new System.Drawing.Size(700, 575);
            this.Load += new System.EventHandler(this.UCBul_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbaramaKriteri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox checkBoxVe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
