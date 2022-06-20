using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Morgoth:Ainur
    {


        public Morgoth() : base()
        {
            Attack += 100;
            Health += 200;
            Name += "Morgoth";
        }

        //public int armor;

        //public Morgoth(string _name, int _attack, int _health, int _armor)
        //    : base(_name, _attack, _health)
        //{
        //    numOfAttack = 4;
        //    armor = _armor;
        //}

        // Battle methods ------------------------------------------------------------

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

        public void DragonTurn(int choice, ElvenHouse target)
        {
            if (choice == 1)
            {
                //GetNextAttack(target);
                Console.WriteLine("Dragon sneezed on you!");
            }

            if (choice == 2)
            {
                FireBreath(target);
                Console.WriteLine("Dragon used flamethrower on you!");
            }

            if (choice == 3)
            {
                Claw(target);
                Console.WriteLine("Dragon clawed you!");
            }

            if (choice == 4)
            {
                Bite(target);
                Console.WriteLine("Dragon bite you!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
