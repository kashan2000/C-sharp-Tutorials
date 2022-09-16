using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    
    class Person
    {
        private string name;
        private string job;
        private int age;
        private int salary;

        public Person(string name,string job, int age,int salary)  // This is a constructor, it always has the same name as of the class, we don't have to write a function seperately, we are providing the values directly.
        {
            this.name = name; this.job = job; this.age = age; this.salary = salary;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name of the person is {name}, job is {job}, is {age} years old and has a salary of {salary}");
        }
    }
    
    
    class Constructor_in_C_Sharp
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Kashan", "Engineer", 21, 34000);   // We are assigning the values directly, no need to call a funtion avery time the class is initiated these values will get initiated.
            Person p2 = new Person("Jitendar", "Developer", 21, 24000);
            Person p3 = new Person("Ishaan", "Product Manager", 25, 32000);
            Person p4 = new Person("Kishan", "Worker", 21, 34000);


            p1.GetDetails();
            p2.GetDetails();
            p3.GetDetails();
            p4.GetDetails();
           
        }
    }
}
