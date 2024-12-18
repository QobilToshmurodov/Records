using System.Net.NetworkInformation;

namespace Records
{
    internal class Program
    {
        // 1-Topshiriq:
        // Employee deb nomlangan positional immutable ko'rinishda (ya'ni positional record uslubida) e'lon qiling.
        // Uning Name (string), DateJoined (DateTime) va SalaryAmount (decimal)
        // xossalari bo'lsin.

        // 2-Topshiriq:
        // Main metodida Employee ga mansub bo'lgan o'zgaruvchi e'lon qiling.
        // O'zgaruvchining .ToString() metodini chaqirib, natijani konsolga chiqaring.

        static void Main(string[] args)
        {
            Employee rec1 = new("Qobil", DateTime.Parse("11.06.2002"), 100000000);
            Console.WriteLine(rec1.ToString());
        }
        public record Employee(string Name, DateTime DateJoined, decimal SalaryAmount);
    }
}
