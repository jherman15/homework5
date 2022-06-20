using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Noldor : ElvenHouse
    {

        //public Noldor(string _name, int _attack, int _health) : base(_name, _attack, _health)         //mozna pozniej zrobic konstruktor
        //{
        //}

        // ElvenHouse with extra wisdom - more magic damage
        public Noldor() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }

        public void DoubleSlash(Ainur target)
        {
            target.Health -= Attack * 2;
        }

        public void SpinAttack(Ainur target)
        {
            target.Health -= ((Attack - 2) * 3);
        }

    }
}
