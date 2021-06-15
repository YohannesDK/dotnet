using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Book_title_test()
        {
            var title = "title";
            var book = new Book(title);

            Assert.Equal(book.Book_title, title);
        }

        [Fact]
        public void Avarage_Book_grades_test()
        {
            // arrange
            var book = new Book("Test");

            // act
            var result = book.getStatistics();

            Assert.Equal('F', result.Letter);
        }
    }
}
