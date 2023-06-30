using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class Inheritance // base class (parent) 
    {
        public void Brand(string brand)
        {
            Console.WriteLine(brand);
        }

    }
    public class Vehicle : Inheritance // derived class (child)
    {
        public void MethodInVehical()
        {
            Console.WriteLine("This is Method in Vehical Class");
        }
    }

    public class Car : Vehicle // derived class (child)
    {
        public void MethodeInCar()
        {
            Console.WriteLine("This is Method in Car Class");
        }
    }
}
