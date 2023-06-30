using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1PracticeProblem
{
    public class ValueAndReferenceType
    {
        public void ShowValueAndReferanceType()
        {
            //A data type is a value type if it holds a data value within its own memory space.
            //It means the variables of these data types directly contain values.
            int age;      // its store intiger vaule like 12,50...
            age = 50;
            char sex = 'M';    // its store single character like m.M...
            bool minor = false; // its store only true and False.
            decimal speed = 90;
            double salary = 15000;
            float teamperature = 19;

            Console.WriteLine("Age before Change age function" + age);
            changeage(age);//----------> Example of Value Type
            Console.WriteLine("Age after Change age function" + age);

            Console.WriteLine("Male and Female" + sex + " Minor " + minor);
            Console.WriteLine("Speed is " + speed + "Salary is " + salary + "Teamperature of car is " + teamperature);

            // this are all Value Type data types
            //------------------//
            //a reference type doesn't store its value directly. Instead,
            //it stores the address where the value is being stored.

            string studentName = "Mahesh";
            //Arrays(even if their elements are value types)
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };

            double[] balance = { 2340.0, 4523.69, 3421.0 };
            Console.WriteLine(studentName);
            Console.WriteLine("Mark of first subject is " + marks[0]);

            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.name = "Mahesh";

            ChangeReferenceType(employeeDetails);

            Console.WriteLine(employeeDetails.name);

            //Class
            //Delegate
        }

        static void changeage(int age)
        {
            age = 66;

            Console.WriteLine(age);
        }

        static void ChangeReferenceType(EmployeeDetails emp2)
        {
            emp2.name = "Ram";
        }
    }
}
