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
    public partial class UCKullaniciTanitmaEk : UserControl
    {
        public UCKullaniciTanitmaEk()
        {
            InitializeComponent();
        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.SelectedIndex = 0;
                }
                if (item is MaskedTextBox)
                {
                    MaskedTextBox mtxt = item as MaskedTextBox;
                    mtxt.Clear();
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nud = item as NumericUpDown;
                    nud.Value = 0;
                }

            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {

            FormuTemizle();

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
        private void UCKullaniciTanitmaEk_Load(object sender, EventArgs e)
        {

            cbUnan.Items.Add("Doktor");
            cbUnan.Items.Add("Hemşire");
            cbUnan.Items.Add("Memur");
            cbUnan.Items.Add("Tekniker");
            cbCinsiyet.Items.Add("Erkek");
            cbCinsiyet.Items.Add("Kadın");
            cbKanGrubu.Items.Add("AB RH+");
            cbKanGrubu.Items.Add("AB RH-");
            cbKanGrubu.Items.Add("A RH+");
            cbKanGrubu.Items.Add("A RH-");
            cbKanGrubu.Items.Add("B RH+");
            cbKanGrubu.Items.Add("B RH-");
            cbKanGrubu.Items.Add("0 RH+");
            cbKanGrubu.Items.Add("0 RH-");
            cbMedeniHal.Items.Add("Evli");
            cbMedeniHal.Items.Add("Bekar");

            cbUnan.SelectedIndex = 0;
            cbCinsiyet.SelectedIndex = 0;
            cbMedeniHal.SelectedIndex = 0;
            cbKanGrubu.SelectedIndex = 0;
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            
            try
            {

                UnitOfWork kullaniciekleme = new UnitOfWork(new SOHTSContext());

                if (kullaniciekleme.KullaniciRepository.IsThereId(Convert.ToInt32(mtxtKullaniciKodu.Text)))
                {
                    MessageBox.Show("Personel Kodu Mevcut");
                }
                else
                {
                    kullaniciekleme.KullaniciRepository.Add(new DomainL.Tables.Kullanici
                    {
                        PersonelKodu = Convert.ToInt32(mtxtKullaniciKodu.Text),
                        TCKimlik = mtxtTc.Text,
                        Yetki = checkBoxYetkili.Checked,

                        BabaAdi = textBoxBabaAd.Text,
                        AnneAdi = textBoxAnneAd.Text,
                        Telefon = mtxttel.Text,

                        KanGrubu = cbKanGrubu.SelectedItem.ToString(),
                        Unvan = cbUnan.SelectedItem.ToString(),
                        Ad = txtAd.Text,

                        Soyad = txtSoyad.Text,
                        Maas = Convert.ToDecimal(nupMaas.Value),
                        IseBaslamaTarihi = ddpIseBaslama.Value,

                        DogumTarihi = dtpDogumTarihi.Value,
                        Cinsiyet = cbCinsiyet.SelectedItem.ToString(),
                        MedeniHal = cbMedeniHal.SelectedItem.ToString(),

                        Adres = txtAdres.Text,
                        KullaniciAdi = textBoxKullaniciAd.Text,
                        Sifre = txtSifre.Text,
                        DogumYeri = textBoxDgumYeri.Text



                    });
                    kullaniciekleme.Complate();
                    FormuTemizle();
                    MessageBox.Show("Kullanici Eklendi");
                }

               
            }
            catch
            {
                error();

            }
            
            
            
        }
    }
}
