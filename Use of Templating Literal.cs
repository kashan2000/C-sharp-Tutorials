using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Use_of_Templating_Literal
    {
        static void Main(string[] args)
        {
            //Template literals are literals delimited with backtick(`) characters, allowing for multi - line strings, for string interpolation with embedded expressions
            // We can use $ operator to avoid using + sign 
            double num = 23;
            Console.WriteLine($"Number is {num}");
            Console.WriteLine($"Square of {num} is {num*num}");
            Console.WriteLine($"Cube of {num} is {num * num * num}");
            Console.WriteLine($"Half of {num} is {num/2}");

            Console.WriteLine("---------------------------------------");
            Thread.Sleep(100);

            string name = "Kashan";
            string city = "Bhopal";
            Console.WriteLine($"My name is {name} and I am from {city}");
        }
    }
}
