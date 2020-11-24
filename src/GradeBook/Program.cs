using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 55.23, 532.643, 32.53 };
            List<double> grades = new List<double>() { 55.23, 532.643, 32.53 };

            var result = 0.0;
            foreach(var n in grades) {
                result += n;
            }

            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:n2}");

            if (args.Length > 0) {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
