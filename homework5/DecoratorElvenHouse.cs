using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    abstract class DecoratorElvenHouse : ElvenHouse
    {
        protected ElvenHouse elvenHouse;// protected field of Spaceship type

        public override int Attack {
            get { return ElvenHouse.Attack; }
            set { ElvenHouse.Attack = value; }
            }
        public override int Health { get => base.Health; set => base.Health = value; }
        public ElvenHouse ElvenHouse
        {
            get { return elvenHouse; }
            set { elvenHouse = value; }
        }
        public DecoratorElvenHouse(ElvenHouse _ElvenHouse)
        {
            ElvenHouse = _ElvenHouse;

        }
        public override int GetNextAttack()
        {
            return ElvenHouse.GetNextAttack();
        }
        public override string Type()//Type of ElvenHouse
        {
            return ElvenHouse.Type();
        }
    }
}
