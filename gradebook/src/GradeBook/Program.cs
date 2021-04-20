using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
    {
        // Static methods are associated with the class so cannot be called on its instance
        // and can only be called on the class itself (Program.Main(args)), 
        // methods and fields that does not have this keyword can be referenced objectively (book.ShowGrades())

        // instead, they are called onto the actual class, like Program.Main()
        // think of it as class and instance methods.
        static void Main(string[] args)
        {
            // instantiating a class
            var book = new Book("BCC Grade Book");
            // book.AddGrade(92.3);
            // book.AddGrade(89.5);
            // book.AddGrade(75.9);
            // book.ShowGrades();
            // var result = book.GetStats();

            Console.WriteLine("Welcome to this Grade Book. Please input grades and press \"q\" to exit");
            EnterGrades(book);

            var result = book.GetStats();


            // book.ShowStats();

            // Can only see and cannot be reassigned, has to be called on the class
            // Console.WriteLine(Book.CATEGORY);


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

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Please put a grade, or \"q\" to exit.");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    // Will throw an exception when given different format
                    // that cannot be converted to double type
                    var grade = double.Parse(input);
                    // WIll throw an exception when grade is invalid - see method for more info
                    book.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}