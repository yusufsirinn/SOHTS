using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainL.Tables
{
    public class CikisI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CikisTarihiVeDosyaNo { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DosyaNo { get; set; }
        [Required]
        public DateTime SevkTarihi { get; set; }
        [Required]
        public DateTime CikisTarihi { get; set; }
        [Required]
        public string Odeme { get; set; }
        [Required]
        public decimal ToplamTutar { get; set; }
        public Hasta HastaC1 { get; set; }

    }
}
