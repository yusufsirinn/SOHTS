using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHTSLibrary
{
    public abstract class AbstractKisi
    {
        protected long tcKimlikNo;
        protected string ad;
        protected string soyad;
        protected string dogumYeri;
        protected DateTime dogumTarihi;
        protected string babaAdi;
        protected string anneAdi;
        protected string cinsiyet;
        protected string kanGrubu;
        protected string medeniHal;
        protected string adres;
        protected long tel;


        protected AbstractKisi(long tcKimlikNo, string ad,string soyad,string dogumYeri,DateTime dogumTarihi,string babaAdi,string anneAdi,string cinsiyet,string kanGrubu,string medeniHal,string adres,long tel)
        {
            this.TcKimlikNo = tcKimlikNo;
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumYeri = dogumYeri;
            this.DogumTarihi = dogumTarihi;
            this.BabaAdi = babaAdi;
            this.AnneAdi = anneAdi;
            this.Cinsiyet = cinsiyet;
            this.KanGrubu = kanGrubu;
            this.MedeniHal = medeniHal;
            this.Adres = adres;
            this.Tel = tel;

        }
        public long TcKimlikNo { get => tcKimlikNo;
            set
            {
                if (value.ToString().Length == 11) 
                {
                    tcKimlikNo = value;
                }
            }
        }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string DogumYeri { get => dogumYeri; set => dogumYeri = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string BabaAdi { get => babaAdi; set => babaAdi = value; }
        public string AnneAdi { get => anneAdi; set => anneAdi = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string KanGrubu { get => kanGrubu; set => kanGrubu = value; }
        public string MedeniHal { get => medeniHal; set => medeniHal = value; }
        public string Adres { get => adres; set => adres = value; }
        public long Tel { get => tel; 
            set 
            {
                if (value.ToString().Length == 11) 
                {
                    tel = value;
                }
            }
        }
    }
}
