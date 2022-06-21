using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Teleri : ElvenHouse
    {
        // spaceship with machine learning callibration - becomes stronger with every attack
        public override int GetNextAttack()
        {
            Attack += 25;
            //return base.GetNextAttack();              ?? czy to nie zwroci od klasy bazowej?
            return Attack;
        }
        public override string Type()
        {
            return "Teleri";
        }
    }
}
