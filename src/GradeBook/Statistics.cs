using System;

namespace GradeBook {
    public class Statistics {
        public double High;
        public double Low;
        public double Sum;
        public int Count;

        public double Average {
            get {
                return Sum / Count;
            }
        }

        public Statistics()
        {
            Sum = 0.0;
            Count = 0;
            Low = double.MaxValue;
            High = double.MinValue;
        }

        public void Add(double number) {
            Sum += number;
            Count += 1;
            High = High = Math.Max(number, High);
            Low = Low = Math.Min(number, Low);
        }

        public char Letter {
            get {
                switch(Average) {
                    case var a when a >= 85.0:
                        return 'A';
                    case var a when a >= 75.0:
                        return 'B';
                    case var a when a >= 50.0:
                        return 'C';
                    case var a when a >= 35.0:
                        return  'D';
                    case var a when a <= 35.0:
                        return 'E';
                    default : return '0';
                }
            }

        }
    }
}