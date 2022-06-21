using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class DecoratorFireBolt : DecoratorAinur           // a giant fire bolt!
    {
        public DecoratorFireBolt(Ainur _Ainur) : base(_Ainur)
        {
            Health = Ainur.Health;
            Attack = Ainur.Attack;
        }

        public override int GetNextAttack()//gain 50 health point after each attack
        {
            if (Ainur.GetType() == typeof(DecoratorHealingAttack))
            {

                Health = 100 + base.Health;
                return Ainur.GetNextAttack();
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
