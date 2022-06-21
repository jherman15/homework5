using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class ElvenHouse:Being
    {
        public override int Attack { get; set; } = 10;
        public override int Health { get; set; } = 100;
        public override string Name { get; set; } = "Elves";

        public int Craft = 50;

        public override int GetNextAttack()
        {
            return Attack;
        }

        public override string Type()
        {
            return "ElvenHouse";
        }

        public virtual void DoubleSlash(Ainur target)
        {
            target.Health -= Attack * 2;
        }

        public virtual void YourTurn(int decision, Ainur target)
        {
            if (decision == 1)
            {
                DoubleSlash(target);
                Console.WriteLine("You used double slash!");
            }
            else if (decision==2)
            {
                Console.WriteLine("Game over");
                Environment.Exit(0);
            }

        }



        public virtual int Crafting()
        {
            return Craft;
        }

        public virtual int AttackChoice() // Produces heros decision
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal //for now end the game (to implement)");
                Console.WriteLine("3. Special //to implement");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("That's not one of the options! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                if (choice == 3) // Specials menu
                {
                    Console.WriteLine("Choose Special:");
                    Console.WriteLine("1. Spin Attack");
                    Console.WriteLine("2. Double Slash");
                    Console.WriteLine("3. <--- Go back");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Thats not one of the options ! Try again!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }

    }
}
