using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public double Speed;

        //Constructor
        public Car()
        {
            Brand = "unknow";
            Speed = 0;
        }

        public Car(string brand, int speed)
        {
            Brand = brand;
            this.Speed = speed;
        }

        //Methods
        public void AskData()
        {
            Console.WriteLine($"Syötä auton merkki: ");
            Brand = Console.ReadLine();
            Console.WriteLine($"Syötä auton nopeus: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {Brand}\n Auton nopeus: {Speed}");
        }

        public void Accelerate()
        {
            Console.WriteLine("Lisää nopeutta km/h: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed < 0)
            {
                Console.WriteLine("Negatiivinen muutos ei ole sallittu");
            }
            else
            {
                Console.WriteLine("Uusi nopeus:");
                Speed += speed;
            }
        }

        private void Brake()
        {
            Console.WriteLine("Uusi nopeus:");
            Speed = Speed - Speed * 0.1;
        }
    }
}
