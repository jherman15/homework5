using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorSpell : DecoratorElvenHouse     //cast a spell - more attack damage
    {

        public DecoratorSpell(ElvenHouse _ElvenHouse) : base(_ElvenHouse) 
        {
            Health = ElvenHouse.Health;
            ElvenHouse.Attack = (ElvenHouse.Attack+ 50);
        }

        public override int GetNextAttack()
        { 
            return base.GetNextAttack();
        }

    }
}
