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
            Story.Info();
            Story.BeforeCreating();

            for (int k = 0; k < 3; k++)
            {
                string house = Console.ReadLine();

                if (house == "a")
                {
                    CreateNoldor();
                }
                else if (house == "b")
                {
                    CreateTeleri();
                }
                else if (house == "c")
                {
                    CreateVanyar();
                }
            }


            Morgoth morgoth = new Morgoth();


            ElvenHouse CreateNoldor()
            {
                ElvenHouse noldorHouse = new Noldor();
                Story.BeforeDecorating();
                string quiz = Console.ReadLine();
                Console.WriteLine("\n");
                if (quiz == "a")
                {
                    Console.WriteLine("Goood!");
                    Story.Decorators();
                    DecoratorChoice(noldorHouse);
                    Story.BeforeCreating();
                }
                else
                {
                    Console.WriteLine("Nah. You will not gain extra skills for this house. Try with another: ");
                    Story.BeforeCreating();
                }

                battleList.Add(noldorHouse);
                return noldorHouse;
            }

            ElvenHouse CreateTeleri()
            {
                ElvenHouse teleriHouse = new Teleri();
                Story.BeforeDecorating();
                string quiz = Console.ReadLine();
                Console.WriteLine("\n");
                if (quiz == "b")
                {
                    Console.WriteLine("Goood!");
                    Story.Decorators();
                    DecoratorChoice(teleriHouse);
                    Story.BeforeCreating();
                }
                else
                {
                    Console.WriteLine("Nah. You will not gain extra skills...");
                    Story.BeforeCreating();
                }
                battleList.Add(teleriHouse);
                return teleriHouse;
            }

            ElvenHouse CreateVanyar()
            {
                ElvenHouse vanyarHouse = new Vanyar();
                Story.BeforeDecorating();
                string quiz = Console.ReadLine();
                Console.WriteLine("\n");
                if (quiz == "c")
                {
                    Console.WriteLine("Goood!");
                    Story.Decorators();
                    DecoratorChoice(vanyarHouse);
                    Story.BeforeCreating();
                }
                else
                {
                    Console.WriteLine("Nah. You will not gain extra skills...");
                    Story.BeforeCreating();
                };
                battleList.Add(vanyarHouse);
                return vanyarHouse;
            }

            void DecoratorChoice(ElvenHouse x)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        {
                            x = new DecoratorArmor(x);
                            x.PrintStats(x);
                            break;
                        }

                    case "b":
                        {
                            x = new DecoratorSpell(x);
                            x.PrintStats(x);
                            break;
                        }

                    case "c":
                        {
                            x = new DecoratorArmor(x);
                            x.PrintStats(x);
                            break;
                        }

                    default:
                        Console.WriteLine("You did not choose anything.");
                        break;
                }
            }

            void AreElvesDead(ElvenHouse hero)
            {
                if (hero.Health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Looks like " + hero + " one of elven houses is defeated! The game is over.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Story.MorgothStats();
            morgoth.PrintStats(morgoth);
            Story.StartBattle();
            for (int j = 0; j< 15; j++)
            {
                for (int i = 0; i < battleList.Count; i++)
                {
                    Console.WriteLine(battleList[i] + " is attacking.");

                    battleList[i].YourTurn(battleList[i].AttackChoice(), morgoth);

                    Console.WriteLine("Morgoth health after " + battleList[i].Type() + " attack: " + morgoth.Health + "\n");

                    if (battleList[i].Type() == "Noldor")
                    {
                        Console.WriteLine("Morgoth hates Noldor as they are trying to surpass him." +
                            "\n\nFIREEEEE BREAAAAAAAATHH!!! DIE NOLDORS!");
                        //morgoth.GetNextAttack(battleList[i]);
                        battleList[i].Health -= morgoth.GetNextAttack();
                        Console.WriteLine("Noldor health after Morgoth attack: " + battleList[i].Health);
                    }
                    else
                    {
                        battleList[i].Health -= morgoth.GetNextAttack();
                        Console.WriteLine(battleList[i].Type() + " health after Morgoth attack: " + battleList[i].Health + "\n");
                    }

                    AreElvesDead(battleList[i]);


                    //Console.WriteLine(battleList[i].Type() + " has been attacked with fire breath!\n" + "Elven health after Morgoth attack: " + battleList[i].Health);
                    Console.WriteLine("\n\nNow it's your turn again!");

                }
            }
            



        }



    }
}
