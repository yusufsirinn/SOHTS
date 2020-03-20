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
    public partial class UCPoliEkle : UserControl
    {
        public UCPoliEkle()
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                UnitOfWork u = new UnitOfWork(new SOHTSContext());
                if (u.PoliklinikRepository.IsThereId(Convert.ToInt32(mtxtPoliKodu.Text)))
                {
                    MessageBox.Show("Poliklinik No Mevcut !");
                }
                else
                {
                    u.PoliklinikRepository.Add(new DomainL.Tables.Poliklinik
                    {
                        PoliklinikAdi = txtpoliad.Text,
                        PoliklinikNo = Convert.ToInt32(mtxtPoliKodu.Text),
                        Aciklama = txtAciklama.Text,
                        Durum = true


                    });
                    u.Complate();
                    txtpoliad.Clear();
                    txtAciklama.Clear();
                    mtxtPoliKodu.Clear();
                    MessageBox.Show("Poliklinik Eklenmiştir");
                }

                
            }
            catch
            {
                error();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
