using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repositories.Abstract
{
    public interface IIslemRepository:IRepository<Islem>
    {
        IQueryable GetOperationName();
        decimal GetPrice(string name);
        bool IsThereId(int id);
    }
}
