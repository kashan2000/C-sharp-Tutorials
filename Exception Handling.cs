using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Exception_Handling
    {
        // We will be learning about Exception Handling
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int? a = null;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                Console.WriteLine("Default value set to 1 ");
                a = 1;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error : {ex.Message}, ");
                Console.WriteLine("Default value set to 1 ");
                a = 1;
            }
            finally
            {
                Console.WriteLine($"Sqaure of {a} is {a*a}");

            }
            


        }
    }
}


/*Exception Handling: 
    An exception refers to runtime error, program gets terminiated when an exception raised

    Exception handling is a mechanism to continue the program instead of termination when error raised

    try{}   :   try block used to provide statements may provide exception
    catch   :   catch block is used to handle exception instead of terminated*/

