using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainL.Tables
{
    public class Hasta
    {
        public Hasta()
        {
            SevkHn = new List<Sevk>();
            CikisHn = new List<CikisI>();
        }
        
        [MaxLength (11)]
        [Required]
        public string TCKimlik { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DosyaNo { get; set; }
        [MaxLength(20)]
        public string Ad { get; set; }
        [MaxLength(20)]
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        [MaxLength(20)]
        public string AnneAdi { get; set; }
        [MaxLength(20)]
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHal { get; set; }
        public string DogumYeri { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KurumSicilNo { get; set; }
        public string KurumAdi { get; set; }


        public string YakinTelefon { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YakinKurumSicilNo { get; set; }
        public string YakinKurumAdi { get; set; }

        public List<Sevk> SevkHn { get; set; }
        public List<CikisI> CikisHn { get; set; }

    }
}
