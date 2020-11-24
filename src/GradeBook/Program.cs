using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Crispin");

            book.AddGrade(521.76);
            book.AddGrade(523.20);
            book.AddGrade(12.54);

            book.ShowStatistics();
        }
    }
}
