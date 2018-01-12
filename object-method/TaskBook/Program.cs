using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newbook = new Book("Viimeinen vartio", "Stephen King", 12345, 30);
            newbook.PrintBookInfo();
            Console.WriteLine();
            Book book2 = new Book("Hammaskeiju", "Eve Hietamies", 23456, 11);
            book2.PrintBookInfo();
            Console.WriteLine();
            Book book3 = new Book("Loppuluisu", "Kalle Lähde", 34567, 28);
            book3.PrintBookInfo();
            Console.WriteLine();
            Book book4 = new Book("Mielensäpahoittajan Suomi", "Tuomas Kyrö", 45678, 40);
            book4.PrintBookInfo();
            Console.WriteLine();
            Console.WriteLine($"{newbook.CompareBook(book2)}");
            Console.WriteLine($"{newbook.CompareBook(book3)}");
            Console.WriteLine($"{newbook.CompareBook(book4)}");
            Console.WriteLine($"{book2.CompareBook(book3)}");
            Console.WriteLine($"{book2.CompareBook(book4)}");
            Console.WriteLine($"{book3.CompareBook(book4)}");
            Console.ReadKey();

        }
    }
}
