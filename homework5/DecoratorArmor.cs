using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorArmor : DecoratorElvenHouse///additional armor - more health points
    {
        public DecoratorArmor(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health + 150;
            Attack = ElvenHouse.Attack;
        }

    public override int GetNextAttack()//ship's basic attack 
        {
            //if (ElvenHouse.GetType() == typeof(SpaceshipNanobots))
            //{
            //    Health += 50;
            //    return ElvenHouse.GetNextAttack();
            //}
            return base.GetNextAttack();
        }

        public override string Type()//type of spaceship + bonus 
        {
            return base.Type() + " - Armor";
        }
        
    }
}
