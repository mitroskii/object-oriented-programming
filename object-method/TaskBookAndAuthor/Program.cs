using System;
using TaskBookAndAuthor.TaskLiterature;

namespace TaskBookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book newbook = new Book("Viimeinen vartio", "Stephen King", "Tammi", 30, "Thriller");
            newbook.GetBook("Aamunkoi");
            Console.WriteLine();

            Book book2 = new Book("Hammaskeiju", "Eve Hietamies", "Otava", 42, "Pocketbook");
            book2.GetBook("Hammaskeiju");
            Console.WriteLine($"New price: {book2.NewPrice = 36:C}");
            Console.WriteLine($"Discounted price: {book2.NewPrice:C}");
            Console.WriteLine();

            Book book3 = new Book("Loppuluisu", "Kalle Lähde", "Otava", 28, "Pocketbook");
            Console.WriteLine(book3.AuthorValue);
            Console.WriteLine();

            Book book4 = new Book("Mielensäpahoittajan Suomi", "Tuomas Kyrö", "WSOY", 40, "Fiction");
            book4.GetBook("Mielensäpahoittajan Suomi");
            Book.ChangeTheme("New Theme: Pocketbook");
            Console.WriteLine(Book.ThemeName);
            Console.WriteLine();

            Author author = new Author("Kalle Lähde", "01.01.1960", book3);
            author.PrintWriterInfo();

            Console.ReadKey();
        }
    }
}
