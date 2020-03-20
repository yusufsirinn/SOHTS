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
    public class HastaRepository:Repository<Hasta>,IHastaRepository
    {
        public HastaRepository(SOHTSContext context) : base(context)
        {

        }

        public List<Hasta> GetEqualsName(string name)
        {
            return SContext.Hastalar.Where(h => h.Ad.Equals(name)).ToList();
        }
        public List<Hasta> GetEqualsNameAndSurname(string name,string surname)
        {
            return SContext.Hastalar.Where(h => h.Ad.Equals(name)&&h.Soyad.Equals(surname)).ToList();
        }
        public List<Hasta> GetEqualsTc(string tc)
        {
            return SContext.Hastalar.Where(h => h.TCKimlik.Equals(tc)).ToList();
        }
        public List<Hasta> GetEqualsFileNo(int FileId)
        {
            return SContext.Hastalar.Where(h => h.DosyaNo.Equals(FileId)).ToList();
        }
        public List<Hasta> GetEqualsInstitutionId(int Id)
        {
            return SContext.Hastalar.Where(h => h.KurumSicilNo.Equals(Id)).ToList();
        }
        public Hasta GetFileNo(int id)
        {
            return SContext.Hastalar.FirstOrDefault(h => h.DosyaNo == id);
        }
        public bool IsThere( int id)
        {
            return SContext.Hastalar.Any(k => k.DosyaNo.Equals(id));
        }
        public bool IsThereId(int id)
        {
            return SContext.Hastalar.Any(k => k.DosyaNo.Equals(id));
        }


        public SOHTSContext SContext { get { return _context as SOHTSContext; } }
    }
}
