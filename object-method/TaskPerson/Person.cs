using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
        //Fields
        public string Name;
        private int Age;

        //Constructor
        public Person()
        {
            Name = "unknow";
            Age = 0;
        }
            
            public Person(string name, int age)
        {
            Name = name;
            this.Age = age;
        }

        //Methods
        public void GrowOld()
        {
            this.Age++;
        }

        public void GrowOld(int number)
        {
            this.Age = this.Age + number;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {Name}\nIkä: {this.Age}\nAikuinen: {isAdult()}");
        }

        public bool isAdult()
        {
            //return this.age >= 18;

            if (this.Age >= 18)
                return true;
            return false;
        }
        
        public int GetAge()
        {
            return this.Age;
        }
    }
}
