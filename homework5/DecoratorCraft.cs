using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorCraft : DecoratorElvenHouse                         //increasing craft (which can judge the battle's result)
    {
        public DecoratorCraft(ElvenHouse _ElvenHouse) : base(_ElvenHouse)
        {
            Health = ElvenHouse.Health;
            Attack = ElvenHouse.Attack;
            Craft = ElvenHouse.Craft += 75;
        }

        public override int GetNextAttack()     //basic attack 
        {
            return base.GetNextAttack();
        }

    }
}
