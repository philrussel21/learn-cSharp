using System;
using Xunit;

namespace GradeBook.Tests
{
    // Convention is ClassNameTests and filename should match className
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // Arrange

            // By default, the compiler wouldn't know what this class is bec it was from another project,
            // in order to create a reference, you can use the terminal cmd `dotnet add reference path_to_csProj` to this curr dir
            var book = new Book("");
            book.AddGrade(89.2);
            book.AddGrade(69.2);
            book.AddGrade(75.5);

            // Act
            var result = book.GetStats();


            // Assert
            Assert.Equal(77.97, result.Average, 2);
            Assert.Equal(69.2, result.Low,1);
            Assert.Equal(89.2, result.High,1);
        }
    }
}
