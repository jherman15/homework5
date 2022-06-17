using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class SpaceshipNanobots : ElvenHouse
    {
        // spaceship with an army of repairing nanobots - gain 50 health point after each attack
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
