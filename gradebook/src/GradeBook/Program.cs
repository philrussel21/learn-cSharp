using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(92.3);

            // creates a new List that would contain double data types
            var grades = new List<double>() {12.5,69.2,42.1,21.4};
            grades.Add(42.0);
            var sum = 0.0;
            
            foreach (var grade in grades)
            {
                sum += grade;
            }
            var ave = sum / grades.Count;
            System.Console.WriteLine($"Your total grade is {sum:N0} with an average of {ave:N2}");
        }
    }
}