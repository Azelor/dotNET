using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Mathematical operators

            // Addition
            x = 3 + 4;

            // Subtraction
            x = 4 - 3;

            //Multiplication & Division
            x = 10 * 5;
            y = 10 / 5;

            // Equality 
            if (x == y)
            {
                Console.WriteLine("X ja Y on v6rdsed");
                Console.ReadLine();
            }

            Console.WriteLine(x + y);
            Console.ReadLine();
        }
    }
}
