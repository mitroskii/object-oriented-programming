using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //Fields
        public string Name;
        public int Id;
        public string Position;
        public int Salary;
        public int NewSalary = 0;

        //Constructor
        public Employee()
        {
            Name = "Unknown";
            Id = 0;
            Position = "Unknow";
            Salary = 0;
        }

        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            this.Id = id;
            Position = position;
            this.Salary = salary;
        }

        //Methods
       
        public void PrintEmployeeInfo(Employee employee)
        {
            if (employee.Id == 12345)
            {
                NewSalary = employee.Salary;
            }

            Console.WriteLine($"Nimi: {employee.Name}\n" +
                             $"Id: {employee.Id}\n" +
                             $"Tehtävä: {employee.Position}\n" +
                             $"Palkka: {employee.Salary}");           
        }
        public void CompareSalary(Employee employee)
        {
            int Comparison = 0;
            Comparison = employee.Salary - Salary;
        }

    }
}
