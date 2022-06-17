using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorExtraAttack : DecoratorElvenHouse//extra cannon - 30% chance to fire another attack
    {
        public DecoratorExtraAttack(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;          
        }

        public override int GetNextAttack()//extra cannon
        {
            if (ElvenHouse.GetType() == typeof(SpaceshipNanobots))
            {
                Health += 50;
                return base.GetNextAttack() + ElvenHouse.GetNextAttack();
            }
            return base.GetNextAttack() + ElvenHouse.GetNextAttack();//basic + extra cannon
        }
        public override string Type()////type of spaceship + bonus 
        {
            return base.Type() + "- ExtraCannon";
        }
    }
}
