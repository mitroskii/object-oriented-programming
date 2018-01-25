using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicket
{
    class Ticket
    {
        //Fields
        public int Age;
        public int Price;
        public float Discount;

        //Constructor
        public Ticket()
        {
            Age = 0;
            Price = 16;
            Discount = 0.0f;
        }

        public Ticket(int age, int price, int discount)
        {
            this.Age = age;
            this.Price = price;
            this.Discount = discount;
        }

        //Methods
        public void AskData()
        {
            Console.Write("How old are you?: ");
            Age = int.Parse(Console.ReadLine());
        }

        public void ShowTicketPrice(Ticket ticket)
        {
            if (Age < 7)
                Console.WriteLine($"Ticket price = {Price * 0}€");
            if (Age >= 7 && Age <= 15)
                Console.Write($"Ticket price = {Price * 0.5}€");
            if (Age >= 65)
                Console.Write($"Ticket price = {Price * 0.5}€");

            if (Age > 15 && Age < 65)
            {
                Console.Write("Are you soldier? [Yes/No]: ");
                if (Console.ReadLine().ToUpper() == "YES")
                 Console.WriteLine($"Ticket price = {Price * 0.5}€"); 

                else
                {
                    Console.Write("Are you Mtk member? [Yes/No]: ");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        Discount = 0.15f;
                    }

                    Console.Write("Are you studier? [Yes/No]: ");
                    if (Console.ReadLine().ToUpper() == "YES")
                    {
                        Discount = Discount + 0.45f;
                    }
                    Console.WriteLine($"Ticket price = {Price - Price * Discount} €");
                }
            }
        }
    }
}

