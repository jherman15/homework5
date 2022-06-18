using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class HouseCreationEngine
    {

        public static ElvenHouse CreateNoldor()
        {
            ElvenHouse noldorHouse = new Noldor();
            HouseCreationEngine.choosing(noldorHouse);
            return noldorHouse;
        }

        public static ElvenHouse CreateTeleri()
        {
            ElvenHouse teleriHouse = new Teleri();
            return teleriHouse;
        }

        public static ElvenHouse CreateVanyar()
        {
            ElvenHouse vanyarHouse = new Vanyar();
            return vanyarHouse;
        }

        public static void choosing(ElvenHouse x)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Armor":
                    {
                        Console.WriteLine("Health before: " + x.Health);
                        x = new DecoratorArmor(x);
                        Console.WriteLine("Health after: " + x.Health);
                        break;
                    }

                case "Defence":
                    {
                        x = new DecoratorArmor(x);
                        Console.WriteLine($"Added {choice}.");
                        break;
                    }

                case "Magic":
                    {
                        //Console.WriteLine("Magic power before: " + x.MagicPower);
                        x = new DecoratorArmor(x);
                        //Console.WriteLine("Magic power after: " + x.MagicPower);
                        break;
                    }

                default:
                    Console.WriteLine("You did not choose anything.");
                    break;
            }
        }

    }
}
