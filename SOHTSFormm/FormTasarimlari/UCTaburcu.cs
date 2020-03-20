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
    public partial class UCTaburcu : UserControl
    {
        public UCTaburcu()
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
        List<int> SevkID = new List<int>();
        private void UCOncekiIslemler_Load(object sender, EventArgs e)
        {
            UnitOfWork u = new UnitOfWork(new SOHTSContext());
            cbOdemeSekli.Items.Add("Nakit");
            cbOdemeSekli.Items.Add("Kredi Kartı - Tek Çekim");
            cbOdemeSekli.Items.Add("Kredi Kartı - Taksitli");
            cbOdemeSekli.Items.Add("Çek");
            cbOdemeSekli.Items.Add("Senet");
            cbOdemeSekli.SelectedIndex= 0;
            SevkID = FormTasarimlari.UCHastaIslemleri.SevkNumbers;
            
            lbl.Text = FormTasarimlari.UCHastaIslemleri.toplamTutar.ToString();
            mtxtDosyaNo.Text =FormTasarimlari.UCHastaIslemleri.formDosyaNo.ToString();
            dtpSevkTarihi.Value = FormTasarimlari.UCHastaIslemleri.sevkTarihi;

        }
        public void Guncelle()
        {

            UnitOfWork u = new UnitOfWork(new SOHTSContext());
            foreach (var item in SevkID)
            {
                
                var TaburcuEt = u.SevkRepository.GetById(Convert.ToInt32(item));
                TaburcuEt.Taburcu = true;
                u.Complate();
            }
            
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                UnitOfWork c = new UnitOfWork(new SOHTSContext());
                c.CikisRepository.Add(new DomainL.Tables.CikisI
                {

                    DosyaNo = Convert.ToInt32(mtxtDosyaNo.Text),
                    SevkTarihi = dtpSevkTarihi.Value.Date,
                    CikisTarihi = dtpCikisTarihi.Value.Date,
                    Odeme = cbOdemeSekli.SelectedItem.ToString(),
                    ToplamTutar = Convert.ToDecimal(lbl.Text)
                    
                    


                });
                Guncelle();
                c.Complate();
                MessageBox.Show("Kaydedildi");
            }
            catch
            {
                error();
            }

            
        }

        private void cbOdemeSekli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtxttutat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtDosyaNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
