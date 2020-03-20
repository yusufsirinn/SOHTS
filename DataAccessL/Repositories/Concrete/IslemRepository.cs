using DataAccessL.Repositories.Abstract;
using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL.DBContext;

namespace DataAccessL.Repositories.Concrete
{
    public class IslemRepository:Repository<Islem>,IIslemRepository
    {
        public IslemRepository(SOHTSContext context) : base(context)
        {

        }
        public SOHTSContext SContext { get { return _context as SOHTSContext; } }
        public bool IsThereId(int id)
        {
            return SContext.Islemler.Any(k => k.IslemNo.Equals(id));
        }
        public IQueryable GetOperationName()
        {
            return SContext.Islemler.OrderBy(i => i.IslemAdi).Select(i => i.IslemAdi);
        }
        public decimal GetPrice(string name)
        {
            return SContext.Islemler.FirstOrDefault(i => i.IslemAdi.Equals(name)).BirimFiyat;
        }
    }
}
