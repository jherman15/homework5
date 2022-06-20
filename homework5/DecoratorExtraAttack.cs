using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorExtraAttack : DecoratorElvenHouse       //extra attack - 30% (???) chance for another attack
    {
        public DecoratorExtraAttack(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;          
        }

        public override int GetNextAttack() //extra attack
        {
            return base.GetNextAttack() + ElvenHouse.GetNextAttack();   //basic + extra attack
        }
        public override string Type()
        {
            return base.Type() + " is making another attack!";
        }
    }
}
