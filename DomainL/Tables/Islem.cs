using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainL.Tables
{
    public class Islem
    {
        public Islem()
        {
            SevkIn = new List<Sevk>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IslemNo { get; set; }
        
        public string IslemAdi { get; set; }
        public decimal BirimFiyat { get; set; }

        public List<Sevk> SevkIn { get; set; }

    }
}
