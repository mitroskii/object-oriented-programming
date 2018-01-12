using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        //Constructor
        public Book()
        {
            Title = "unknow";
            Author = "unknow";
            Id = 0;
            Price = 0;
        }

        public Book(string title, string author, int id, int price)
        {
            Title = title;
            Author = author;
            this.Id = id;
            this.Price = price;
        }

        //Methods
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\n" +
                              $"Kirjan kirjoittaja: {Author}\n" +
                              $"Id-numero: {Id}\n" +
                              $"Hinta: {Price}");
        }

        public string CompareBook(Book newbook)
        {
            if (this.Price > newbook.Price)
            
                return ($"{this.Title} on kalliimpi kuin {newbook.Title} kirja");
           
                return ($"{newbook.Title} on kalliimpi kuin {this.Title} kirja");
        } 
    }
}
    

