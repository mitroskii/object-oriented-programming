using System;

namespace TaskTransmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Vehicle car = new Car("Sedan", "Toyota", 1996, 5000, 1.6, "Carina", 4);
            car.PrintInfo();
            Console.WriteLine();

            Vehicle car2 = new Car("Sedan", "Audi", 2008, 15000, 2.2, "A4", 4);
            car2.PrintInfo();
            Console.WriteLine();

            Vehicle car3 = new Car("Coupe", "Jaguar", 2002, 13000, 4.2, "XK8", 2);
            car3.ToString();
            Console.WriteLine();

            if (car3.Equals(car2))
                Console.WriteLine("Jaguar is younger than Audi");
            else
                Console.WriteLine("Audi is younger than Jaguar");
            Console.WriteLine();

            Lorry lorry = new Lorry("Lorry", "Mercedes-Benz", 2014, 75000, 12.8, "Actros", 2, 26000, 0.03);
            lorry.PrintInfo();
            Console.WriteLine($"Consumption: {lorry.CountConsumption()} l/100km");
            Console.ReadKey();
        }
    }
}
