using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    
    class Number  // Here we are difining a class, which has a property number.
    {
        private int num;

        public void SetNumber(int num)   // Here we are assigning the given input to the number class, we can also use Constuctor which we will see in another program.
        {
            this.num = num;
        }

        public void GetNumber()
        {
            Console.WriteLine($"The number is {num}");
        }
    }

    class Class_in_C_Sharp
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            Number n2 = new Number();

            n1.SetNumber(324);
            n2.SetNumber(2343);

            n1.GetNumber();
            n2.GetNumber();
        }

    }
}




/* 
OOPs (Object Oriented Programming Synopsys)
  
 
It is a programming methodology
used to implement security for the data

An object is a realtime entity (physically existing)

An object is a realworld entity

An object has a unique identity


OOPs features
--------------------
Encapsulation: Wrapping of data members and member functions into a single unit

Abstraction: Refers to access data members via member functions

Polymorphism: Refers to define morethan one definition with same name

Inheritance: Acquiring the base class properties to child class

class: A class is user define datatype
Used to implement eighter business logic and application logic

Employee class
Student class
Customer class
Person class


object: An object is an instance of a class( Variable declared for class)


Person p1 = new Person();
Customer c1= new Customer();


new: This keyword is used to instantiate object

Object need memory allocation
will be done using new keyword


Access modifiers: These are used to restrict access to members inside the class

private : Accessible within the class only
protected: Accessible within and derived class
public: Accessible within and outside the class
internal
protected internal 
 */