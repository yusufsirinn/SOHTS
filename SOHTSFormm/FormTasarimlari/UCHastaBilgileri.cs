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
    public partial class UCHastaBilgileri : UserControl
    {
        public UCHastaBilgileri()
        {
            InitializeComponent();
        }
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        UnitOfWork u = new UnitOfWork(new SOHTSContext());
        private void UCHastaBilgileri_Load(object sender, EventArgs e)
        {
            mtxtDosyaNo.Text = FormTasarimlari.UCHastaIslemleri.dosyano;

            cbcinciyet.Items.Add("Erkek");
            cbcinciyet.Items.Add("Kadın");
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

            var hastabilgi= u.HastaRepository.GetFileNo(UCHastaIslemleri.formDosyaNo);
            mtxtDosyaNo.Text = hastabilgi.DosyaNo.ToString();
            tctad.Text = hastabilgi.Ad;
            txtbabaad.Text = hastabilgi.BabaAdi;
            txtannead.Text = hastabilgi.AnneAdi;
            dtpdogumtarihi.Value = hastabilgi.DogumTarihi;
            txtdogumyeri.Text = hastabilgi.DogumYeri;
            mtxttel.Text = hastabilgi.Telefon;
            cbkangrubu.SelectedItem = hastabilgi.KanGrubu;
            mtxttc.Text = hastabilgi.TCKimlik;
            txtsoyad.Text = hastabilgi.Soyad;
            mtxtKurumSicilNo.Text = hastabilgi.KurumSicilNo.ToString();
            dtpdogumtarihi.Value = hastabilgi.DogumTarihi;
            cbcinciyet.SelectedItem = hastabilgi.Cinsiyet;
            cbmedenihal.SelectedItem = hastabilgi.MedeniHal;
            txtadres.Text = hastabilgi.Adres;
            txtyakinkurumad.Text = hastabilgi.YakinKurumAdi;
            mtxtyakintel.Text = hastabilgi.YakinTelefon;
            mtxtYKurumSicilNo.Text = hastabilgi.YakinKurumSicilNo.ToString();


        }

        private void cbcinciyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(mtxtDosyaNo.Text);
                var hastabilgi = u.HastaRepository.GetById(id);

                hastabilgi.DosyaNo = Convert.ToInt32(mtxtDosyaNo.Text);
                hastabilgi.Ad = tctad.Text;
                hastabilgi.BabaAdi = txtbabaad.Text;
                hastabilgi.AnneAdi = txtannead.Text;
                hastabilgi.DogumTarihi = dtpdogumtarihi.Value;
                hastabilgi.DogumYeri = txtdogumyeri.Text;
                hastabilgi.Telefon = mtxttel.Text;
                hastabilgi.KanGrubu = cbkangrubu.SelectedItem.ToString();
                hastabilgi.TCKimlik = mtxttc.Text;
                hastabilgi.Soyad = txtsoyad.Text;
                hastabilgi.KurumSicilNo = Convert.ToInt32(mtxtKurumSicilNo.Text);
                hastabilgi.DogumTarihi = dtpdogumtarihi.Value;
                hastabilgi.Cinsiyet = cbcinciyet.SelectedItem.ToString();
                hastabilgi.MedeniHal = cbmedenihal.SelectedItem.ToString();
                hastabilgi.Adres = txtadres.Text;
                hastabilgi.YakinKurumAdi = txtyakinkurumad.Text;
                hastabilgi.YakinTelefon = mtxtyakintel.Text;
                hastabilgi.YakinKurumSicilNo = Convert.ToInt32(mtxtYKurumSicilNo.Text);
                u.Complate();
            }
            catch
            {
                error();
            }


            
        }
    }
}
