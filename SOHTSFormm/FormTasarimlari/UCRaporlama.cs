using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using DataAccessL.UnitOfWork;
using DataAccessL.DBContext;
using System.Diagnostics;

namespace SOHTSFormm.FormTasarimlari
{
    public partial class UCRaporlama : UserControl
    {
        public UCRaporlama()
        {
            InitializeComponent();
           
        }

        string name;
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
        
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            DateTime baslangic = Convert.ToDateTime(dtpBaslangic.Value.Date);
            DateTime bitis = Convert.ToDateTime(dtpBitis.Value.Date);

            try
            {
                
                if (radioButtonTolmus.Checked)
                {
                    name = "TABURCU OLMUS HASTALAR";
                    dataGridView1.DataSource = null;
                    using (var context = new SOHTSContext())
                    {
                        var rapor = context.Sevkler.Include("Hasta").
                            Where(s => s.SevkTarihi >= baslangic && s.SevkTarihi <= bitis && s.Taburcu == true).
                            Select(sevk => new { sevk.DosyaNo, sevk.HastaS1.Ad, sevk.HastaS1.Soyad, sevk.SevkTarihi, sevk.DrKod, sevk.YapilanIslemAdi, sevk.Miktar, sevk.ToplamTutar }).ToList();
                        dataGridView1.DataSource = rapor;
                    }
                    //dataGridView1.DataSource = u.SevkRepository.GetDischarged(baslangic, bitis);
                }
                if (radioButtonTolmamis.Checked)
                {
                    name = "TABURCU OLMAMIS HASTALAR";
                    dataGridView1.DataSource = null;
                    using (var context = new SOHTSContext())
                    {
                        var rapor = context.Sevkler.Include("Hasta").
                            Where(s => s.SevkTarihi >= baslangic && s.SevkTarihi <= bitis&&s.Taburcu==false).
                            Select(sevk => new { sevk.DosyaNo, sevk.HastaS1.Ad, sevk.HastaS1.Soyad, sevk.SevkTarihi, sevk.DrKod, sevk.YapilanIslemAdi, sevk.Miktar, sevk.ToplamTutar }).ToList();
                        dataGridView1.DataSource = rapor;
                    }
                    //dataGridView1.DataSource = u.SevkRepository.GetUncharged(baslangic, bitis);
                }
                if (radioButtonHepsi.Checked)
                {
                    name = "TABURCU OLMUS VE OLMAMIS HASTALAR";
                    dataGridView1.DataSource = null;
                    using (var context = new SOHTSContext())
                    {
                        var rapor = context.Sevkler.Include("Hasta").
                            Where(s => s.SevkTarihi >= baslangic && s.SevkTarihi <= bitis).
                            Select(sevk => new { sevk.DosyaNo, sevk.HastaS1.Ad ,sevk.HastaS1.Soyad,sevk.SevkTarihi, sevk.DrKod, sevk.YapilanIslemAdi,sevk.Miktar,sevk.ToplamTutar}).ToList();
                        dataGridView1.DataSource = rapor;
                    }
                        
                    

                    //dataGridView1.DataSource = u.SevkRepository.GetUnchargedAndDischarged(baslangic, bitis);

                }
                



            }
            catch
            {
                error();
            }
        }




    

    private void btnTemizle_Click(object sender, EventArgs e)
    {

        try
        {
            dataGridView1.DataSource = null;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
        }
        catch
        {
            error();
        }



    }

    private void btnYazdir_Click(object sender, EventArgs e)
    {
            try
            {
                PdfCreate PF = new PdfCreate();
                PF.pdfRapor(name, dataGridView1);

                
            }
            catch
            {
                error();
            }
        }

    private void UCRaporlama_Load(object sender, EventArgs e)
    {

    }

    private void dtpBitis_ValueChanged(object sender, EventArgs e)
    {

    }
}
}
