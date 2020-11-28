using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Crispin");
            var input = "";
            book.GradeAdded += OnGradeAdded;
            input = EnterGrades(book);

            var stats = book.GetStatistics();
            Console.WriteLine($"The low grade is {stats.Low:n2}");
            Console.WriteLine($"The high grade is {stats.High:n2}");
            Console.WriteLine($"The average grade is {stats.Average:n2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static string EnterGrades(IBook book)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit...");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    book.AddGrade(double.Parse(input));
                    Console.WriteLine(book);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            return input;
        }

        static void OnGradeAdded(object sender, EventArgs e){
            Console.WriteLine("Grade event added");
        }
    }
}
