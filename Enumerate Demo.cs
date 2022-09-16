using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    // Enumerate (enum) command is used to create a set of constants
    enum CarType
    {
        TwoWheeler, FourWheeler, Neutral
    }
    
    class Enumerate_Demo
    {
        static void Main(string[] args)
        {
            CarType Alto = CarType.TwoWheeler;
            CarType Scorpio = CarType.FourWheeler;
            CarType NexonEV = CarType.Neutral;

            Console.WriteLine($"Alto is {Alto}");
            Console.WriteLine($"Scopio is {Scorpio}");
            Console.WriteLine($"Nexon is {NexonEV}");
        }

       


    }
}
