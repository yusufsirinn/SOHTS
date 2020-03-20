using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repositories.Abstract
{
    public interface ISevkRepository:IRepository<Sevk>
    {
        List<Sevk> GetDischarged(DateTime firtsDate, DateTime secondDate);
        List<Sevk> GetUncharged(DateTime firtsDate, DateTime secondDate);
        List<Sevk> GetUnchargedAndDischarged(DateTime firtsDate, DateTime secondDate);
        int Count(string poliklinik, DateTime date);
        List<Sevk> GetNameUncharged(int id);
        IQueryable GetBefore(int id);
        List<Sevk> GetNo(int id);
        bool GetDischargedID(int id);
        List<Sevk> GetUnchargedID(int id);
        List<Sevk> SevkLastAdds(int id, int num);

    }
}
