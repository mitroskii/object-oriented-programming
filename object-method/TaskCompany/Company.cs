using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        //Fields
        public string Title;
        public string Address;
        public int Phone;
        public int Outcome;
        public int Expense;

        //Constructor
        public Company()
        {
            Title = "Unknown";
            Address = "Unknown";
            Phone = 0;
            Outcome = 0;
            Expense = 0;
        }

        public Company(string title, string address, int phone, int outcome, int expense)
        {
            Title = title;
            Address = address;
            this.Phone = phone;
            this.Outcome = outcome;
            this.Expense = expense;
        }

        //Copy Constructor
        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            this.Phone = previousCompany.Phone;
            this.Outcome = previousCompany.Outcome;
            this.Expense = previousCompany.Expense;
        }

        //Methods
        public void AskData()
        {
            Console.WriteLine("Yrityksen nimi: ");
            Title = Console.ReadLine();
            Console.WriteLine("Osoite: ");
            Address = Console.ReadLine();
            Console.WriteLine("Puhelinnumero: ");
            Phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Tulot: ");
            Outcome = int.Parse(Console.ReadLine());
            Console.WriteLine("Menot: ");
            Expense = int.Parse(Console.ReadLine());
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Nimi: {Title}\n" +
                              $"Osoite: {Address}\n" +
                              $"Puhelinnumero: {Phone}\n" +
                              $"Tulot: {Outcome}\n" +
                              $"Menot: {Expense}");
        }

        public void Profit(Company PreviousCompany)
        {
            int Profit = (PreviousCompany.Outcome - PreviousCompany.Expense) / PreviousCompany.Expense * 100;

            if (Profit < 100)
            {
                Console.WriteLine($"Yrityksellä menee kehnosti.");
            }
            else if(Profit >= 100 && Profit <= 300)
            {
                Console.WriteLine($"Yrityksellä menee tyydyttävästi.");
            }
            else
            {
                Console.WriteLine($"Yrityksellä menee loistavasti.");
            }
        }
    }
}
