using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaluokka
{
    class book
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        //Constructor
        public book()
        {
            Title = "unknow";
            Author = "unknow";
            Id = 0;
            Price = 0;
        }

        public book(string title, string author, int id, int price)
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

        public string CompareBook(book book)
        {
            if (this.Price > book.Price)
                return ($"{this.Title} on kalliimpi kuin {book.Title} kirja");

            else ()
        }

        



    }

}
    

