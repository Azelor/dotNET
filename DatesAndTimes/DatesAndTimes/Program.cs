using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month()); ?? not working ??

            //DateTime myBirthday = new DateTime(1969, 12, 7);
            
            DateTime myBirthday = DateTime.Parse("26/9/1990");
            Console.WriteLine(myBirthday.ToShortDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalDays);
                
        

            Console.ReadLine();

        }
    }
}
