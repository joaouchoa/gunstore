using gunstore.Classes;
using gunstore.Interfaces;

namespace gunstore.Repository
{
    public class GunRepository : IRepository<Gun>
    {
        private List<Gun> gunList = new List<Gun>();
        public void Delete(int id, Gun entity)
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
            gunList[id]=entity;
        }
    }
}