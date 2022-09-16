using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
//An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface.

{
    interface email // This is like a store box, you can take function and add your own implementation of same name function for different classes.
    {
        public void Compose();
        public void Inbox();
    }

    class Google : email  // using compose and inbox function for Google
    {
        public void Compose()
        {
            Console.WriteLine("Composing mail from Google");
        }

        public void Inbox()
        {
            Console.WriteLine("Google Inbox");
        }
    }

    class Yahoo : email  // using compose and inbox function for Yahoo
    {
        public void Compose()
        {
            Console.WriteLine("Composing mail from yahoo");
        }

        public void Inbox()
        {
            Console.WriteLine("Yahoo Inbox");
        }
    }
    
    
    class Interface_in_C_Sharp
    {
        static void Main(string[] args)
        {
            Google g1 = new Google();
            g1.Compose();
            g1.Inbox();

            Yahoo y1 = new Yahoo();
            y1.Compose();
            y1.Inbox();
        }
    }
}
