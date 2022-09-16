using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Abstract class: It is a class
contains partial implementation
Refers to some part of the class implemented
remaining part to be implemented
Implemented methods called as concrete methods
Unimplemented methods called as abstract methods
Note: abstract class must derived
*/

namespace C_Sharp_Tutorial
{
    
    abstract class University
    {
        public void CourseDesign()
        {
            Console.WriteLine("Course is designed at the university");
        }

        public void CourseFee()
        {
            Console.WriteLine("Coursefee is set at university");
        }

        public abstract void Class();  // The emplementation is done at another class

        public abstract void Exams();
    }
    
    class College : University
    {
        public override void Class()  // We use overrride to write the logic for an abstract class
        {
            Console.WriteLine("Classes are at the college");
        }

        public override void Exams()
        {
            Console.WriteLine("Exams are at the college");
        }
    }

    
    
    
    class Abstract_Class_in_C_sharp
    {
        static void Main(string[] args)
        {
            College c1 = new College();

            c1.CourseDesign();
            c1.CourseFee();
            c1.Class();
            c1.Exams();
        }
    }
}
