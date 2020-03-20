using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHTSLibrary
{
    class Doktor : Kullanici
    {
        private long kodu;
        public Doktor(long tcKimlikNo, string ad, string soyad, string dogumYeri, DateTime dogumTarihi, string babaAdi, string anneAdi, string cinsiyet, string kanGrubu, string medeniHal, string adres, long tel, string kullaniciAdi, string sifre, bool yetki, string unvan, DateTime iseBaslamaTarihi, decimal maas, int kodu):
            base(tcKimlikNo, ad,soyad, dogumYeri, dogumTarihi, babaAdi,  anneAdi, cinsiyet, kanGrubu, medeniHal,  adres,  tel,  kullaniciAdi, sifre,  yetki,unvan,   iseBaslamaTarihi, maas)
        {
            this.Unvan = "Doktor";
            this.Kodu = tcKimlikNo;
        }

        public long Kodu { get => kodu; set => kodu = value; }
    }
}
