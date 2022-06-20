using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    abstract class DecoratorAinur : Ainur
    {
        protected Ainur elvenHouse;

        public override int Attack
        {
            get { return Ainur.Attack; }
            set { Ainur.Attack = value; }
        }
        public override int Health { get => base.Health; set => base.Health = value; }
        public Ainur Ainur
        {
            get { return elvenHouse; }
            set { elvenHouse = value; }
        }
        public DecoratorAinur(Ainur _Ainur)
        {
            Ainur = _Ainur;
        }
        public override int GetNextAttack()
        {
            return Ainur.GetNextAttack();
        }
        public override string Type()
        {
            return Ainur.Type();
        }
    }
}
