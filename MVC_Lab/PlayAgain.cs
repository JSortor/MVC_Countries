using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    class PlayAgain
    {
        public static void Again()
        {
            Console.WriteLine("Would you like to start over? (Y/N)");
            string input = Console.ReadLine().ToLower();
            Program g = new Program();
            if(input == "y")
            {
                Program.Main();
            }
            else if (input == "n")
            {
                Console.WriteLine("GoodBye!");
                Environment.Exit(1);
            }
            else
                Console.WriteLine("I didn't catch that, please try again!");

            Again();
        }
    }
}
