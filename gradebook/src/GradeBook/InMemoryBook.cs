using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Was set to public to allow test file to access this class
    public class InMemoryBook : Book
    {
        // Explicit constructor
        // - should not have a return type
        // - should be the same name as the class itself
        // Base() keyword is a way to reference the base class; accessing the base class' constructor method. In this use case,
        // the name argument passed to InMemoryBook on init is also being passed to the base class (NamedObject)
        public InMemoryBook(string name) : base(name) 
        {
            grades = new List<double>();
            // The keyword this is an implicit variable referring to the object it was called onto and
            // always available to methods and constructors. If the field/property is also named name,
            // this could be written as: this.name = name;
            Name = name;


            // result = new Stats();
        }

        // Even though you have 2 methods that have the same name,
        // C# knows which is which because they accept different
        // types of paramaters so it can be distinguished. This is
        // called Overloading Methods.
        public void AddGrade(char let)
        {
            switch (let)
            {
                case 'A':
                    AddGrade(95);
                    break;
                case 'B':
                    AddGrade(90);
                    break;
                case 'C':
                    AddGrade(85);
                    break;
                case 'D':
                    AddGrade(80);
                    break;
                case 'E':
                    AddGrade(75);
                    break;
                case 'F':
                    AddGrade(70);
                    break;
                default:
                    Console.WriteLine("Invalid letter provided.");
                    break;
            }
        }


        // public keyword means that any code outside this class can use it.
        // can be used to make methods and fields public BUT generally discouraged
        // to let fields be public, sample:
        // public List<double> grades;

        // override keyword means overridding the method (or property) that this child class inherited from its parent abstract class.
        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                // Console.WriteLine("Grade out of range, did not add grade.");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
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
        public override Stats GetStats()
        {
            var result = new Stats();
            var sum = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                sum += grade;
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
            }

            result.Average = sum / grades.Count;

            // Enhanced switch statement
            switch (result.Average)
            {
                case var g when g >= 95:
                    result.Letter = 'A';
                    break;
                case var g when g >= 90:
                    result.Letter = 'B';
                    break;
                case var g when g >= 85:
                    result.Letter = 'C';
                    break;
                case var g when g >= 80:
                    result.Letter = 'D';
                    break;
                case var g when g >= 75:
                    result.Letter = 'E';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

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
        // cannot use implicit typing (var) and almost always private to retain purity of OOP.
        // Fields are normally updated using proprties.

        // one way to avoid exception regarding null values is to explicitly
        // set the value of the field.
        // List<double> grades = new List<double>();

        // part of when setting a constructor - would initially be null
        // then when gotten to the constructor, would be assigned an empty list?
        private List<double> grades;

        // private keyword means only this class has access to this field
        // or method.
        // If this is a public field, its name should be capitalized. Convention
        // dictates that any public field or method should be capitalized.

        // Properties
        // This property Name is being used to GET and SET the field name.
        // The following is the old way of C# being verbose when defining properties and fields. field name to property Name

        // Commented out because they are now being inherited from the NamedObject class.
        /*public string Name
        {
            // Getter
            get
            {
                return name;
            }
            // Setter
            set
            {
                // The value keyword represents what this property is
                // being assigned to, sortof like a variable.
                // Check to validate the value
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new NullReferenceException($"Invalid {nameof(value)} cannot be null or empty.");
                }
            }
        }*/
        private string name;

        // C#'s new way called AutoProperty; creates a private field in the background and also creates a property getter and setter.
        /*
        public string Name
          {
              get;set;
          }
         */


        // private Stats result;

        // Readonly - can only be assigned in constructor
        // readonly string category = "Math";

        // Constant - can never be reassigned but can be viewed if given public keyword
        //          - usually named with all caps to represent const
        //          - treated as static members of the class, meaning has to be accessed by the class itself, not the instance, ie. InMemoryBook.CATEGORY
        public const string CATEGORY = "School of Science";
    }
}