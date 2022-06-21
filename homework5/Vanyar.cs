using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class Vanyar : ElvenHouse            // heal ability
    {

        public int healLvl = 50, maxHealth = 200;

        public Vanyar() : base()
        {
            Health += 150;
        }

        public override int GetNextAttack()
        {
            Random random = new Random();
            if (random.Next(10) < 7) return Attack;
            else
                return Attack * 2;
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
            return "Vanyar";
        }

    }
}
