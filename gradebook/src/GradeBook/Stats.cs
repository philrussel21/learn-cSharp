using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public Stats(List<double> grades)
        {
            _grades = grades;
            _gradeCount = grades.Count;
            Average = GetAverage();
            High = double.MinValue;
            Low = double.MaxValue;
            GetHighLow();
            Letter = 'F';
            GetLetter(Average);
        }

        public double Average { get;}
        public double High { get; private set; }
        public double Low { get; private set; }
        public char Letter { get; private set; }

        private double GetSum(List<double> grades)
        {
            var sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum;
        }

        private double GetAverage()
        {
            var sum = GetSum(_grades);
            return sum / _gradeCount;
        }

        private void GetHighLow()
        {
            foreach (var grade in _grades)
            {
                High = grade > High ? grade : High;
                Low = grade < Low ? grade : Low;
            }
        }

        private void GetLetter(double average)
        {
            switch (average)
            {
                case var g when g >= 95:
                    Letter = 'A';
                    break;
                case var g when g >= 90:
                    Letter = 'B';
                    break;
                case var g when g >= 85:
                    Letter = 'C';
                    break;
                case var g when g >= 80:
                    Letter = 'D';
                    break;
                case var g when g >= 75:
                    Letter = 'E';
                    break;
                default:
                    Letter = 'F';
                    break;
            }
        }

        private List<double> _grades;
        private int _gradeCount;
    }
}