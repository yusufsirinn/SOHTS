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
    public partial class UCPoliklinik : UserControl
    {
        public UCPoliklinik()
        {
            InitializeComponent();
        }
        public static string poliklinikAdi;
        private void btnYenipoliekle_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(new FormTasarimlari.UCPoliEkle());
            
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
        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        UnitOfWork u = new UnitOfWork(new SOHTSContext());
        private void UCPoliklinik_Load(object sender, EventArgs e)
        {

            cbPoliad.Items.Clear();
            if (checkBoxGecerli.Checked == true)
            {

                IQueryable GecerliPolikilinikler = u.PoliklinikRepository.GetAuthorizedPoliklinikNames();
                foreach (var item in GecerliPolikilinikler)
                {
                    cbPoliad.Items.Add(item);
                }
            }
            else
            {
                IQueryable GecersizPolikilinikler = u.PoliklinikRepository.GetUnauthorizedPoliklinikNames();
                foreach (var item in GecersizPolikilinikler)
                {
                    cbPoliad.Items.Add(item);
                }
            }


        }
        
        private void btnpoliguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                poliklinikAdi = cbPoliad.SelectedItem.ToString();
                panel1.Controls.Clear();
                panel1.Controls.Add(new FormTasarimlari.UCPoliEkleSil());
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
            poliklinikAdi = cbPoliad.SelectedItem.ToString();
            panel1.Controls.Clear();
            panel1.Controls.Add(new FormTasarimlari.UCPoliEkleSil());
        }

        private void checkBoxGecerli_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                cbPoliad.Items.Clear();
                if (checkBoxGecerli.Checked)
                {

                    IQueryable GecerliPolikilinikler = u.PoliklinikRepository.GetAuthorizedPoliklinikNames();
                    foreach (var item in GecerliPolikilinikler)
                    {
                        cbPoliad.Items.Add(item);
                    }
                }
                else
                {
                    IQueryable GecersizPolikilinikler = u.PoliklinikRepository.GetUnauthorizedPoliklinikNames();
                    foreach (var item in GecersizPolikilinikler)
                    {
                        cbPoliad.Items.Add(item);
                    }
                }
                cbPoliad.SelectedIndex = 0;
            }
            catch
            {
                error();
            }
        }
    }
}
