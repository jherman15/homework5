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

        //public virtual void YourTurn(int decision, Being target)
        //{

        //}

        public virtual void PrintStats(Being being)
        {
            Console.WriteLine("{0} stats:", being.Name);
            Console.WriteLine("");
            Console.WriteLine("Attack value is: {0}", being.Attack);
            Console.WriteLine("Health value is: {0}", being.Health);

        }

    }
}
