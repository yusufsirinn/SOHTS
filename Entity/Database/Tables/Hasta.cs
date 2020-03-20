using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hasta
    {
        public long TCKimlik { get; set; }
        public int DosyaNo{ get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHal { get; set; }
        public string DogumYeri { get; set; }
        public int KurumSicilNo { get; set; }
        public string KurumAdi { get; set; }
        public string YakinTelefon { get; set; }
        public int YakinKurumSicilNo { get; set; }
        public string YakinKurumAdi { get; set; }
    }
}
