using System;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AskData();
            car.ShowCarInfo();
            car.Accelerate();
            car.ShowCarInfo();
            Console.WriteLine();

            Car car2 = new Car();
            car2.AskData();
            car2.ShowCarInfo();
            car2.Accelerate();
            car2.ShowCarInfo();

            Console.ReadKey();
        }
    }
}
