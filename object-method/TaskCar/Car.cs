using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;
        private int _brake;

        //Constructor
        public Car()
        {
            Brand = "unknow";
            Speed = 0;
            _brake = Speed;
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
            string Brand = Console.ReadLine();
            Console.WriteLine($"Syötä auton nopeus: ");
            int Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {Brand}\n Auton nopeus: {Speed}");
        }

        public void Accelerate()
        {

        }

        private void Brake()
        {

        }
    }
}
