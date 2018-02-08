using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookAndAuthor
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public string Publisher;
        public int Price;
        public static string ThemeName;

        //Constructor
        public Book()
        {
            Title = "Unknow";
            Author = "Unknow";
            Publisher = "Unknown";
            Price = 0;
            ThemeName = "Unknow";
        }

        public Book(string title, string author, string publisher, int price, string themename)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
            ThemeName = themename;
        }

        //Methods
        public void GetBook(string title)
        {
            if (Title.Equals(title))
            {
                Console.WriteLine($"Name: {Title}\n" +
                                  $"Writer: {Author}\n" +
                                  $"Publisher: {Publisher}\n" +
                                  $"Price: {Price:C}\n" +
                                  $"Theme: {ThemeName}");
            }
            else
            {
                Console.WriteLine($"The Book {Title} wasn´t found.");
            }
        }

        public static void ChangeTheme(string Theme)
        {
            ThemeName = Theme;
        }
    }
}
