using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Calculator_using_Switch_Case
    {
        static void Main(string[] args)
        {
            // We will me making a Calculator which will perform basic calculations using Switch Case statements

            Console.WriteLine("CALCULATOR");

            Console.WriteLine("Menu : ");
            Console.WriteLine(" Press 1 for Addition\n Press 2 for Subtraction\n Press 3 for Multiplication\n Press 4 for Division");
            int op = Convert.ToInt32(Console.ReadLine());

            // We can also the the numbers from the user outside the switch case then we will not be required to ask for numbers in every case, that is the right approach.
            // This is also an approach which is longer and is done for demonstration.
            switch (op)
            {
                case 1:
                    Console.WriteLine("Enter 1st number : ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Addition of {a} and {b} is {a+b}");
                    break;

                case 2:
                    Console.WriteLine("Enter 1st number : ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Subtraction of {c} and {d} is {c - d}");
                    break;
                case 3:
                    Console.WriteLine("Enter 1st number : ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Multiplication of {e} and {f} is {e * f}");
                    break;
                case 4:
                    Console.WriteLine("Enter 1st number : ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number : ");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Division of {g} and {h} is {g / h}");
                    break;
            }
        }
    }
}
