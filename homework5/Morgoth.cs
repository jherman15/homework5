using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Morgoth:Ainur
    {

        string choice = Console.ReadLine();
        public Morgoth() : base()
        {
            Attack += 100;
            Health += 200;
            Name += "Morgoth";
        }



        public override int GetNextAttack()
        {

            if (choice == "a")
            {
                Console.WriteLine("Morgoth used FireBreath!");
                return Attack * 2;
            }

            else if (choice == "b")
            {
                Console.WriteLine("Morgoth clawed you!");
                return Attack + 3;
                
            }

            else if (choice == "c")
            {
                Console.WriteLine("Morgoth bite you!");
                return Attack + 4;
                
            }

            else
            {
                Console.WriteLine("Morgoth attacked you!");
                return Attack;      

            }

            return Attack;

        }

        //public int armor;

        //public Morgoth(string _name, int _attack, int _health, int _armor)
        //    : base(_name, _attack, _health)
        //{
        //    numOfAttack = 4;
        //    armor = _armor;
        //}

        // Battle methods ------------------------------------------------------------




    }
}
