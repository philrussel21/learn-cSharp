using System;
using System.Collections.Generic;

namespace GradeBook
{
  // Was set to public to allow test file to access this class
  public class Book
    {
      // explicit constructor
      // - should not have a return type
      // - should be the same name as the class itself
      public Book(string name)
      {
        grades = new List<double>();
        // this is an implicit variable referring to the object it was called onto
        // always available to methods and constructors
        this.name = name;

        // result = new Stats();
      }

      // public keyword means that any code outside this class can use it.
      // can be used to make methods and fields public BUT generally discouraged
      // to let fields be public, sample:
      // public List<double> grades;
      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public void ShowGrades()
      {
        Console.WriteLine("Your grades are:");
        foreach (var grade in grades)
        {
        Console.WriteLine(grade);            
        }
      }

    // This method returns an object class of Stats, can also be any other type of data.
      public Stats GetStats()
      {
        var result = new Stats();
        var sum = 0.0;
        result.High = double.MinValue;
        result.Low = double.MaxValue;

        foreach(var grade in grades)
        {
          sum += grade;
          result.High = Math.Max(grade, result.High);
          result.Low = Math.Min(grade, result.Low);
        }

        result.Average = sum / grades.Count;

        return result;
      }

      // public void ShowStats()
      // {
      //   Console.WriteLine($"Your average grade is {result.Average:N2}");
      //   Console.WriteLine($"Your highest grade is {result.High}");
      //   Console.WriteLine($"Your lowest grade is {result.Low}");

      // }

      // field or global variable??
      // would be accessible to all the methods defined in this class
      // cannot use implicit typing (var)

      // one way to avoid exception regarding null values is to explicitly
      // set the value of the field.
      // List<double> grades = new List<double>();

      // part of when setting a constructor - would initially be null
      // then when gotten to the constructor, would be assigned an empty list?
      private List<double> grades;

      // private keyword means only this class has access to this field
      // or method.
      private string name;
      // private Stats result;
    }
}