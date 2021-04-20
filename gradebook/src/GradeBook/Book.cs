using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Abstract classes are used to provide common functionality to child classes and
    // force child to have own implementation of abstract members. it cannot be initialized,
    // so individually it is not an object, but takes part in behaviour of child class.
    // on its child classes, the method and properties inherited from this abstract class
    // needs to be overridden by the child's own implementation.

    // Classes can only inherit/ have one parent class but can accept multiple interfaces.
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);

        // virtual keyword is almost the same as abstract meaning the child class would have its own implementation so ignore
        // my (parent's) implementation.

        public abstract Stats GetStats();
    }
}
