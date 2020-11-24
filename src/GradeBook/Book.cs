using System;
using System.Collections.Generic;

namespace GradeBook{

    class Book {
        public Book(string name) {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MinValue;

            foreach(var n in grades) {
                if(n > highGrade) {
                    highGrade = Math.Max(n, highGrade);
                    lowGrade = Math.Min(n, lowGrade);
                    result += n;
                }
            }

            var average = result / grades.Count;
            Console.WriteLine($"The low grade is {lowGrade:n2}");
            Console.WriteLine($"The high grade is {highGrade:n2}");
            Console.WriteLine($"The average grade is {average:n2}");
        }

        private List<double> grades;
        private string name;        
    }
}