using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repositories.Abstract
{
    public interface IKullaniciRepository:IRepository<Kullanici>
    {
        bool IsThere(string username, string password);
        bool Authorized(string usernaem);
        IQueryable GetId();
        IQueryable GetTitleDoctor();
        Kullanici GetKullanici(int id);
        bool IsThereId(int id);
    }
}
