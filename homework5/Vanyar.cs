using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Vanyar : ElvenHouse
    {

        public int healLvl = 7, maxHealth = 200;

        // spaceship with additional armor - more health points
        public Vanyar() : base()
        {
            Health += 150;
        }

        public void Heal()
        {
            Health += healLvl;

            if (Health > maxHealth)
            {
                Health = maxHealth;
            }
        }

        public override string Type()
        {
            return "vanyar";
        }

    }
}
