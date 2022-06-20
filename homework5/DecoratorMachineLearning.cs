using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorMachineLearning : DecoratorElvenHouse

    {
        public DecoratorMachineLearning(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;
        }
       
        public override int GetNextAttack()     //becomes stronger with every attack
        {
            if (ElvenHouse.GetType() == typeof(SpaceshipNanobots))
            {
                ElvenHouse.Attack = 25 + base.Attack;
                Health += 50;
                return ElvenHouse.GetNextAttack();
            }

            ElvenHouse.Attack = 25 + base.Attack;//+25 to attack after each attack
            return base.GetNextAttack();
        }
        
        public override string Type()////type of spaceship + bonus 
        {
            return base.Type() + "- AI";
        }
    }
}
