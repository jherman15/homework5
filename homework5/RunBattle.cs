using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class RunBattle
    {
        public static void Run()
        {
            // prepare spaceships
            ElvenHouse s1 = new Noldor();
            ElvenHouse s2 = new Vanyar();
            ElvenHouse s3 = new Vanyar();
            ElvenHouse s4 = new Teleri();
            ElvenHouse s5 = new SpaceshipNanobots();
            ElvenHouse s6 = new SpaceshipExtraCannon();

            s1 = new DecoratorArmor(s1);
            s2 = new DecoratorNanobots(s2);
            s3 = new DecoratorArmor(s3); 
            s4 = new DecoratorExtraAttack(s4);
            s5 = new DecoratorNanobots(s5);
            s6 = new DecoratorMachineLearning(s6);
            List<ElvenHouse> tournamentList = new List<ElvenHouse>() { s1, s2, s3, s4, s5, s6 };
            List<int> wins = new List<int>(new int[tournamentList.Count]);

            // run tournament
            for (int i = 0; i < tournamentList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // remember original statistics
                    int hp1 = tournamentList[i].Health;
                    int hp2 = tournamentList[j].Health;
                    int at1 = tournamentList[i].Attack;
                    int at2 = tournamentList[j].Attack;
                    // play this round
                    Console.WriteLine();
                    Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    do
                    {
                        int attack1 = tournamentList[i].GetNextAttack();
                        int attack2 = tournamentList[j].GetNextAttack();
                        tournamentList[j].Health -= attack1;
                        tournamentList[i].Health -= attack2;
                        Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    } while (tournamentList[j].Health > 0 && tournamentList[i].Health > 0);
                    if (tournamentList[j].Health > tournamentList[i].Health)
                    {
                        Console.WriteLine("winner: " + tournamentList[j].Type());
                        wins[j]++;
                    }
                    else if (tournamentList[i].Health > tournamentList[j].Health)
                    {
                        Console.WriteLine("winner: " + tournamentList[i].Type());
                        wins[i]++;
                    }
                    else Console.WriteLine("draw!");
                    // restore original statistics
                    tournamentList[i].Health = hp1;
                    tournamentList[j].Health = hp2;
                    tournamentList[i].Attack = at1;
                    tournamentList[j].Attack = at2;
                }
            }
            
            // display tournament results
            Console.WriteLine("\n");
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOURNAMENT RESULTS");
            var result = tournamentList.OrderByDescending(ship => wins[tournamentList.IndexOf(ship)])
                .Zip(wins.OrderByDescending(i => i), (ship, winNum) => ship.Type().PadRight(32) + "\t" + winNum.ToString() + " wins");
            for (int i = 0; i < result.Count(); i++) Console.WriteLine((i + 1) + ". " + result.ElementAt(i));
            Console.ForegroundColor = currentColor;

        }
    }
}
