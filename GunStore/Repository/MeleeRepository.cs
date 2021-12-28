using GunStore.Interface;
using GunStore.Model;
using System;
using System.Collections.Generic;

namespace GunStore.Repository
{
    public class MeleeRepository : IRepository<Melee>
    {
        private List<Melee> meleeList = new List<Melee>();
        public void Delete(int id, Melee entity)
        {
            meleeList[id].Delete();
        }

        public Melee GetById(int id)
        {
            return meleeList[id];
        }

        public List<Melee> List()
        {
            return meleeList;
        }

        public int NextId()
        {
            return meleeList.Count;
        }

        public void Create(Melee entity)
        {
            meleeList.Add(entity);
        }

        public void Put(int id, Melee entity)
        {
            meleeList[id] = entity;
        }

        public void Delete(int id)
        {
            meleeList[id].Delete();
        }
    }
}
