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

            }


        }
    }
}