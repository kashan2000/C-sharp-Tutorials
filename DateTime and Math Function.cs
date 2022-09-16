using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class DateTime_and_Math_Function
    {
        //DateTime: This is a predefined structure refers to data and time related value
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());

            Console.WriteLine("========================================================");
            // MATH Functions

            Console.WriteLine(Math.Sqrt(5));
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.Pow(5, 4));

            Console.WriteLine(Math.Sign(45));
            Console.WriteLine(Math.Ceiling(12.93)); // There are various functions which can be used in the Math library.
            Console.WriteLine(Math.Floor(43.98));

        }
    }
}
