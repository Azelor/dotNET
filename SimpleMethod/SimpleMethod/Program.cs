using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            // Ask user input for first and last name and city
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born in?");
            string city = Console.ReadLine();
            
            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            Console.WriteLine();
           
            DisplayResult(
                ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city));

            Console.ReadLine();
        }


        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
            
        }
        private static void DisplayResult(string message)
        {
            Console.Write(message);

        }
    }
}
