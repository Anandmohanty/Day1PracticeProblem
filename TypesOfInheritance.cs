using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class TypeofInheritance
    {
        public void TestMethod()
        {
            Console.WriteLine("Test method in Base class");
        }

    }

    public class DerivedClass : TypeofInheritance //here TypeOfInheritance is a Base class
    {

        public void TestMethodInDeriveClass()
        {
            TestMethod();
            Console.WriteLine("This is Derived Class and take properties of Base class");

        }

    }

    //Hierarchical inheritance in C#
    class A
    {
        public virtual void Message()
        {
            Console.WriteLine("This is Class A and its also Base class");
        }
    }

    class B : A
    {
        public override void Message()
        {
            Console.WriteLine("This is Class B and Its is Derived class");
        }

    }

    class C : A
    {
        public void MessageInClassC()
        {
            Message();
            Console.WriteLine("This is Class C and Its is Derived class and take properties of Class A");
        }
    }

    //Multilevel inheritance in C#

    class Worker
    {
        public void WorkerDetails()
        {
            Console.WriteLine("This is Base class in Multilevel Inheritance");

        }
    }

    class Supervisor : Worker
    {
        public void SuperwiserDetails()
        {
            WorkerDetails();
            Console.WriteLine("This is Derive and Base class also in Multilevel Inheritance");
        }
    }

    class Manager : Supervisor
    {
        public void ManagerDetails()
        {
            WorkerDetails();
            SuperwiserDetails();
            Console.WriteLine("This is Derived Class which is take properties of all above base class ");
        }
    }
}
