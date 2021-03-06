using Xunit;
using System;

namespace GradeBook.Tests;

    public class BookTests
    {
        [Fact]
        public void BooCalculatesAnAVerageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(75.3);
            book.AddGrade(43.3);

            // actual
            var result = book.GetStatistics();
            
            // assert
            Assert.Equal(69.2, result.Average, 1);
            Assert.Equal(89.1, result.High, 1);
            Assert.Equal(43.3, result.Low, 1);
            Assert.Equal('D', result.Letter);
        }
}