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
    public partial class UCKullaniciTanitma : UserControl
    {
        public UCKullaniciTanitma()
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
        UnitOfWork u = new UnitOfWork(new SOHTSContext());
        public static int KullaniciId;
        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new FormTasarimlari.UCKullaniciTanitmaEk());
        }

        private void btnKullaniciGüncelleSil_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciId = Convert.ToInt32(cbKullaniciId.SelectedItem);
                panel1.Controls.Clear();
                panel1.Controls.Add(new FormTasarimlari.UCKullaniciGuncelleme());
            }
            catch
            {
                error();
            }

            
        }
        
        private void UCKullaniciTanitma_Load(object sender, EventArgs e)
        {
            try
            {
                var kullanicilar = u.KullaniciRepository.GetId();
                foreach (var item in kullanicilar)
                {
                    cbKullaniciId.Items.Add(item);
                }
            }
            catch
            {
                error();
            }

            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboncekiislemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullaniciId = Convert.ToInt32(cbKullaniciId.SelectedItem);
            panel1.Controls.Clear();
            panel1.Controls.Add(new FormTasarimlari.UCKullaniciGuncelleme());
        }
    }
}
