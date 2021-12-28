using GunStore.Interface;
using GunStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunStore.Repository
{
    public class GunRepository : IRepository<Gun>
    {
        private List<Gun> gunList = new List<Gun>();
        public void Delete(int id)
        {
            gunList[id].Delete();
        }

        public Gun GetById(int id)
        {
            return gunList[id];
        }

        public List<Gun> List()
        {
            return gunList;
        }

        public int NextId()
        {
            return gunList.Count;
        }

        public void Create(Gun entity)
        {
            gunList.Add(entity);
        }

        public void Put(int id, Gun entity)
        {
            gunList[id] = entity;
        }
    }
}
