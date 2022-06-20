using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public abstract class Ainur : Being
    {
        public override int Attack { get; set; } = 100;
        public override int Health { get; set; } = 1000;
        public override string Name { get; set; } = "Ainur";


        public override int GetNextAttack()
        {
            return Attack;
        }

        public override string Type()
        {
            return "Ainur";
        }


    }
}

