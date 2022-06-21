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
            Attack += 10;
            Health += 1000;

        }

        //public int Craft = 50;

        public override int Crafting()
        {
            return Craft;

        }
        public override string Type()
        {
            return "Noldor";
        }



        public void SpinAttack(Ainur target)
        {
            target.Health -= ((Attack - 2) * 3);
        }

        public override void YourTurn(int decision, Ainur target)
        {
            if (decision == 1)
            {
                DoubleSlash(target);
                Console.WriteLine("You used double slash!");
            }

            if (decision == 2)
            {
                SpinAttack(target);
                Console.WriteLine("You used spin attack!");
            }

        }

       


    }
}
