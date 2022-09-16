using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inheritance: Acquiring the base class properties to child class
namespace C_Sharp_Tutorial
{
    class employee
    {
        public string ename;
        public string job;
        public string enrollment;

        public employee(string ename, string job, string enrollment)
        {
            this.ename = ename; this.job = job; this.enrollment = enrollment;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name: {ename}\nJob: {job}\nEnrollemnt type: {enrollment}");
        }
    }

    class tempraryemployee : employee // this extends to base class but only two properties, the enrollment is temporary
    {
        public tempraryemployee(string ename, string job) : base(ename, job, "Temporary")
        {

        }
    }

    class tpermanentemployee : employee
    {
        public tpermanentemployee(string ename, string job) : base(ename, job, "Permanent")
        {

        }
    }




    class Inheritance_in_C_Sharp
    {
        
        static void Main(string[] args)
        {
            employee e1 = new employee("Kashan", "Engineer", "Test");
            e1.Display();
            Console.WriteLine("===============================");

            tempraryemployee t1 = new tempraryemployee("Ajay", "Doctor");  //Here enrollment set is temporary
            t1.Display();
            Console.WriteLine("===============================");

            tpermanentemployee p1 = new tpermanentemployee("Ishaan", "CA");  //Here enrollment set is permanent
            p1.Display();
        }
        
        

    }
}
