using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange section
            var book = new Book("");
            book.AddGrade(85.1);
            book.AddGrade(90.1);
            book.AddGrade(77.1);

            // act section
            var result = book.GetStatistics();

            // assert section
            Assert.Equal(84.1, result.Average);
            Assert.Equal(90.1, result.High);
            Assert.Equal(77.1, result.Low);
        }
    }
}
