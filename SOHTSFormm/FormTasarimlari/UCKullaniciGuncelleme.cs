using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessL.UnitOfWork;
using DataAccessL.DBContext;
using System.Threading;

namespace SOHTSFormm.FormTasarimlari
{
    public partial class UCKullaniciGuncelleme : UserControl
    {
        public UCKullaniciGuncelleme()
        {
            InitializeComponent();
        }
        UnitOfWork u = new UnitOfWork(new SOHTSContext());

        public void error()
        {
            System.Media.SystemSounds.Hand.Play();
            for (int i = 0; i < 10; i++)
            {

                this.Left -= 5;
                this.Top -= 5;
                Thread.Sleep(10);
                this.Top += 5;
                this.Left += 5;

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            try
            {
                var kullanici = u.KullaniciRepository.GetById(UCKullaniciTanitma.KullaniciId);

                kullanici.PersonelKodu = Convert.ToInt32(mtxtKullaniciKod.Text);
                kullanici.TCKimlik = mtxttc.Text;
                kullanici.Yetki = checkBoxYetkili.Checked;
                kullanici.BabaAdi = textBoxBabaAd.Text;
                kullanici.AnneAdi = textBoxAnneAd.Text;
                kullanici.Telefon = mtxttel.Text;
                kullanici.KanGrubu = cbkangrubu.SelectedItem.ToString();
                kullanici.Unvan = cbUnan.SelectedItem.ToString();
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Maas = numericUpDown1.Value;
                kullanici.IseBaslamaTarihi = ddpIseBaslama.Value;
                kullanici.DogumTarihi = dtpDogumTarihi.Value;
                kullanici.DogumYeri = textBoxDogumYeri.Text;
                kullanici.Cinsiyet = cbcinsiyet.SelectedItem.ToString();
                kullanici.MedeniHal = cbmedenihal.SelectedItem.ToString();
                kullanici.Adres = txtAdres.Text;
                kullanici.KullaniciAdi = textBoxKullaniciAd.Text;
                kullanici.Sifre = txtSifre.Text;
                u.Complate();
                MessageBox.Show("Kullanici Basari ile Güncellendi");
            }
            catch
            {
                error();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                u.KullaniciRepository.Remove(Convert.ToInt32(mtxtKullaniciKod.Text));

                u.Complate();
                MessageBox.Show("Kullanici Basari ile Silindi");
            }
            catch
            {
                error();
            }

            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void UCKullaniciGuncelleme_Load(object sender, EventArgs e)
        {
            try
            {
                cbUnan.Items.Add("Doktor");
                cbUnan.Items.Add("Hemşire");
                cbUnan.Items.Add("Memur");
                cbUnan.Items.Add("Tekniker");
                cbcinsiyet.Items.Add("Erkek");
                cbcinsiyet.Items.Add("Kadın");
                cbkangrubu.Items.Add("AB RH+");
                cbkangrubu.Items.Add("AB RH-");
                cbkangrubu.Items.Add("A RH+");
                cbkangrubu.Items.Add("A RH-");
                cbkangrubu.Items.Add("B RH+");
                cbkangrubu.Items.Add("B RH-");
                cbkangrubu.Items.Add("0 RH+");
                cbkangrubu.Items.Add("0 RH-");
                cbmedenihal.Items.Add("Evli");
                cbmedenihal.Items.Add("Bekar");


                var kullanici = u.KullaniciRepository.GetKullanici(UCKullaniciTanitma.KullaniciId);
                mtxtKullaniciKod.Text = kullanici.PersonelKodu.ToString();
                mtxttc.Text = kullanici.TCKimlik;
                checkBoxYetkili.Checked = kullanici.Yetki;
                textBoxBabaAd.Text = kullanici.BabaAdi;
                textBoxAnneAd.Text = kullanici.AnneAdi;
                mtxttel.Text = kullanici.Telefon;
                cbkangrubu.SelectedItem = kullanici.KanGrubu;
                cbUnan.SelectedItem = kullanici.Unvan;
                txtAd.Text = kullanici.Ad;
                txtSoyad.Text = kullanici.Soyad;
                numericUpDown1.Value = kullanici.Maas;
                ddpIseBaslama.Value = kullanici.IseBaslamaTarihi;
                dtpDogumTarihi.Value = kullanici.DogumTarihi;
                cbcinsiyet.SelectedItem = kullanici.Cinsiyet;
                cbmedenihal.SelectedItem = kullanici.MedeniHal;
                txtAdres.Text = kullanici.Adres;
                textBoxKullaniciAd.Text = kullanici.KullaniciAdi;
                txtSifre.Text = kullanici.Sifre;
                textBoxDogumYeri.Text = kullanici.DogumYeri;
            }
            catch
            {
                error();
            }

            

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
