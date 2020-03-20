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
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections;



namespace SOHTSFormm.FormTasarimlari
{
    public partial class UCHastaIslemleri : UserControl

    {
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

        public static string dosyano;
        public UCHastaIslemleri()
        {
            InitializeComponent();
        }
        UnitOfWork u = new UnitOfWork(new SOHTSContext());

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btkEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
           
        }

        private void btnbul_Click(object sender, EventArgs e)
        {

        }

        private void btngit_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {

        }

        private void btnbason_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaBilgileri_Click_1(object sender, EventArgs e)
        {
            try
            {
                dosyano = mtxtDosyaNo.Text;

                
                if (u.HastaRepository.IsThere(Convert.ToInt32(dosyano)))
                {
                    panel1.Controls.Clear();
                    panel1.Height = 0;
                    panel2.Controls.Add(new FormTasarimlari.UCHastaBilgileri());
                }
                else
                {
                    error();
                }
                
               
            }
            catch
            {
                error();
            }
            
            
            
        }

        private void btnbul_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Height = 0;
            panel2.Controls.Add(new FormTasarimlari.UCBul());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtxtDosyaNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public static int formDosyaNo;
        public static int toplamTutar;
        public static DateTime sevkTarihi;
        int sayac = 0;
        public static List<int> SevkNumbers = new List<int>();
        private void mtxtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            sayac = 0;
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    formDosyaNo = Convert.ToInt32(mtxtDosyaNo.Text);
                    var hastabilgi = u.HastaRepository.GetFileNo(Convert.ToInt32(formDosyaNo));
                    mtxtDosyaNo.Text = hastabilgi.DosyaNo.ToString();
                    txthastaad.Text = hastabilgi.Ad;
                    txthastasoyad.Text = hastabilgi.Soyad;
                    txtkurumadi.Text = hastabilgi.KurumAdi;
                    cboncekiislemler.Items.Clear();
                    var oncekiIs = u.SevkRepository.GetBefore(Convert.ToInt32(mtxtDosyaNo.Text));
                    foreach (var item in oncekiIs)
                    {
                        cboncekiislemler.Items.Add(item);
                    }


                }
            }
            catch
            {
                error();
            }


           
        }

        private void UCHastaIslemleri_Load(object sender, EventArgs e)
        {
            var poliklinikAdlari = u.PoliklinikRepository.GetAuthorizedPoliklinikNames();
            foreach (var item in poliklinikAdlari)
            {
                cbpoli.Items.Add(item);
            }
            var islemAdlari = u.IslemRepository.GetOperationName();
            foreach (var item in islemAdlari)
            {
                cbyapilanislm.Items.Add(item);
            }
            var DoktorKodlari = u.KullaniciRepository.GetTitleDoctor();
            foreach (var item in DoktorKodlari)
            {
                cbdrkod.Items.Add(item);
            }
        }
        

        private void btkEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                u.SevkRepository.Add(new DomainL.Tables.Sevk
                {

                    SevkTarihi = dateTimePickersevktarihi.Value.Date,
                    DosyaNo = Convert.ToInt32(mtxtDosyaNo.Text),
                    Poliklinik = cbpoli.SelectedItem.ToString(),
                    YapilanIslemAdi = cbyapilanislm.SelectedItem.ToString(),
                    DrKod = Convert.ToInt32(cbdrkod.SelectedItem),
                    Miktar = Convert.ToInt32(nudmiktar.Value),
                    BirimFiyat = Convert.ToDecimal(nudbirimfiyat.Value),
                    Sira = Convert.ToInt32(txtsirano.Text),
                    ToplamTutar = Convert.ToDecimal(nudmiktar.Value) * Convert.ToDecimal(nudbirimfiyat.Value),
                    Taburcu = false,
                    


                }) ;
                u.Complate();
                sayac++;
                List<int> SevkNumbers2 = new List<int>();
                dataGridView1.DataSource = null;
                int id = Convert.ToInt32(mtxtDosyaNo.Text);
                using (var context = new SOHTSContext())
                {
                    var rapor = context.Sevkler.
                        OrderByDescending(s => s.SevkTarihiVeDosyaNo).
                        Where(s => s.DosyaNo == id).Take(sayac).
                        Select(sevk => new {sevk.SevkTarihiVeDosyaNo, sevk.DosyaNo,  sevk.SevkTarihi,sevk.DrKod, sevk.YapilanIslemAdi, sevk.Miktar, sevk.BirimFiyat, sevk.ToplamTutar }).ToList();
                    dataGridView1.DataSource = rapor;
                }

                //return SContext.Sevkler.OrderByDescending(s=>s.SevkTarihiVeDosyaNo).Where(s => s.DosyaNo==id).Take(num).ToList();

                //dataGridView1.DataSource = u.SevkRepository.SevkLastAdds(Convert.ToInt32(mtxtDosyaNo.Text), sayac);
                int toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                    SevkNumbers2.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                }
                toplamTutar = toplam;
                labeltoplamtutar.Text = toplamTutar.ToString();
                SevkNumbers = SevkNumbers2;
                int sira = u.SevkRepository.Count(cbpoli.SelectedItem.ToString(), DateTime.Now.Date);
                txtsirano.Text = sira.ToString();
            }
            catch
            {
                error();
            }

           
        }
        
        
        private void cbpoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira= u.SevkRepository.Count(cbpoli.SelectedItem.ToString(),dateTimePickersevktarihi.Value.Date);
            txtsirano.Text = sira.ToString();
        }

        private void cbyapilanislm_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal fiyat = u.IslemRepository.GetPrice(cbyapilanislm.SelectedItem.ToString());
            nudbirimfiyat.Value = fiyat;


        }

        private void txtsirano_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btngit_Click_1(object sender, EventArgs e)
        {
            try
            {
                


                List<int> SevkNumbers2 = new List<int>();
                int id = Convert.ToInt32(cboncekiislemler.SelectedItem);

                if (u.SevkRepository.GetDischargedID(id))
                {
                    MessageBox.Show("Taburcu Olmuş");
                }
                else
                {
                    dataGridView1.DataSource = null;

                    
                    using (var context = new SOHTSContext())
                    {
                        var rapor = context.Sevkler.
                            Where(i => i.SevkTarihiVeDosyaNo.Equals(id) && i.Taburcu == false).
                            Select(sevk => new { sevk.SevkTarihiVeDosyaNo, sevk.DosyaNo, sevk.SevkTarihi, sevk.DrKod, sevk.YapilanIslemAdi, sevk.Miktar,sevk.BirimFiyat, sevk.ToplamTutar }).ToList();
                        dataGridView1.DataSource = rapor;
                    }

                    //dataGridView1.DataSource = u.SevkRepository.GetUnchargedID(id);
                }
                toplamTutar = Convert.ToInt32(dataGridView1.Rows[0].Cells[7].Value);

                SevkNumbers2.Add(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
                SevkNumbers = SevkNumbers2;
                labeltoplamtutar.Text = toplamTutar.ToString();
            }
            catch
            {
                error();
            }
            
            
        }
        public void FormuTemizle()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = item as ComboBox;
                    cb.Items.Clear();
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
        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            //FormuTemizle();
            //sayac = 0;
            //dataGridView1.DataSource = null;

            if (panel1.Height>100)
            {
                panel1.Controls.Clear();
                panel1.Height = 0;
                panel2.Controls.Add(new FormTasarimlari.UCHastaIslemleri());
            }
            else
            {
                panel2.Controls.Clear();
                panel2.Height = 0;
                panel1.Controls.Add(new FormTasarimlari.UCHastaIslemleri());
            }
            
        }
        public static string SevkVeTarihId;

        private void btnTaburcu_Click_1(object sender, EventArgs e)
        {
            try
            {
                sevkTarihi = dateTimePickersevktarihi.Value;
                formDosyaNo = Convert.ToInt32(mtxtDosyaNo.Text);



                panel1.Controls.Clear();
                panel1.Height = 0;
                panel2.Controls.Add(new FormTasarimlari.UCTaburcu());
            }
            catch
            {
                error();
            }
            
        }

        private void btnbason_Click_1(object sender, EventArgs e)
        {
            try
            {
                PdfCreate pf = new PdfCreate();
                pf.pdf(txthastaad.Text, txthastasoyad.Text, mtxtDosyaNo.Text, cbdrkod.Text, labeltoplamtutar.Text, dataGridView1);

               

            }
            catch
            {
                error();
            }
            
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {

            

            try
            {

                u.SevkRepository.Remove(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                u.Complate();
                sayac--;
                List<int> SevkNumbers2 = new List<int>();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = u.SevkRepository.SevkLastAdds(Convert.ToInt32(mtxtDosyaNo.Text), sayac);
                int toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                    SevkNumbers2.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                }
                toplamTutar = toplam;
                labeltoplamtutar.Text = toplamTutar.ToString();
                SevkNumbers = SevkNumbers2;
                int sira = u.SevkRepository.Count(cbpoli.SelectedItem.ToString(), DateTime.Now.Date);
                txtsirano.Text = sira.ToString();
            }
            catch
            {
                error();
            }
        }

        private void btnYazdir_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult yazdir = printDialog1.ShowDialog();
                
                if (yazdir == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch
            {
                error();
            }
        }

        private void cboncekiislemler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
