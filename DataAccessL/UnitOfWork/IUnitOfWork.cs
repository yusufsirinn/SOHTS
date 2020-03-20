using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL.Repositories.Abstract;

namespace DataAccessL.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        ICikisRepository CikisRepository { get; }
        IHastaRepository HastaRepository{ get; }
        IIslemRepository IslemRepository { get; }
        IKullaniciRepository KullaniciRepository { get; }
        IPoliklinikRepository PoliklinikRepository { get; }
        ISevkRepository SevkRepository { get; }
        int Complate();
    }
}
