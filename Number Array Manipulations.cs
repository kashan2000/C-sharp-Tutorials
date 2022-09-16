using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Number_Array_Manipulations
    {
        // We will using array and finding out biggest , smallest and avg of the series.
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER ARRAY MANIPULATIONS");
            int[] nums = new int[5];
            int small=0;
            int big=0;
            int avg;
            int sum = 0;
            for(int i=0; i<nums.Length ; i++)
            {
                Console.WriteLine($"Enter element number {i} :");
                int a = Convert.ToInt32(Console.ReadLine());
                nums[i] = a;
                if (i == 0)
                {
                    small = big = nums[i];
                }
                else if (nums[i] > big)
                {
                    big = nums[i];
                }
                else if (nums[i] < small)
                {
                    small = nums[i];
                }
                sum = sum + nums[i];
            }
            avg = sum / nums.Length;
            Console.WriteLine($"Smallest number in the series is {small}");
            Console.WriteLine($"Biggest number in the series is {big}");
            Console.WriteLine($"Sum of the series is {sum}");
            Console.WriteLine($"Average of the series is {avg}");
        }
    }
}
