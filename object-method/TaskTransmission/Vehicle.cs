using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTransmission
{
    abstract class Vehicle
    {
        //Fields
        protected string Type;
        protected string Brand;
        protected int Year;
        protected int Price;

        //Constructor
        public Vehicle (string type, string brand, int year, int price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        //Methods
        public abstract void PrintInfo();
    }
}
