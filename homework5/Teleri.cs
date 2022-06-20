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
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return "Teleri";
        }
    }
}
