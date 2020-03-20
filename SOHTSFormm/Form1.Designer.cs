namespace SOHTSFormm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.anapanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnrapor = new System.Windows.Forms.Button();
            this.btnraporlar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHastaYeni = new System.Windows.Forms.Button();
            this.btnhastaislemleri = new System.Windows.Forms.Button();
            this.btnhastakabul = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnkullanicitanit = new System.Windows.Forms.Button();
            this.btnpolitanit = new System.Windows.Forms.Button();
            this.btnreferanslar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelhareketli = new System.Windows.Forms.Panel();
            this.panelust = new System.Windows.Forms.Panel();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnIslem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelust.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // anapanel
            // 
            this.anapanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.anapanel.Location = new System.Drawing.Point(200, 25);
            this.anapanel.Name = "anapanel";
            this.anapanel.Size = new System.Drawing.Size(700, 575);
            this.anapanel.TabIndex = 13;
            this.anapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.anapanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 575);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btncikis);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 493);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 82);
            this.panel6.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btncikis
            // 
            this.btncikis.FlatAppearance.BorderSize = 2;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.Location = new System.Drawing.Point(67, 23);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(45, 45);
            this.btncikis.TabIndex = 0;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnrapor);
            this.panel5.Controls.Add(this.btnraporlar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 509);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 107);
            this.panel5.TabIndex = 2;
            // 
            // btnrapor
            // 
            this.btnrapor.FlatAppearance.BorderSize = 0;
            this.btnrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrapor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrapor.ForeColor = System.Drawing.Color.White;
            this.btnrapor.Image = ((System.Drawing.Image)(resources.GetObject("btnrapor.Image")));
            this.btnrapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrapor.Location = new System.Drawing.Point(0, 0);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(198, 70);
            this.btnrapor.TabIndex = 0;
            this.btnrapor.Text = "Raporlar";
            this.btnrapor.UseVisualStyleBackColor = true;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // btnraporlar
            // 
            this.btnraporlar.FlatAppearance.BorderSize = 0;
            this.btnraporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnraporlar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnraporlar.ForeColor = System.Drawing.Color.White;
            this.btnraporlar.Image = ((System.Drawing.Image)(resources.GetObject("btnraporlar.Image")));
            this.btnraporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnraporlar.Location = new System.Drawing.Point(30, 75);
            this.btnraporlar.Name = "btnraporlar";
            this.btnraporlar.Size = new System.Drawing.Size(169, 30);
            this.btnraporlar.TabIndex = 0;
            this.btnraporlar.Text = "Raporlar";
            this.btnraporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnraporlar.UseVisualStyleBackColor = true;
            this.btnraporlar.Click += new System.EventHandler(this.btnraporlar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHastaYeni);
            this.panel2.Controls.Add(this.btnhastaislemleri);
            this.panel2.Controls.Add(this.btnhastakabul);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 138);
            this.panel2.TabIndex = 1;
            // 
            // btnHastaYeni
            // 
            this.btnHastaYeni.FlatAppearance.BorderSize = 0;
            this.btnHastaYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaYeni.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaYeni.ForeColor = System.Drawing.Color.White;
            this.btnHastaYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaYeni.Image")));
            this.btnHastaYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaYeni.Location = new System.Drawing.Point(30, 110);
            this.btnHastaYeni.Name = "btnHastaYeni";
            this.btnHastaYeni.Size = new System.Drawing.Size(169, 30);
            this.btnHastaYeni.TabIndex = 0;
            this.btnHastaYeni.Text = "Yeni Hasta";
            this.btnHastaYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHastaYeni.UseVisualStyleBackColor = true;
            this.btnHastaYeni.Click += new System.EventHandler(this.btnHastaYeni_Click);
            // 
            // btnhastaislemleri
            // 
            this.btnhastaislemleri.FlatAppearance.BorderSize = 0;
            this.btnhastaislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhastaislemleri.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastaislemleri.ForeColor = System.Drawing.Color.White;
            this.btnhastaislemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnhastaislemleri.Image")));
            this.btnhastaislemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhastaislemleri.Location = new System.Drawing.Point(30, 75);
            this.btnhastaislemleri.Name = "btnhastaislemleri";
            this.btnhastaislemleri.Size = new System.Drawing.Size(169, 30);
            this.btnhastaislemleri.TabIndex = 0;
            this.btnhastaislemleri.Text = "Hasta İşlemleri";
            this.btnhastaislemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhastaislemleri.UseVisualStyleBackColor = true;
            this.btnhastaislemleri.Click += new System.EventHandler(this.btnhastaislemleri_Click);
            // 
            // btnhastakabul
            // 
            this.btnhastakabul.FlatAppearance.BorderSize = 0;
            this.btnhastakabul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhastakabul.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhastakabul.ForeColor = System.Drawing.Color.White;
            this.btnhastakabul.Image = ((System.Drawing.Image)(resources.GetObject("btnhastakabul.Image")));
            this.btnhastakabul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhastakabul.Location = new System.Drawing.Point(0, 0);
            this.btnhastakabul.Name = "btnhastakabul";
            this.btnhastakabul.Size = new System.Drawing.Size(198, 70);
            this.btnhastakabul.TabIndex = 0;
            this.btnhastakabul.Text = "Hasta Kabul";
            this.btnhastakabul.UseVisualStyleBackColor = true;
            this.btnhastakabul.Click += new System.EventHandler(this.btnhastakabul_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnIslem);
            this.panel4.Controls.Add(this.btnkullanicitanit);
            this.panel4.Controls.Add(this.btnpolitanit);
            this.panel4.Controls.Add(this.btnreferanslar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 211);
            this.panel4.TabIndex = 1;
            // 
            // btnkullanicitanit
            // 
            this.btnkullanicitanit.FlatAppearance.BorderSize = 0;
            this.btnkullanicitanit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullanicitanit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanicitanit.ForeColor = System.Drawing.Color.White;
            this.btnkullanicitanit.Image = ((System.Drawing.Image)(resources.GetObject("btnkullanicitanit.Image")));
            this.btnkullanicitanit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullanicitanit.Location = new System.Drawing.Point(30, 110);
            this.btnkullanicitanit.Name = "btnkullanicitanit";
            this.btnkullanicitanit.Size = new System.Drawing.Size(169, 30);
            this.btnkullanicitanit.TabIndex = 0;
            this.btnkullanicitanit.Text = "Kullanıcı Tanıt";
            this.btnkullanicitanit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkullanicitanit.UseVisualStyleBackColor = true;
            this.btnkullanicitanit.Click += new System.EventHandler(this.btnkullanicitanit_Click);
            // 
            // btnpolitanit
            // 
            this.btnpolitanit.FlatAppearance.BorderSize = 0;
            this.btnpolitanit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpolitanit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpolitanit.ForeColor = System.Drawing.Color.White;
            this.btnpolitanit.Image = ((System.Drawing.Image)(resources.GetObject("btnpolitanit.Image")));
            this.btnpolitanit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpolitanit.Location = new System.Drawing.Point(30, 75);
            this.btnpolitanit.Name = "btnpolitanit";
            this.btnpolitanit.Size = new System.Drawing.Size(169, 30);
            this.btnpolitanit.TabIndex = 0;
            this.btnpolitanit.Text = "Poliklinik Tanıt";
            this.btnpolitanit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpolitanit.UseVisualStyleBackColor = true;
            this.btnpolitanit.Click += new System.EventHandler(this.btnpolitanit_Click);
            // 
            // btnreferanslar
            // 
            this.btnreferanslar.FlatAppearance.BorderSize = 0;
            this.btnreferanslar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreferanslar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreferanslar.ForeColor = System.Drawing.Color.White;
            this.btnreferanslar.Image = ((System.Drawing.Image)(resources.GetObject("btnreferanslar.Image")));
            this.btnreferanslar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreferanslar.Location = new System.Drawing.Point(0, 0);
            this.btnreferanslar.Name = "btnreferanslar";
            this.btnreferanslar.Size = new System.Drawing.Size(198, 70);
            this.btnreferanslar.TabIndex = 0;
            this.btnreferanslar.Text = "Referanslar";
            this.btnreferanslar.UseVisualStyleBackColor = true;
            this.btnreferanslar.Click += new System.EventHandler(this.btnreferanslar_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 160);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.MaximumSize = new System.Drawing.Size(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAGLIK OCAGI HASTA TAKIP SISTEMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelhareketli
            // 
            this.panelhareketli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panelhareketli.Location = new System.Drawing.Point(0, 120);
            this.panelhareketli.Name = "panelhareketli";
            this.panelhareketli.Size = new System.Drawing.Size(10, 50);
            this.panelhareketli.TabIndex = 12;
            // 
            // panelust
            // 
            this.panelust.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelust.Controls.Add(this.labelKullanici);
            this.panelust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelust.Location = new System.Drawing.Point(0, 0);
            this.panelust.Name = "panelust";
            this.panelust.Size = new System.Drawing.Size(900, 25);
            this.panelust.TabIndex = 11;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKullanici.Location = new System.Drawing.Point(753, 5);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(87, 16);
            this.labelKullanici.TabIndex = 21;
            this.labelKullanici.Text = "Poliklinik Adı";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panelhareketli);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(180, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 575);
            this.panel7.TabIndex = 14;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnIslem
            // 
            this.btnIslem.FlatAppearance.BorderSize = 0;
            this.btnIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslem.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.ForeColor = System.Drawing.Color.White;
            this.btnIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnIslem.Image")));
            this.btnIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIslem.Location = new System.Drawing.Point(30, 145);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(169, 30);
            this.btnIslem.TabIndex = 0;
            this.btnIslem.Text = "İşlem Tanıt";
            this.btnIslem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.anapanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelust.ResumeLayout(false);
            this.panelust.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel anapanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnrapor;
        private System.Windows.Forms.Button btnraporlar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHastaYeni;
        private System.Windows.Forms.Button btnhastaislemleri;
        private System.Windows.Forms.Button btnhastakabul;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnkullanicitanit;
        private System.Windows.Forms.Button btnpolitanit;
        private System.Windows.Forms.Button btnreferanslar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelhareketli;
        private System.Windows.Forms.Panel panelust;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Button btnIslem;
    }
}

