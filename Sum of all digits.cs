using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Sum_of_all_digits
    {
        // Program to find out the sum of the digits of a given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find it's sum :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                int a = num % 10;
                sum = sum + a;
                num = num / 10;
            }

            Console.WriteLine($"Sum of the digits is : {sum}");
        }
    }
}
