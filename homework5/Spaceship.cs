using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class ElvenHouse
    {
        public virtual int Attack { get; set; } = 100;
        public virtual int Health { get; set; } = 300;
        public virtual int GetNextAttack()
        {
            return Attack;
        }
        public virtual string Type()
        {
            return "ElvenHouse";
        }
    }
}
