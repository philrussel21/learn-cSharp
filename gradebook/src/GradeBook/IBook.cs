using System;
using System.Collections.Generic;

namespace GradeBook
{
    // interface represents a contract. A set of public methods any implementing class has to have.
    // Technically, the interface only governs syntax, i.e. what methods are there, what arguments they get
    // and what they return. Usually they encapsulate semantics as well, although that only by documentation.
    interface IBook
    {
        void AddGrade(double grade);
        Stats GetStats();
        string Name { get; }
    }
}
