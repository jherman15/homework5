using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class ElvenHouse : Being
    {
        public override int Attack { get; set; } = 10;
        public override int Health { get; set; } = 1000;
        public override string Name { get; set; } = "Elves";

        public int Craft = 50;

        public virtual int Crafting()
        {
            return Craft;
        }
        public override int GetNextAttack()
        {
            return Attack;
        }

        public override string Type()
        {
            return "ElvenHouse";
        }

        public virtual void DoubleSlash(Ainur target)           //later it can be overriden for each elven house
        {
            target.Health -= Attack * 2;
        }


        public virtual void YourTurn(ElvenHouse house1, Ainur target)
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
                    DoubleSlash(target);
                    Console.WriteLine("You used double slash!");
                }
            

        }
    }
}
