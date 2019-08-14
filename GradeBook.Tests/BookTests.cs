using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);


            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(77.3, result.Low);
            Assert.Equal(90.5, result.High);
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal('B', result.Letter);

        }

        [Fact]
        public void CheckGrade()
        {
            var book = new Book("");
            book.AddGrade(105.1);

            //need check for over under grade.


        }
    }
}
