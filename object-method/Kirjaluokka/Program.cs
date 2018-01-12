using System;

namespace Kirjaluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            book kirja1 = new book("Viimeinen vartio", "Stephen King", 12345, 30);
            kirja1.PrintBookInfo();
            Console.WriteLine();
            book kirja2 = new book("Hammaskeiju", "Eve Hietamies", 23456, 11);
            kirja2.PrintBookInfo();
            Console.WriteLine();
            book kirja3 = new book("Loppuluisu", "Kalle Lähde", 34567, 28);
            kirja3.PrintBookInfo();
            Console.WriteLine();
            book kirja4 = new book("Mielensäpahoittajan Suomi", "Tuomas Kyrö", 45678, 40);
            kirja4.PrintBookInfo();
            Console.ReadKey();
        }
    }
}
