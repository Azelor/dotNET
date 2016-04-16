using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        { // Asks for a user input
            Console.WriteLine("Enter something to be reversed.");
            string userInput = Console.ReadLine();

            // Calls the method displayResult which calls the method reverseString
            displayResult(reverseString(userInput));
        }

        static string reverseString(string message)
        {
            // Converts a string to an array of characters
            char[] charArray = message.ToCharArray();
            // Reverses the array
            Array.Reverse(charArray);
            // Converts the reversed array into a string
            return String.Concat(charArray);

            
        }

        static void displayResult(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
