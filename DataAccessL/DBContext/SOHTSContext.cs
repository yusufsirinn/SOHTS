using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomainL;
using DomainL.Tables;

namespace DataAccessL.DBContext
{
    public class SOHTSContext:DbContext
    {
        public SOHTSContext() : base("SOHTSContext")
        {

        }


        public DbSet<CikisI> Cikislar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Poliklinik> Poliklinikler { get; set; }
        public DbSet<Sevk> Sevkler { get; set; }
    }
}
