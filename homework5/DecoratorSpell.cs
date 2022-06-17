using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorSpell : DecoratorElvenHouse//cast a spell - more attack damage
    {

        public DecoratorSpell(ElvenHouse _ElvenHouse) : base(_ElvenHouse) 
        {
            Health = ElvenHouse.Health;
            ElvenHouse.Attack = (ElvenHouse.Attack+50);//more attack damage
        }

        public override int GetNextAttack()//basic attack
        {
            //if (ElvenHouse.GetType() == typeof(SpaceshipNanobots))
            //{
            //    Health += 50;
            //    return ElvenHouse.GetNextAttack();
            //}
            return base.GetNextAttack();////ship's basic attack
        }

        public override string Type()////type of spaceship + bonus 
        {
            return base.Type() + "-Laser";
        }
    }
}
