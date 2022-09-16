using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Sharp_Tutorial
{
    class ArrayList_in_C_Sharp
    {
        // ArrayList : These are non-generic collections in C#, which can store any type of data in one list unlike Arrays which take only a specified mentioned data type.

        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            Console.WriteLine("An array list can contain any type of variable");
            items.Add("kashan");
            items.Add(324);
            items.Add(true);
            items.Add('g');

            foreach (object item in items)
            {
                Console.WriteLine($"Item is {item} and it's datatype is {item.GetType()}");
            }
             
            
        }
    }
}
