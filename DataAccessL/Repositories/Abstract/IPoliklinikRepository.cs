using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repositories.Abstract
{
    public interface IPoliklinikRepository:IRepository<Poliklinik>
    {
        List<Poliklinik> GetAuthorizedPoliklinik();
        List<Poliklinik> GetUnauthorizedPoliklinik();
        IQueryable GetAuthorizedPoliklinikNames();
        IQueryable GetUnauthorizedPoliklinikNames();
        Poliklinik GetPoliklinik(string name);
        bool IsThereId(int id);
    }
}
