using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Result_Calculator
    {
        // We will be making a result calculator which will tell the grade of the students, using conditional statements

        static void Main(string[] args)
        {
            Console.WriteLine("RESULT CALCULATOR");

            Console.WriteLine("=================================");

            Console.WriteLine("Enter your marks in English : ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your marks in Maths : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your marks in Science : ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your marks in Sports : ");
            int sp = Convert.ToInt32(Console.ReadLine());

            float total = e + m + s + sp;
            Console.WriteLine($"Total Marks Obtained : {total}/400");
            float percent = (total/400)*100 ;
            Console.WriteLine($"Percentage Obtained : {percent}%");

            Thread.Sleep(1000);

            if (percent >= 90)
            {
                Console.WriteLine("Grade Obtained : A+");
            }
            else if (percent<90 && percent >= 80)
            {
                Console.WriteLine("Grade Obtained : A");
            }
            else if (percent < 80 && percent >= 65)
            {
                Console.WriteLine("Grade Obtained : B+");
            }
            else if (percent < 65 && percent >= 50)
            {
                Console.WriteLine("Grade Obtained : B");
            }
            else if (percent < 50 && percent >= 35)
            {
                Console.WriteLine("Grade Obtained : C");
            }
            else
            {
                Console.WriteLine("Grade Obtained : FAIL");
            }
        }
    }
}
