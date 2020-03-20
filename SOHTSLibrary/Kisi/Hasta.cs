using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHTSLibrary
{
    class Hasta: AbstractKisi
    {
        private int dosyaNo;
        private int kurumSicilNo;
        private string kurumAdi;
        private long yakinTel;
        private int yakinKurumSicilNo;
        private string yakinKurumAdi;

        protected Hasta(long tcKimlikNo, string ad, string soyad, string dogumYeri, DateTime dogumTarihi, string babaAdi, string anneAdi, string cinsiyet, string kanGrubu, string medeniHal, string adres, long tel
            ,int dosyaNo,int kurumSicilNo,string kurumAdi,long yakinTel,int yakinKurumSicilNo,string yakinKurumAdi) :
           base(tcKimlikNo, ad, soyad, dogumYeri, dogumTarihi, babaAdi, anneAdi, cinsiyet, kanGrubu, medeniHal, adres, tel)
        {
            this.DosyaNo = dosyaNo;
            this.KurumSicilNo = kurumSicilNo;
            this.KurumAdi = kurumAdi;
            this.YakinTel = yakinTel;
            this.YakinKurumSicilNo = yakinKurumSicilNo;
            this.YakinKurumAdi = yakinKurumAdi;
        }

        public int DosyaNo { get => dosyaNo; set => dosyaNo = value; }
        public int KurumSicilNo { get => kurumSicilNo; set => kurumSicilNo = value; }
        public string KurumAdi { get => kurumAdi; set => kurumAdi = value; }
        public long YakinTel
        {
            get => yakinTel; 
            set
            {
                if (value.ToString().Length == 11)
                {
                    yakinTel = value;
                }
            }
        }
        public int YakinKurumSicilNo { get => yakinKurumSicilNo; set => yakinKurumSicilNo = value; }
        public string YakinKurumAdi { get => yakinKurumAdi; set => yakinKurumAdi = value; }
    }
}
