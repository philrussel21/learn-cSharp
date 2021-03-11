using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
    {
        // static methods are associated with the class so cannot be called on its intance, 
        // methods and fields that does not have this keyword can be referenced objectively (book.ShowGrades())

        // instead, they are called onto the actual class, like Program.Main()
        // think of it as class and instance methods.
        static void Main(string[] args)
        {
            // instantiating a class
            var book = new Book("BCC Grade Book");
            book.AddGrade(92.3);
            book.AddGrade(89.5);
            book.AddGrade(75.9);
            book.ShowGrades();
            var result = book.GetStats();
            
            // book.ShowStats();

            Console.WriteLine($"Your highest grade is {result.High}");
            Console.WriteLine($"Your lowest grade is {result.Low}");
            Console.WriteLine($"Your average grade is {result.Average:N2}");
            Console.WriteLine($"Your overall grade is {result.Letter}");



            // commented out as they have been modularized(?)
            // // creates a new List that would contain double data types
            // var grades = new List<double>() {12.5,69.2,42.1,21.4};
            // grades.Add(42.0);
            // var sum = 0.0;
            // var highestGrade = double.MinValue;
            // var lowestGrade = double.MaxValue;
            
            // foreach (var grade in grades)
            // {
            //     // conditional to find out the highest grade
            //     // highestGrade = highestGrade < grade ? grade : highestGrade;

            //     highestGrade = Math.Max(grade, highestGrade);
            //     lowestGrade = Math.Min(grade, lowestGrade);
            //     sum += grade;
            // }
            // var ave = sum / grades.Count;
            // Console.WriteLine($"Your total grade is {sum:N0} with an average of {ave:N2}");
            // Console.WriteLine($"Your highest grade is {highestGrade}");
            // Console.WriteLine($"Your lowest grade is {lowestGrade}");
        }
    }
}