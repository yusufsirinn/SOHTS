using DomainL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repositories.Abstract
{
    public interface IHastaRepository:IRepository<Hasta>
    {
        List<Hasta> GetEqualsName(string name);
        List<Hasta> GetEqualsNameAndSurname(string name, string surname);
        List<Hasta> GetEqualsTc(string tc);
        List<Hasta> GetEqualsFileNo(int FileId);
        List<Hasta> GetEqualsInstitutionId(int Id);
        Hasta GetFileNo(int id);
        bool IsThere(int id);
        bool IsThereId(int id);
    }
}
