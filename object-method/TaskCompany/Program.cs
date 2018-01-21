using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.AskData();
            Console.WriteLine();
            company.ShowCompanyInfo();
            company.Profit(company);
            Console.WriteLine();

            Company company2 = new Company();
            company2.AskData();
            Console.WriteLine();
            company2.ShowCompanyInfo();
            company2.Profit(company2);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
