using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Teleri : ElvenHouse
    {
   
        public override int GetNextAttack()
        {
            Attack += 25;
            return Attack;
        }
        public override string Type()
        {
            return "Teleri";
        }
    }
}
