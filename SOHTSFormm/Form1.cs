using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessL.UnitOfWork;
using DataAccessL.DBContext;

namespace SOHTSFormm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public static string DrAd;
        private void Form1_Load(object sender, EventArgs e)
        {

            DrAd= FormGiriss.kullanici;
            labelKullanici.Text = DrAd;
            panel4.Height = 70;
            panel2.Height = 70;
            panel5.Height = 70;
            panelhareketli.Height = 0;

            UnitOfWork f = new UnitOfWork(new SOHTSContext());

            //if (f.KullaniciRepository.Authorized(kullaniciAd))
            //{
            //    btnreferanslar.Enabled = true;
            //    btnreferanslar.Visible = true;
            //}
            //else
            //{
            //    btnreferanslar.Enabled = false;
            //    btnreferanslar.Visible = false;
            //}
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelasil1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreferanslar_Click(object sender, EventArgs e)
        {
            panel4.Height = 175;
            panel2.Height = 70;
            panel5.Height = 70;

            panelhareketli.Location = new Point(0, 160);//100
            panelhareketli.Height = 70;

        }

        private void btnpolitanit_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 235);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCPoliklinik());
        }

        private void btnkullanicitanit_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 270);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCKullaniciTanitma());
        }

        private void btnhastakabul_Click(object sender, EventArgs e)
        {
            panel4.Height = 70;
            panel2.Height = 140;
            panel5.Height = 70;

            panelhareketli.Location = new Point(0, 230);
            panelhareketli.Height = 70;
        }

        private void btnhastaislemleri_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 305);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCHastaIslemleri());
        }

        private void btnHastaYeni_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 340);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCYeniHasta());
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            panel4.Height = 70;
            panel2.Height = 70;
            panel5.Height = 140;

            panelhareketli.Location = new Point(0, 300);
            panelhareketli.Height = 70;
        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 375);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCRaporlama());
        }

        private void btncikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormGiriss fg = new FormGiriss();
            fg.Show();
            this.Hide();
            
        }

        private void anapanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            panelhareketli.Location = new Point(0, 305);
            panelhareketli.Height = 30;

            anapanel.Controls.Clear();
            anapanel.Controls.Add(new FormTasarimlari.UCIslemEkle());
        }
    }
}
