using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL.Repositories.Abstract;
using DomainL.Tables;
using DataAccessL.DBContext;
using DataAccessL.Repositories.Concrete;

namespace DataAccessL.Repositories.Concrete
{
    public class PoliklinikRepository:Repository<Poliklinik>,IPoliklinikRepository
    {
        public PoliklinikRepository(SOHTSContext context) : base(context)
        {
            
        }
        public SOHTSContext SContext { get { return _context as SOHTSContext; } }

        public List<Poliklinik> GetAuthorizedPoliklinik()
        {
            return SContext.Poliklinikler.Where(p => p.Durum == true).ToList();
        }
        public List<Poliklinik> GetUnauthorizedPoliklinik()
        {
            return SContext.Poliklinikler.Where(p => p.Durum == false).ToList();
        }
        public IQueryable GetAuthorizedPoliklinikNames()
        {
            return SContext.Poliklinikler.Where(p => p.Durum == true).Select(p => p.PoliklinikAdi);
        }
        public IQueryable GetUnauthorizedPoliklinikNames()
        {
            return SContext.Poliklinikler.Where(p => p.Durum == false).Select(p => p.PoliklinikAdi);
        }
        public Poliklinik GetPoliklinik(string name)
        {
            return SContext.Poliklinikler.FirstOrDefault(p =>p.PoliklinikAdi==name);
        }
        public bool IsThereId(int id)
        {
            return SContext.Poliklinikler.Any(k => k.PoliklinikNo.Equals(id));
        }


    }
}
