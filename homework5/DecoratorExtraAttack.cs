using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorExtraAttack : DecoratorElvenHouse       //extra attack
    {
        public DecoratorExtraAttack(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;          
        }

        public override int GetNextAttack()
        {
            return Attack * 2; 
        }
        public override string Type()
        {
            return base.Type() + " is making another attack!";
        }
    }
}
