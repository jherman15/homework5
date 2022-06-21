using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Morgoth : Ainur
    {


        public Morgoth() : base()
        {
            Attack += 100;
            Health += 2000;
            Name += "Morgoth";
        }

        public override int GetNextAttack()
        {
            return Attack;
        }

        public override string Type()
        {
            return "Morgoth";
        }

        public void FireBreath(ElvenHouse target)
        {
            target.Health -= Attack * 2;
        }

        public void Claw(ElvenHouse target)                                           
        {
            target.Health -= Attack + 3;
        }

        public void Bite(ElvenHouse target)                                        
        {
            target.Health -= Attack + 4;
        }


    }
}