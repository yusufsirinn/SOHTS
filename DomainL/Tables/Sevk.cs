using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainL.Tables
{
    public class Sevk
    {
        [Key]
        public int SevkTarihiVeDosyaNo { get; set; }
        [Required]
        public DateTime SevkTarihi { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DosyaNo { get; set; }
        [Required]
        public string Poliklinik { get; set; }
        [Required]
        public string YapilanIslemAdi { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrKod { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Miktar { get; set; }
        [Required]
        public decimal BirimFiyat { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sira { get; set; }
        public decimal ToplamTutar { get; set; }
        [Required]
        public bool Taburcu { get; set; }

        public Poliklinik poliklinikS1 { get; set; }
        public Hasta HastaS1 { get; set; }
        public Islem IslemS1 { get; set; }

    }
}
