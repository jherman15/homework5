using System;
using System.Collections.Generic;
using System.Text;

namespace homework5
{
    class RunBattle
    {
        //static Treasury treasure;
        static Morgoth morgoth = new Morgoth();
        //static ElvenHouse noldor, teleri, vanyar;
        static List<ElvenHouse> battleList = new List<ElvenHouse>() {};
        public static void CreateHouse()
        {
            Story.BeforeCreating();

            for (int k = 0; k < 3; k++)
            {
                string house = Console.ReadLine();

                if (house == "Noldor")
                {
                    CreateNoldor();
                }
                else if (house == "Teleri")
                {
                    CreateTeleri();
                }
                else if (house == "Vanyar")
                {
                    CreateVanyar();
                }
            }


            Morgoth morgoth = new Morgoth();
            ElvenHouse CreateNoldor()
            {
                ElvenHouse noldorHouse = new Noldor();
                choosing(noldorHouse);
                battleList.Add(noldorHouse);
                return noldorHouse;
            }

             ElvenHouse CreateTeleri()
            {
                ElvenHouse teleriHouse = new Teleri();
                choosing(teleriHouse);
                battleList.Add(teleriHouse);
                return teleriHouse;
            }

             ElvenHouse CreateVanyar()
            {
                ElvenHouse vanyarHouse = new Vanyar();
                choosing(vanyarHouse);
                battleList.Add(vanyarHouse);
                return vanyarHouse;
            }

             void choosing(ElvenHouse x)
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

                    case "Attack":
                        {
                            Console.WriteLine("Attack before: " + x.Attack);
                            x = new DecoratorSpell(x);
                            Console.WriteLine("Attack after: " + x.Attack);
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

            Story.AfterCreating();
            Console.WriteLine("Morgoth health: " + morgoth.Health);

            for (int i = 0; i < battleList.Count; i++)
            {
                morgoth.Health -= battleList[i].GetNextAttack();
                Console.WriteLine("Morgoth health after " + battleList[i] +  " attack: " + morgoth.Health);
            }

        }



    }
}
