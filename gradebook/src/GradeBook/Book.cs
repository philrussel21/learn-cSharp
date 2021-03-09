using System.Collections.Generic;

namespace GradeBook
{
  class Book
    {
      // explicit constructor
      // - should not have a return type
      // - should be the same name as the class itself
      public Book()
      {
        grades = new List<double>();
      }
      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      // field or global variable??
      // would be accessible to all the methods defined in this class
      // cannot use implicit typing (var)

      // one way to avoid exception regarding null values is to explicitly
      // set the value of the field.
      // List<double> grades = new List<double>();

      // part of when setting a constructor - would initially be null
      // then when gotten to the constructor, would be assigned an empty list?
      List<double> grades;
    }
}