using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("title");
            
            Console.WriteLine($"Book Title: {book.get_book_title()}");
        }
    }
}
