using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessL.UnitOfWork;
using DataAccessL.DBContext;
using DomainL.Tables;

namespace SOHTSFormm
{
    public partial class FormGiriss : Form
    {

        public static string kullanici;
        public FormGiriss()
        {
            InitializeComponent();
        }

        
        private void FormGiriss_Load(object sender, EventArgs e)
        {
            //UnitOfWork w = new UnitOfWork(new SOHTSContext());
            //w.KullaniciRepository.Add(new Kullanici { Ad = "Yusuf", Soyad = "Şirin", PersonelKodu = 21, TCKimlik = "10970709776", Yetki = true, KullaniciAdi = "AdminY", Sifre = "123456", DogumTarihi = DateTime.Now.Date, IseBaslamaTarihi = DateTime.Now });
            //w.Complate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void temizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            UnitOfWork a = new UnitOfWork(new SOHTSContext());

            if (a.KullaniciRepository.IsThere(txtKullaniciAdi.Text, txtSifre.Text))
            {
                Form1 f = new Form1();
                kullanici = txtKullaniciAdi.Text;
                temizle();

                f.Show();
                this.Hide();
                a.Complate();
            }
            else
            {
                MessageBox.Show("Kullanici Adi Veya Şifre Yanlış");
            }
            
            
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
