using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Basic_Commands_with_C_sharp
    {
        static void Main(string[] args)
        {
            // Writing our first code in C# i.e. Printing Hello World
            // Console.WriteLine(): This is used to display message or variable content in the output and mover cursor to next line
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("This tutorial demonstrate C# language from basics.");

            Thread.Sleep(1000);  // This provides a gap while executing i.e. the next cmd will be executed after 100 ms
            Console.WriteLine("------------------------------------------------");

            // String Manipulations in C#

            string name = "Kashan";
            Console.WriteLine("Name is :"+ name);
            Console.WriteLine("Upper Case :"+ name.ToUpper());
            Console.WriteLine("Lower Case :"+ name.ToLower());
            Console.WriteLine("Length of name :"+ name.Length);

            Console.WriteLine("First two letters are : "+ name.Substring(0,2));
            Console.WriteLine("Last two letters are :"+ name.Substring(4));
        }
    }
}
