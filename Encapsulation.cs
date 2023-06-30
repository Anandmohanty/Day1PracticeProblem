using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class Encapsulation
    {
        private double salary;
        public string name;

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

    }
}