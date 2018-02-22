using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTransmission
{
    class Car : Vehicle
    {
        //Fields
        protected double Motor;
        protected string Model;
        protected int Doors;

        //Constructor
        public Car(string type, string brand, int year, int price, double motor, string model, int doors) : base(type, brand, year, price)
        {
            Motor = motor;
            Model = model;
            Doors = doors;
        }

        public Car(string type, string brand, int year, int price) : base(type, brand, year, price)
        {
        }

        //Methods
        public override void PrintInfo()
        {
            Console.WriteLine($"Type:  {Type}\n" +
                              $"Brand: {Brand}\n" +
                              $"Year:  {Year}\n" +
                              $"Price: {Price:C}\n" +
                              $"Motor: {Motor}\n" +
                              $"Model: {Model}\n" +
                              $"Doors: {Doors}");
        }
        public override string ToString()
        {
            PrintInfo();
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            return Year >= ((Car) obj).Year;

        }
    }
}
