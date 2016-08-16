using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Project
{
    public class CalculatorFunctions
    {
        public static int TotalNumbers(List<int> ListToTotal)
        {
            int Total = 0;
            foreach (int NumberToTotal in ListToTotal)
            {
                Total = Total + NumberToTotal;
            }
            return Total;
        }

        public static double Add(double FirstNumber, double SecondNumber)
        {
            return RoundNumber(FirstNumber + SecondNumber); //Add FirstNumber and SecondNumber
        }
        public double Subtract(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        public double Multiply(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
        public double Divide(double FirstNumber, double SecondNumber /* Denominator */)
        {
            return FirstNumber / SecondNumber;
        }
        /// <summary>
        /// Rounds a number to two decimal places.
        /// </summary>
        /// <param name="Number">Number to be rounded.</param>
        /// <returns></returns>
        private static double RoundNumber(double Number)
        {
            return Math.Round(Number, 2);
        }
    }
}