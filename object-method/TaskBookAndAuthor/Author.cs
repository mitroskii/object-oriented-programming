using System;
using System.Collections.Generic;
using System.Text;
using TaskBookAndAuthor.TaskLiterature;

namespace TaskBookAndAuthor
{
    class Author
    {
        //Fields
        public string Name;
        public string Birthday;
        Book Book;

        //Constructor
        public Author(string name, string birthday, Book book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }

        //Methods
        public void PrintWriterInfo()
        {
            Console.WriteLine($"Author name: {Name}\n" +
                              $"Birthday: {Birthday}");
            Book.GetBook("Viimeinen vartio");
        }
    }
}
