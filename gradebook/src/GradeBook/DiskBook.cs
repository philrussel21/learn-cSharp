using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
            Name = name;
            _grades = new List<double>();
            _path = $"C:\\Users\\Phil Antiporda\\source\\repos\\learn-cSharp\\gradebook\\src\\GradeBook\\{Name}.txt";
        }

        // Opens and writes the grades passed to this method to a .txt file
        public override void AddGrade(double grade)
        {
            // My Solution
            // File.AppendAllText(path, grade.ToString());

            // Tutorial Solution
            // This can only be used with types that implement IDisposable,
            // and is syntactic sugar for a try/finally block which calls Dispose in the finally block.
            // This is used to simplify resource management. It cleans up when it gets to the closing bracket.
            using (var writer = File.AppendText(_path))
            {
                writer.WriteLine(grade);
            }

            _grades.Add(grade);
        }

        public override Stats GetStats()
        {
            var results = new Stats(_grades);

            using (var writer = File.AppendText(_path))
            {
                writer.WriteLine("Average: " + results.Average.ToString());
                writer.WriteLine("High: " + results.High.ToString());
                writer.WriteLine("Low: " + results.Low.ToString());
                writer.WriteLine("Letter: " + results.Letter.ToString());
            }
            return results;
        }

        private List<double> _grades;
        private string _path;
    }
}
