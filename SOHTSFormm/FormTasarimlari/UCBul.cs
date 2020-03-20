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
    public partial class UCBul : UserControl
    {
        public UCBul()
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
        private void UCBul_Load(object sender, EventArgs e)
        {
            cbaramaKriteri.Items.Add("Hasta Ad Soyad");
            cbaramaKriteri.Items.Add("Kimlik No");
            cbaramaKriteri.Items.Add("Kurum Sicil No");
            cbaramaKriteri.Items.Add("Dosya No");

            checkBoxVe.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;

        }
        
        int AramaKriteri;
        int SayisalDeger;
        private void cbaramaKriteri_SelectedIndexChanged(object sender, EventArgs e)
        {


            AramaKriteri = cbaramaKriteri.SelectedIndex;

            if (AramaKriteri == 0)
            {
                checkBoxVe.Visible = true;
                txt1.Visible = true;
                txt2.Visible = true;
            }
            else
            {
                checkBoxVe.Visible = false;
                txt1.Visible = true;
                txt2.Visible = false;
            }
            



            txt1.Clear();
            txt2.Clear();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork u = new UnitOfWork(new SOHTSContext());
                dataGridView1.DataSource = null;
                if (txt1.Text == "" && txt1.Equals(null))
                {
                    MessageBox.Show("Arama Degerleri Boş Bırakılamaz !");
                }
                else
                {

                    switch (AramaKriteri)
                    {
                        case 0:
                            {
                                if (checkBoxVe.Checked == true)
                                {
                                    dataGridView1.DataSource = u.HastaRepository.GetEqualsNameAndSurname(txt1.Text, txt2.Text);
                                }
                                else
                                {
                                    dataGridView1.DataSource = u.HastaRepository.GetEqualsName(txt1.Text);
                                }
                                break;
                            }
                        case 1:
                            {
                                dataGridView1.DataSource = u.HastaRepository.GetEqualsTc(txt1.Text);

                                break;
                            }
                        case 2:
                            {
                                SayisalDeger = Convert.ToInt32(txt1.Text);
                                dataGridView1.DataSource = u.HastaRepository.GetEqualsInstitutionId(SayisalDeger);
                                break;
                            }
                        case 3:
                            {
                                SayisalDeger = Convert.ToInt32(txt1.Text);
                                dataGridView1.DataSource = u.HastaRepository.GetEqualsFileNo(SayisalDeger);
                                break;
                            }

                    }
                }
                u.Complate();

            }
            catch
            {
                error();
            }

            
        }
    }
}
