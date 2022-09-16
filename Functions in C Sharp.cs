using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Functions_in_C_Sharp
    {
        // We will create new custom functions
        // These custom functions are called methods in C#
        
        // NOTE : These methods can be parameterized or non paramaterized, here we have created parametized funcitons i.e. we have to pass the parameters in the
        // functions parenthesis itself. We can also take input from the user by using ReadLine funciton while defining the method.

        static void Add(int a , int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is {a+b}");
        }

        static void Sub(int a , int b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is {a-b}");
        }

        static void Mult(int a , int b)
        {
            Console.WriteLine($"Product is {a*b}");
        }
        static void Div(int a , int b)
        {
            Console.WriteLine($"Division is {a/b}");
        }

        // These are custom functions to perform basic calculations

        // Writing the main function and calling these functions

        static void Main(string[] args)
        {
            int a = 234;
            int b = 23342;

            Add(a, b);
            Thread.Sleep(1000);
            Sub(a, b);
            Thread.Sleep(1000);
            Mult(a,b);
            Thread.Sleep(1000);
            Div(a, b);
        }
    }
}
