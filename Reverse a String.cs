using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Reverse_a_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            string rev = "";
            int len = name.Length-1;
            while (len >=0)
            {
                rev = rev + name[len];
                len--;
            }

            Console.WriteLine($"Your reversed name is {rev}");

            if (rev==name)
            {
                Console.WriteLine($"{name} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not a Palindrome");
            }
        }
    }
}
