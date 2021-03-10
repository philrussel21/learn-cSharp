using System;
using Xunit;

namespace GradeBook.Tests
{
    // Convention is ClassNameTests and filename should match className
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

    // Since this method is not a test, it should not have
    // the [Fact] attribute to it
    Book GetBook(string name)
    {
        return new Book(name);
    }
  }
}
