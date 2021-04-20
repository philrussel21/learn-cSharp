using System;
using Xunit;

namespace GradeBook.Tests
{
    // Convention is ClassNameTests and filename should match className
    public class TypeTests
    {
        [Fact]
        public void CSharPassByRefOnInt()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int num)
        {
            num = 42;
        }

        private int GetInt()
            {
                return 3;
            }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            // By using the ref keyword, you're passing the reference
            // as parameter instead of the value.
            GetBookSetNameWithRef(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        // By using the ref keyword, you're passing the reference
        // as parameter instead of the value.
        void GetBookSetNameWithRef(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            // strings are immutable
            string name = "Phil";
            var newName = MakeUppercase(name);

            Assert.Equal("PHIL", newName);
        }

        private string  MakeUppercase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObj()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Assetion to test if the vars point to the same obj
            Assert.Same(book1, book2);
            // Assert if the two vars reference the same obj
            Assert.True(Object.ReferenceEquals(book1,book2));
        }
    // Since this method is not a test, it should not have
    // the [Fact] attribute to it
        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
  }
}
