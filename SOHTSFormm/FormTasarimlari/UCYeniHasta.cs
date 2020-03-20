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
    public partial class UCYeniHasta : UserControl
    {
        public UCYeniHasta()
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

        private void btnKayit_Click(object sender, EventArgs e)
        {

            try
            {
                if (u.HastaRepository.IsThereId(Convert.ToInt32(mtxtDosyaNo.Text)))
                {
                    MessageBox.Show("Personel ID Mevcut !");
                }
                else
                {
                    u.HastaRepository.Add(new DomainL.Tables.Hasta
                    {
                        DosyaNo = Convert.ToInt32(mtxtDosyaNo.Text),
                        Ad = txtAd.Text,
                        BabaAdi = txtBabaAd.Text,
                        AnneAdi = txtAnneAdi.Text,
                        DogumYeri = txtDogumYeri.Text,
                        Telefon = mtxttel.Text,
                        KanGrubu = cbKanGrubu.SelectedItem.ToString(),
                        TCKimlik = mtxtTc.Text,
                        Soyad = txtSoyad.Text,
                        KurumAdi = TxtKurumAdi.Text,
                        KurumSicilNo = Convert.ToInt32(mtxtKurumSicilNo.Text),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Cinsiyet = cbCinsiyet.SelectedItem.ToString(),
                        MedeniHal = cbMedeniHal.SelectedItem.ToString(),
                        YakinKurumAdi = txtYakinKurumAdi.Text,
                        YakinKurumSicilNo = Convert.ToInt32(mtctYakinKurumSicilNo.Text),
                        YakinTelefon = mtxtYakinTel.Text,
                        Adres = txtAdres.Text



                    });
                    u.Complate();
                    MessageBox.Show("Hasta Sisteme Eklendi");
                }


               
            }
            catch
            {
                error();
            }

            
          
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCYeniHasta_Load(object sender, EventArgs e)
        {
            

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

            cbCinsiyet.SelectedIndex = 0;
            cbMedeniHal.SelectedIndex = 0;
            cbKanGrubu.SelectedIndex = 0;
        }
    }
}
