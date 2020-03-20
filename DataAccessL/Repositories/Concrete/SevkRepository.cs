using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL.Repositories.Abstract;
using DomainL.Tables;
using DataAccessL.DBContext;

namespace DataAccessL.Repositories.Concrete
{
    public class SevkRepository:Repository<Sevk>,ISevkRepository
    {
        public SevkRepository(SOHTSContext context) : base(context)
        {
            
        }
        public SOHTSContext SContext { get { return _context as SOHTSContext; } }
        
        public List<Sevk> GetDischarged(DateTime firtsDate,DateTime secondDate)
        {
            return SContext.Sevkler.Where( s=> s.SevkTarihi >= firtsDate&&s.SevkTarihi<=secondDate&&s.Taburcu==true).ToList();

        }
        public List<Sevk> GetUncharged(DateTime firtsDate, DateTime secondDate)
        {
            return SContext.Sevkler.Where( s => s.SevkTarihi >= firtsDate&&s.SevkTarihi<=secondDate&&s.Taburcu==false).ToList();
        }
        public List<Sevk> GetUnchargedAndDischarged(DateTime firtsDate, DateTime secondDate)
        {
            
           return SContext.Sevkler.Where(s => s.SevkTarihi >= firtsDate && s.SevkTarihi <= secondDate ).ToList();
        }
        public int Count(string poliklinik,DateTime date)
        {
            if (!SContext.Sevkler.Any(s=>s.Poliklinik.Equals(poliklinik)) )
            {
                return 1;
            }
            else
            {
                int sira = SContext.Sevkler.Where(s => s.Poliklinik.Equals(poliklinik) && s.SevkTarihi.Equals(date)).Count();
                return sira + 1;
            }
            
        }
        public List<Sevk> GetNameUncharged(int id)
        {
            return SContext.Sevkler.Where(s => s.Taburcu==false&&s.DosyaNo==id).ToList();

        }
        public IQueryable GetBefore(int id)
        {
            return SContext.Sevkler.Where(s => s.DosyaNo == id).Select(s => s.SevkTarihiVeDosyaNo);
        }
        public List<Sevk> GetNo(int id)
        {
            return SContext.Sevkler.Where(h => h.SevkTarihiVeDosyaNo == id).ToList();
        }
        public bool GetDischargedID(int id)
        {
            return SContext.Sevkler.Any(i => i.SevkTarihiVeDosyaNo.Equals(id) && i.Taburcu == true);
        }
        public List<Sevk> GetUnchargedID(int id)
        {
            return SContext.Sevkler.Where(i => i.SevkTarihiVeDosyaNo.Equals(id) && i.Taburcu == false).ToList();
        }
        public List<Sevk> SevkLastAdds(int id,int num)
        {
            return SContext.Sevkler.OrderByDescending(s=>s.SevkTarihiVeDosyaNo).Where(s => s.DosyaNo==id).Take(num).ToList();
        }
        


    }
}
