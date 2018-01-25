using System;

namespace TaskTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Only one discount is given. Except if you are Mtk member and studier, you'll get both discounts");
            Ticket ticket = new Ticket();
            ticket.AskData();
            ticket.ShowTicketPrice(ticket);
            Console.ReadKey();
        }
    }
}
