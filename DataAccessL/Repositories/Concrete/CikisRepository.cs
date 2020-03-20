using DataAccessL.Repositories.Abstract;
using DomainL.Tables;
using DataAccessL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessL.Repositories.Concrete
{
    public class CikisRepository:Repository<CikisI>,ICikisRepository
    {
        public CikisRepository(SOHTSContext context):base(context)
        {

        }
        public SOHTSContext SContext { get { return _context as SOHTSContext; } }



    }
}
