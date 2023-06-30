namespace Day1PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Problem ");
            Console.WriteLine("Select option For Respective Concepts \n 1.ObjectAndClass \n 2.Inheritance  \n 3.Polymorphism \n 4.Encapsulation \n 5.Abstaction \n 6.Variable \n 7. Type of Method \n 8. Value and Referance Type \n 9.Type of Inheritance");
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

            }


        }
    }
}