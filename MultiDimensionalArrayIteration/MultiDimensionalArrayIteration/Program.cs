using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrayIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2-Dimensioonilise massiivi koostamine.
            // Massiivil on 3 rida ja 4 veergu.
            int[,] massiiv = new int[3, 4]
            {
           {0, 1, 2, 3} ,   // Rea indeks on 0
           {4, 5, 6, 7} ,   // Rea indeks on 1
           {8, 9, 10, 11}   // Rea indeks on 2
            };

            for (int veerg = 0; veerg < massiiv.GetLength(0); veerg++)
            {
                for (int rida = 0; rida < massiiv.GetLength(1); rida++)
                {
                    int number = massiiv[veerg, rida];
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
