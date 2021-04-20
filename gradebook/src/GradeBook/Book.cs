using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    // abstract classes are used to provide common functionality to child classes and
    // force child to have own implementation of abstract members. it cannot be initialized,
    // so individually it is not an object, but takes part in behaviour of child class.
    // on its child classes, the method and properties inherited from this abstract class
    // needs to be overridden by the child's own implementation.
    public abstract class Book : NamedObject
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
    }
}
