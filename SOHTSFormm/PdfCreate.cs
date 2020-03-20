using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace SOHTSFormm
{
    
    class PdfCreate
    {
        public int PdfRowIndex { get; set; }
        public DataTable ToDatatable()
        {         
            DataTable dt = new DataTable("");
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));

            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));

            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));

            return dt;

        }
        public void pdf(string ad,string soyad,  string dosyaNo, string drad,string toplamtuar, DataGridView dgw)
        {
            
            DataTable dtPDF = ToDatatable();
            string filetime = DateTime.Now.ToFileTime().ToString();
            
            string path = AppDomain.CurrentDomain.BaseDirectory + dosyaNo + filetime + ".pdf";
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1250,BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream(path, FileMode.Create));
            rapor.Open();
            
            rapor.AddAuthor(drad);
            rapor.AddCreationDate();


            PdfPTable Tablo = null;
            Tablo = new PdfPTable(6);

            Tablo.WidthPercentage = 100;


            Tablo.AddCell(new Phrase(dgw.Columns[1].HeaderText,font));
            Tablo.AddCell(new Phrase(dgw.Columns[3].HeaderText,font));
            Tablo.AddCell(new Phrase(dgw.Columns[4].HeaderText,font));
            Tablo.AddCell(new Phrase(dgw.Columns[5].HeaderText,font));
            Tablo.AddCell(new Phrase(dgw.Columns[6].HeaderText,font));
            Tablo.AddCell(new Phrase(dgw.Columns[7].HeaderText, font));
            Tablo.HeaderRows = 1;



            foreach (DataGridViewRow item in dgw.Rows)
            {
                Tablo.AddCell(new Phrase(item.Cells[1].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[3].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[4].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[5].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[6].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[7].Value.ToString(), font));

            }



            rapor.Add(new Paragraph("HASTA SEVK ISLEMLERI \n" + ad + " " + soyad, font));
            rapor.Add(new Paragraph("\n\n\n"));
            rapor.Add(Tablo);
            rapor.Add(new Paragraph("\n\n"));
            rapor.Add(new Paragraph("Toplam Tutar  \t"+ toplamtuar+" TL"));
            rapor.Add(new Paragraph("\n\n"));
            rapor.Add(new Paragraph("Islemi Yapan Doktor \n Dr. " + drad));
            rapor.Close();
            Process.Start(path,".pdf");
        }
        public void pdfRapor(string veri,DataGridView dgw)
        {

            DataTable dtPDF = ToDatatable();
            string filetime = DateTime.Now.ToFileTime().ToString();

            string path = AppDomain.CurrentDomain.BaseDirectory +  filetime + ".pdf";
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream(path, FileMode.Create));
            rapor.Open();

            rapor.AddAuthor("");
            rapor.AddCreationDate();


            PdfPTable Tablo = null;
            Tablo = new PdfPTable(8);

            Tablo.WidthPercentage = 100;
            Tablo.AddCell(new Phrase(dgw.Columns[0].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[1].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[2].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[3].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[4].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[5].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[6].HeaderText, font));
            Tablo.AddCell(new Phrase(dgw.Columns[7].HeaderText, font));
            Tablo.HeaderRows = 1;



            foreach (DataGridViewRow item in dgw.Rows)
            {
                Tablo.AddCell(new Phrase(item.Cells[0].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[1].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[2].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[3].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[4].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[5].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[6].Value.ToString(), font));
                Tablo.AddCell(new Phrase(item.Cells[7].Value.ToString(), font));
            }



            rapor.Add(new Paragraph("-----  RAPOR -----\n-----\t"+veri+"\t -----"));
            rapor.Add(new Paragraph("\n\n"));
            rapor.Add(Tablo);

            rapor.Close();

            Process.Start(path, ".pdf");
        }


    }
}
