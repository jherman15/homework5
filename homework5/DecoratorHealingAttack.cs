using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class DecoratorHealingAttack : ElvenHouse            //gain health after attack
    {
        public override int GetNextAttack()
        {
            Health += 50;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return "spaceship-nanobots";
        }
    }
}
