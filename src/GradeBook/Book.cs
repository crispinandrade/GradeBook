using System;
using System.Collections.Generic;

namespace GradeBook{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Book {
        public Book(string name) {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(char letter) {
            switch (letter) {
                case 'A': 
                    AddGrade(85);
                    break;
                case 'B': 
                    AddGrade(65);
                    break;
                case 'C': 
                    AddGrade(50);
                    break;
                case 'D': 
                    AddGrade(35);
                    break;
                case 'E': 
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade) {
            if (grade <= 100 && grade >= 0){
                grades.Add(grade);
                if(GradeAdded != null) {
                    GradeAdded(this, new EventArgs());
                }
            }
            else {
                throw new ArgumentException($"Please add a numbered {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate GradeAdded;

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            
            foreach(var grade in grades) {
                    result.High = Math.Max(grade, result.High);
                    result.Low = Math.Min(grade, result.Low);
                    result.Average += grade;
            }

            result.Average /= grades.Count;
            
            switch(result.Average) {
                case var a when a >= 85.0:
                    result.Letter = 'A';
                    break;
                case var a when a >= 75.0:
                    result.Letter = 'B';
                    break;
                case var a when a >= 50.0:
                    result.Letter = 'C';
                    break;
                case var a when a >= 35.0:
                    result.Letter = 'D';
                    break;
                case var a when a <= 35.0:
                    result.Letter = 'E';
                    break;
            }

            return result;
        }

        private List<double> grades;
        public string Name {get; set;}
        public const string CATEGORY = "Science";
    }
}