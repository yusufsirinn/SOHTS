using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.ListDTO
{
    class Rapor
    {
        public DateTime SevkTarihi { get; set; }
        public int DosyaNo { get; set; }
        public string Poliklinik { get; set; }
        public string YapilanIslemAdi { get; set; }
        public int DrKod { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
