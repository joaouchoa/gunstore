using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunStore.Interface
{
    public interface IRepository<T>
    {
        List<T> List();
        T GetById(int id);
        void Create(T entity);
        void Delete(int id);
        void Put(int id, T entity);
        int NextId();
    }
}
