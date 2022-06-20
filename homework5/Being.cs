using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class Being
    {
        public virtual int Attack { get; set; } = 0;
        public virtual int Health { get; set; } = 0;
        public virtual string Name { get; set; } = null;


        public virtual int GetNextAttack()
        {
            return Attack;
        }

        public virtual string Type()
        {
            return null;
        }

    }
}
