using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp_Tutorial
{
    class Hashtable_in_C_sharp
    {
        // Hashtable is similar to dictionary only the key and value are not necessary to be of same type unlike dictionary.

        static void Main(string[] args)
        {
            Hashtable data = new Hashtable();

            data.Add("Name", "Kashan");
            data.Add("Rollno", 18);
            data.Add("Subject", "C#");
            data.Add("College", "RGIPT");
            Console.WriteLine("HashTable\n");
            Console.WriteLine("Name is "+ data["Name"] + ", Roll number is " + data["Rollno"]);
            Console.WriteLine("========================================================\nSorted List\n");

            // Sorted List in C #

            SortedList items = new SortedList();


            items.Add("biscuit", 30);
            items.Add("choclate", 30);
            items.Add("pizza", 80);
            items.Add("donut", 50);
            items.Add("banana", 10);
            foreach (DictionaryEntry item in items)
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
        }
    }
}

/*
 SorteList: This is a collection type, used to have items in ascending order
Hashtable is a collection type, which will have Key and Value as attributes

* This feature allow to have our own value with keys
* Key should be unique and value can be repeated.*/