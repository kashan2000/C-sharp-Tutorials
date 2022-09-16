using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class If_Else_Statements
    {
        static void Main(string[] args)
        {
            // We will write a program is a number is even or odd using if/else statements

            Console.WriteLine("EVEN ODD CHECKER");
            Console.WriteLine("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number");
            }
            else
            {
                Console.WriteLine($"{a} is a odd number");
            }
        }
    }
}


/*
Control structures: These are used control the flow of statement execution
Conditional control structure:      These are used to control statements based on condition
        if, switch case
Iterattion control structure:       These are used to repeat/loop the statement execution
        loops:  while, for and do..while loop
Note: The default statement execution is top to bottom approach, to control this flow will use control structures

Operators:
Arithmetic Operators:       +,      -,      *,      /,      %
Assignment Operators:       =,      +=,     -=.     *=,     /=,     %=
Increment operator:         ++
Decrement operator:         --
Relational operatos:        >,      >=,     <,  <=,     ==,     !=
Logical operators:          && (and)        || (or)     !(not)
 */