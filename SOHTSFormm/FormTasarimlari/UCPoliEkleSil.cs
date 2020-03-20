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
    public partial class UCPoliEkleSil : UserControl
    {
        public UCPoliEkleSil()
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
                int id = Convert.ToInt32(mtxtPoliKodu.Text);

                var poli = u.PoliklinikRepository.GetById(id);
                poli.PoliklinikNo = Convert.ToInt32(mtxtPoliKodu.Text);
                poli.Aciklama = txtAciklama.Text;
                poli.Durum = checkBoxGecerliYap.Checked;
                poli.PoliklinikAdi = txtpoliad.Text;
                u.Complate();
            }
            catch
            {
                error();
            }


            

        }

        private void UCPoliEkleSil_Load(object sender, EventArgs e)
        {
            var poliklinik = u.PoliklinikRepository.GetPoliklinik(UCPoliklinik.poliklinikAdi);
            txtAciklama.Text = poliklinik.Aciklama;
            txtpoliad.Text = poliklinik.PoliklinikAdi;
            mtxtPoliKodu.Text = poliklinik.PoliklinikNo.ToString();
            checkBoxGecerliYap.Checked = poliklinik.Durum;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
