using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainL.Tables
{
    public class Kullanici
    {
        [Required]
        public string TCKimlik { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonelKodu { get; set; }
        [MaxLength(20)]
        public string Ad { get; set; }
        [MaxLength(20)]
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public decimal Maas { get; set; }
        [MaxLength(20)]
        public string AnneAdi { get; set; }
        [MaxLength(20)]
        public string BabaAdi { get; set; }
        public string Unvan { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHal { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public bool Yetki { get; set; }
        public string DogumYeri { get; set; }
    }
}
