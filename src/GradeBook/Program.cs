using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Crispin");

            book.AddGrade(21.76);
            book.AddGrade(53.20);
            book.AddGrade(12.54);

            var stats = book.GetStatistics();
            Console.WriteLine($"The low grade is {stats.Low:n2}");
            Console.WriteLine($"The high grade is {stats.High:n2}");
            Console.WriteLine($"The average grade is {stats.Average:n2}");
        }
    }
}
