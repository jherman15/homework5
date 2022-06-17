using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorSpell2 : DecoratorElvenHouse//army of repairing nanobots
                                                         //- gain 50 health point after each attack
    {
        public DecoratorSpell2(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;
        }

        public override int GetNextAttack()//gain 50 health point after each attack
        {
            if (ElvenHouse.GetType() == typeof(SpaceshipNanobots))
            {

                Health = 100 + base.Health;
                return ElvenHouse.GetNextAttack();
            }
            Health = (base.Health) + 50;//+50 to health after each attack
            return base.GetNextAttack();
        }
        
        public override string Type()////type of spaceship + bonus 
        {
            return base.Type() + "- nanobots";  
        }
    }
}
