using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Story
    {


        public static void BeforeCreating()
        {
            Console.WriteLine
        ("This is a LoTR game, where you are able to create your own houses. \n" +
        "What first house you want to create? \n " +
        "You can only create the total number of 5 troops" +
        "a) Noldor \n " +
        "b) Teleri \n " +
        "c) Vanyar \n\n " +
        "Your answer: ");
        }


        public static void AfterCreating()
        {
            Console.WriteLine("Okay, you've got your troops.");
            Console.WriteLine
                ("Now you are facing the battle with Morgoth! \n" +
                "If you've created a well-balanced houses, you may win this brutal fight. \n ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
