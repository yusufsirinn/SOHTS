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
    public class KullaniciRepository:Repository<Kullanici>,IKullaniciRepository
    {
        public KullaniciRepository(SOHTSContext context) : base(context)
        {

        }
        public SOHTSContext SContext { get { return _context as SOHTSContext; } }

        public bool IsThere(string username,string password)
        {
            return SContext.Kullanicilar.Any(k => k.KullaniciAdi.Equals(username) && k.Sifre.Equals(password));
        }
        public bool Authorized(string usernaem)
        {
            return SContext.Kullanicilar.Any(k => k.KullaniciAdi.Equals(usernaem) && k.Yetki == true);
        }
        public IQueryable GetId()
        {
            return SContext.Kullanicilar.OrderBy(k => k.PersonelKodu).Select(k => k.PersonelKodu);
        }
        public IQueryable GetTitleDoctor()
        {
            return SContext.Kullanicilar.Where(k => k.Unvan.Equals("Doktor")&&k.Yetki==true).Select(k => k.PersonelKodu);
        }
        public Kullanici GetKullanici(int id)
        {
            return SContext.Kullanicilar.FirstOrDefault(k => k.PersonelKodu == id);
        }
        public bool IsThereId(int id)
        {
            return SContext.Kullanicilar.Any(k => k.PersonelKodu.Equals(id));
        }

    }
}
