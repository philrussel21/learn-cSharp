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
        }

        // Opens and writes the grades passed to this method to a .txt file
        public override void AddGrade(double grade)
        {
            // My Solution
            // var path = $"C:\\Users\\Phil Antiporda\\source\\repos\\learn-cSharp\\gradebook\\src\\GradeBook\\{Name}.txt";
            // File.AppendAllText(path, grade.ToString());

            // Tutorial Solution
            // This can only be used with types that implement IDisposable,
            // and is syntactic sugar for a try/finally block which calls Dispose in the finally block.
            // This is used to simplify resource management. It cleans up when it gets to the closing bracket.
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
            }
        }

        public override Stats GetStats()
        {
            throw new NotImplementedException();
        }
    }
}
