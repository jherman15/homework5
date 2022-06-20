using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    abstract class DecoratorElvenHouse : ElvenHouse
    {
        protected ElvenHouse elvenHouse;
        //-----------------setter - getter --------------------------
        public override int Attack                                          // sposob 1
        {
            get { return ElvenHouse.Attack; }
            set { ElvenHouse.Attack = value; }
        }
        public override int Health { get => base.Health; set => base.Health = value; }              //sposob 2


        public ElvenHouse ElvenHouse
        {
            get { return elvenHouse; }
            set { elvenHouse = value; }
        }

        //public override int Attack { get; set; } = 0;                                             //sposb 3 - najprostszy

        //-----------------END setter - getter --------------------------


        //-----------------constructor --------------------------
        public DecoratorElvenHouse(ElvenHouse _ElvenHouse)
        {
            ElvenHouse = _ElvenHouse;
        }

        //----------------END constructor--------------------------

        public override int GetNextAttack()
        {
            return ElvenHouse.GetNextAttack();
        }
        public override string Type()
        {
            return ElvenHouse.Type();
        }
    }
}
