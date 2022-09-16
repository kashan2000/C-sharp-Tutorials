using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Reading_Values_from_user
    {
        static void Main(string[] args)
        {
            // Console.ReadLine : This command is used to take inputs from users
            // Ex 01: Asking for a users name

            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            // Ex 02: Taking number as input from the user

            Console.WriteLine("Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number is {a}, sqaure of {a} is {a*a}");

            // Ex 03: Taking a character as input from the user

            Console.WriteLine("Enter a letter :");
            char c = Convert.ToChar( Console.ReadLine());
            Console.WriteLine($"Latter is {c} while the letter before {c} is {(char)(c-1)}");

        }
    }
}
