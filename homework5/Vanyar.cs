using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Vanyar : ElvenHouse
    {
        // spaceship with additional armor - more health points
        public Vanyar() : base()
        {
            Health += 150;
        }
        public override string Type()
        {
            return "spaceship-armor";
        }

    }
}
