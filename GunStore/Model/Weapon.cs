using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunStore.Model
{
    public abstract class Weapon
    {
        public int id { get; protected set; }
        public bool Active { get; set; }

        public void Delete()
        {
            this.Active = false;
        }
    }
}
