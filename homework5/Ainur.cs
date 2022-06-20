using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class Ainur:IBeing
    {
        public virtual int Attack { get; set; } = 1000;
        public virtual int Health { get; set; } = 3000;
        public virtual int GetNextAttack()
        {
            return Attack;
        }
        public virtual string Type()
        {
            return "Morgoth";
        }
    }









}
