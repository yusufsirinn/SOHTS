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
    public partial class UCIslemEkle : UserControl
    {
        public UCIslemEkle()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
        UnitOfWork u = new UnitOfWork(new SOHTSContext());
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (u.IslemRepository.IsThereId(Convert.ToInt32(mtxtislemKodu.Text)))
                {
                    MessageBox.Show("Bu İşlem Kodu Kullanılmaktadır.\nİşlem Kodu : " + mtxtislemKodu.Text);
                }
                else
                {
                    u.IslemRepository.Add(new DomainL.Tables.Islem
                    {
                        IslemAdi = txtislemad.Text,
                        IslemNo = Convert.ToInt32(mtxtislemKodu.Text),
                        BirimFiyat = Convert.ToInt32(mtctfiyat.Text)
                    });
                    u.Complate();
                    MessageBox.Show("İşlem Eklenmiştir");
                }


                
            }
            catch
            {
                error();
            }
        }
    }
}
