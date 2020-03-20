using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainL.Tables
{
    public class Poliklinik
    {
        public Poliklinik()
        {
            SevkPn = new List<Sevk>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PoliklinikNo { get; set; }
        public string PoliklinikAdi { get; set; }
        [Required]
        public bool Durum { get; set; }
        public string Aciklama { get; set; }
        public List<Sevk> SevkPn { get; set; }
    }
}
