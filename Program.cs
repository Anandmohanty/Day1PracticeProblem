﻿namespace Day1PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Problem ");
            Console.WriteLine("Select option For Respective Concepts \n 1.ObjectAndClass \n 2.Inheritance  \n 3.Polymorphism \n 4.Encapsulation \n 5.Abstraction \n 6.Variable \n 7. Type of Method \n 8. Value and Referance Type \n 9.Type of Inheritance");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    ObjectAndClass objectAndClass = new ObjectAndClass();
                    objectAndClass.SampleMethode();
                    break;


                case 2:
                    Car car = new Car();
                    string brandName = "BMW";
                    car.Brand(brandName);
                    car.MethodInVehical();
                    car.MethodeInCar();
                    break;

                    case 3:

                    Polymorphism polymorphism = new Polymorphism();
                    Console.WriteLine("Enter 2 Digit for Addition");
                    int digitOne = Convert.ToInt32(Console.ReadLine());
                    int digitTwo = Convert.ToInt32(Console.ReadLine());
                    int resultOne = polymorphism.Add(digitOne, digitTwo);

                    Polymorphism circle = new Circle();
                    Console.WriteLine("Area :" + circle.Area());

                    Polymorphism square = new Square();
                    Console.WriteLine("Area :" + square.Area());

                    Console.WriteLine("Enter 3rd Digit for addition");
                    int digitThree = Convert.ToInt32(Console.ReadLine());
                    int resultTwo = polymorphism.Add(digitTwo, digitOne, digitThree);
                    Console.WriteLine("Result for Second Method" + resultTwo);
                    break;

                    case 4:

                    Encapsulation encapsulation = new Encapsulation();
                    Console.WriteLine("Enter Employee Name");
                    encapsulation.name = Console.ReadLine();
                    encapsulation.SetSalary(8000);
                    Console.WriteLine("Salary of" + encapsulation.name + " is " + encapsulation.GetSalary());
                    break;

                case 5:
                    DetailsInfo detailsInfo = new DetailsInfo();
                    detailsInfo.NonAbstractMethode();
                    detailsInfo.Salary();
                    break;


                case 6:
                    Variables marksobj1 = new Variables();
                    marksobj1.mathMarks = 50;
                    marksobj1.engMarks = 90;

                    Variables marksobj2 = new Variables();
                    marksobj2.mathMarks = 88;
                    marksobj2.engMarks = 75;

                    Variables.salary = 50000;
                    break;

                case 7:
                    DiriderivedClass diriderivedClass = new DiriderivedClass();
                    diriderivedClass.Salary();
                    TypeOfMethods.StaticMethod();
                    break;

                case 8:
                    ValueAndReferenceType valueAndReferenceType = new ValueAndReferenceType();
                    valueAndReferenceType.ShowValueAndReferanceType();
                    break;

                case 9:
                    DerivedClass derivedClass = new DerivedClass();
                    derivedClass.TestMethodInDeriveClass();//Example of Single Inheritance 

                    C classC = new C();
                    classC.MessageInClassC();// Example of Hierarchical inheritance 

                    Manager manager = new Manager();//Example of Multilevel inheritance
                    manager.ManagerDetails();
                    break;

                default:
                    Console.WriteLine("Please Enter Right Option in between 1 to 9");
                    break;



            }



        }
    }
}