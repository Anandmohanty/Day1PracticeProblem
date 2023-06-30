using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class Polymorphism
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public virtual double Area()
        {
            return 0;
        }
    }
    public class Circle : Polymorphism
    {
        public double Radius = 6;
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Square : Polymorphism
    {
        public double Length = 9;
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
