using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class TypeOfMethods
    {
        public static void StaticMethod()
        {
            Console.WriteLine("This is Static Method");
        }
    }

    public abstract class BaseClass
    {
        public abstract void Salary(); // abstract Methode
    }
    public class DiriderivedClass : BaseClass
    {
        int salary = 10000;
        public override void Salary()
        {
            Console.WriteLine("Salary of Employee is " + salary);
        }
    }
}

