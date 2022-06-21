using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Story
    {
        public static void Info()
        {
            Console.WriteLine("[If you type something in, type a, b or c]\n\n" +
                "\n");
            Console.WriteLine("This is a LoTR game, where you are able to create your own houses. \n");
        }


        public static void Decorators()
        {
            Console.WriteLine("Now you can choose which additional powers you want to give to the elves:\n"+
            "a) Extra health \n " +
            "b) Extra attack \n " +
            "c) Extra might \n\n" +
            "Your answer: ");
        }

        public static void DecoratorsNoldor()
        {
            Console.WriteLine("Now you can choose which additional powers you want to give to the elves:\n " +
            "a) Extra health \n " +
            "b) Extra attack \n " +
            "c) Extra might \n " +
            "d) Extra crafting \n\n" +
            "Your answer: ");
        }

        public static void BeforeDecorating()
        {
            Console.WriteLine(
            "If you want to get additional skills, you need to prove you know what you're doing..." +
            "\nSo, tell me, what's true about Vanyars?\n" +
            "a) They mainly dealt with poetry, they loved singing,\n   they stayed close to the Valar,\n   their name means 'beautiful' in Quenya. \n\n" +
            "b) They were most rebellious, eager for knowledge, fame, splendor and power.\n   Gifted artisans, they mainly dealt with the production of beautiful items." +
            "\n   Their name means wise in Quenya.\n   But wise in a sense to have knowledge, not prudent ...\n\n" +
            "c) Teleri are sailors, they loved the sea.\n   They were the last to swim on the island of Tol Eressea.\n   They never actually entered Aman. \n\n" +
            "Your answer: ");

            //Console.ReadLine();
            //Console.Clear();
        }

        public static void BeforeCreating()
        {
            Console.WriteLine
        (
        "What house you want to create? \n" +
        "You can only create the total number of 5 troops. \n " +
        "a) Noldor \n " +
        "b) Teleri \n " +
        "c) Vanyar \n\n" +
        "Your answer: ");
        }



        public static void MorgothStats()
        {
            Console.WriteLine("Okay, you've got your troops. Now you are facing the battle with Morgoth! He is pretty damn strong: \n");

        }

        public static void StartBattle()
        {
            Console.WriteLine("If you've created a well-balanced houses, you may win this brutal fight... \n ");
            Console.ReadLine();
            Console.Clear();
        }



    }
}
