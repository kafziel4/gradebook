using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            var book = new Book("");
            book.AddGrade(8.9);
            book.AddGrade(9.1);
            book.AddGrade(7.7);

            var result = book.GetStatistics();

            Assert.Equal(8.6, result.Average, 1);
            Assert.Equal(9.1, result.High, 1);
            Assert.Equal(7.7, result.Low, 1);
        }
    }
}
