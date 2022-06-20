using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorArmor : DecoratorElvenHouse                         //additional armor - more health points
    {
        public DecoratorArmor(ElvenHouse _ElvenHouse) : base(_ElvenHouse)       // dostęp do składowych klasy bazowej z klasy pochodnej
        {
            Health = ElvenHouse.Health + 150;
            Attack = ElvenHouse.Attack;
        }

        public override int GetNextAttack()     //ship's basic attack 
        {
            return base.GetNextAttack();
        }

        public override string Type()   //type of ElvenHouse + bonus 
        {
            return base.Type() + " - Armor";
        }
        
    }
}
