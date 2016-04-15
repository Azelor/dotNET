using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1") 
                message = "You won a new car!!";
            else if (userValue == "2")
                message = "You won a cake!";
            else if (userValue == "3")
                message = "You won a shovel!";
            else
            {
                message = "Sorry, no such thing!";
                message += " You lose!";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            Console.WriteLine("You chose {0}. You won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}
