using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Noldor : ElvenHouse
    {

        public Noldor() : base()
        {
            Attack += 10;
            Health += 1000;
        }


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

        public override void YourTurn(ElvenHouse house1, Ainur target)
        {
            int decision = 0;


                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Special attack");

                bool test = int.TryParse(Console.ReadLine(), out decision);
                if (!test || decision > 2 || decision <= 0)
                {
                    Console.WriteLine("That's not one of the options! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                else if (decision == 1)
                {
                    target.Health -= house1.GetNextAttack();
                }
                else if (decision == 2)
                {
                    SpinAttack(target);
                    Console.WriteLine("You used a spin attack!");
                }

        }




    }
}
