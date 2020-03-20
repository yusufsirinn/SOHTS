using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL.Repositories.Abstract;
using DataAccessL.DBContext;
using DataAccessL.Repositories.Concrete;

namespace DataAccessL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SOHTSContext _SOHTSContext;

        public UnitOfWork(SOHTSContext context)
        {
            _SOHTSContext = context;
            CikisRepository = new CikisRepository(_SOHTSContext);
            HastaRepository = new HastaRepository(_SOHTSContext);
            IslemRepository = new IslemRepository(_SOHTSContext);
            KullaniciRepository = new KullaniciRepository(_SOHTSContext);
            PoliklinikRepository = new PoliklinikRepository(_SOHTSContext);
            SevkRepository = new SevkRepository(_SOHTSContext);
        }

        public ICikisRepository CikisRepository { get; private set; }

        public IHastaRepository HastaRepository { get; private set; }

        public IIslemRepository IslemRepository { get; private set; }

        public IKullaniciRepository KullaniciRepository { get; private set; }
        
        public IPoliklinikRepository PoliklinikRepository { get; private set; }

        public ISevkRepository SevkRepository { get; private set; }

        public int Complate()
        {
            return _SOHTSContext.SaveChanges();
        }

        public void Dispose()
        {
            _SOHTSContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
