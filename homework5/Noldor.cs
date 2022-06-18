using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Noldor : ElvenHouse
    {
        // ElvenHouse with extra wisdom - more magic damage
        public Noldor() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }

    }
}
