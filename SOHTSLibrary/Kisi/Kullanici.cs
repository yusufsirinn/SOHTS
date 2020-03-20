using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHTSLibrary
{
    public abstract class Kullanici:AbstractKisi
    {
        protected string kullaniciAdi;
        protected string sifre;
        protected bool yetki;
        private string unvan;
        protected DateTime iseBaslamaTarihi;
        protected decimal maas;
        protected Kullanici(long tcKimlikNo, string ad, string soyad, string dogumYeri, DateTime dogumTarihi, string babaAdi, string anneAdi, string cinsiyet, string kanGrubu, string medeniHal, string adres, long tel ,string kullaniciAdi,string sifre,bool yetki ,string unvan,DateTime iseBaslamaTarihi,decimal maas) :
            base(tcKimlikNo, ad, soyad, dogumYeri, dogumTarihi, babaAdi, anneAdi, cinsiyet, kanGrubu, medeniHal, adres, tel)
        {
            this.KullaniciAdi = kullaniciAdi;
            this.Sifre = sifre;
            this.Yetki = yetki;
            this.IseBaslamaTarihi = iseBaslamaTarihi;
            this.Maas = maas;
        }

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public bool Yetki { get => yetki; set => yetki = value; }
        public DateTime IseBaslamaTarihi { get => iseBaslamaTarihi; set => iseBaslamaTarihi = value; }
        public decimal Maas { get => maas; set => maas = value; }
        protected string Unvan { get => unvan; set => unvan = value; }
    }
}
