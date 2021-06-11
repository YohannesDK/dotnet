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

            Assert.Equal(book.get_book_title(), title);
        }

        [Fact]
        public void Avarage_Book_grades_test()
        {
            // arrange
            var book = new Book("Test");
            book.AddGrade(10.1);
            book.AddGrade(35.3);
            book.AddGrade(65.1);

            // act
            var result = book.getStatistics();

            Assert.Equal((10.1 + 35.3 + 65.1)/3, result.Avarage, 1);
        }
    }
}
