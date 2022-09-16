using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Loops_demontration
    {
        static void Main(string[] args)
        {
            // The most used loops are For loop, while loop and do while loop, we will be demonstrating each one of them.

            // For Loop
            Console.WriteLine("Generation numbers from 1 ro 10 using For Loop");
            for (int i= 1; i<=10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n================================");

            // While Loop :  If the condition is satified then only the statement will be executed.
            int b = 1;
            Console.WriteLine("Generation numbers from 1 ro 10 using While Loop");
            while ( b <= 10){
                Console.Write(b + " ");
                b++;
            }
            Console.WriteLine("\n================================");

            // Do while Loop : No matter what first time the statement will get executed

            int a = 1;
            Console.WriteLine("Generation numbers from 1 ro 10 using Do While Loop");
            do
            {
                Console.Write(a + " ");
                a++;
            } while (a <= 10);

            Console.WriteLine("\n================================");
        }
    }
}
