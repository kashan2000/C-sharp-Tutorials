using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Palindrome_Checker
    {
        // We will write a program to reverse a number then we will check if this is a palindrome or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = num % 10;
            int num1 = num / 10;
            while (num1 != 0)
            {
                int a = num1 % 10;
                reverse = (reverse * 10) + a;
                num1 = num1 / 10;
            }
            Console.WriteLine($"Reverse of {num} is {reverse}");

            // To check if the number is a palindrome or not
            Console.WriteLine("================================================");
            Thread.Sleep(1000);

            if (num == reverse)
            {
                Console.WriteLine($"{num} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{num} is not a Palindrome");
            }
        }
    }
}
