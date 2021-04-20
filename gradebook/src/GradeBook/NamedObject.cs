using System;
using System.Collections.Generic;

namespace GradeBook
{
    // All classes in .NET are inherited from the Object (or object) class, explicitly stated or not.
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
