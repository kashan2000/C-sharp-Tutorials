using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Data_Types_in_C_sharp
    {
        static void Main(string[] args)
        {
            // Data types in C#

            int v1 = 100;
            Console.WriteLine("value is " + v1 + ", datatype is " + v1.GetType());

            double v2 = 34.45;
            Console.WriteLine($"value is  {v2} , datatype is{v2.GetType()}");

            string v3 = "Kashan";
            Console.WriteLine($"value is { v3} , datatype is { v3.GetType()}");

            char v4 = 'a';
            Console.WriteLine($"Value is { v4},data type is { v4.GetType()}");
        }
    }
}