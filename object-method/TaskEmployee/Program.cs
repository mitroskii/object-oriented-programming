using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Tupu", 12345, "Boss", 15000 );
            employees[0].PrintEmployeeInfo(employees[0]);
            Console.WriteLine();
            employees[1] = new Employee("Hupu", 23456, "Chief", 10000);
            employees[1].PrintEmployeeInfo(employees[1]);
            Console.WriteLine();
            employees[2] = new Employee("Lupu", 34567, "Master", 5000);
            employees[2].PrintEmployeeInfo(employees[2]);
            Console.ReadKey();
        }
    }
}
