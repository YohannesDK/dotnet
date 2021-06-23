using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
		{
			List<Book> booklist = new List<Book>();

			var title = "title";
			var book = new Book(title);
			book.GradeAdded += OnGradeAdded;


			char grade = EnterGrade(book);

			var stats = book.getStatistics();

			Console.WriteLine($"Book: {book.Book_title}");

			Console.WriteLine($"Book High:    {stats.High}");
			Console.WriteLine($"Book low :    {stats.Low}");
			Console.WriteLine($"Book Avarage: {stats.Avarage}");
			Console.WriteLine($"Book Letter : {stats.Letter}");
		}

		private static char EnterGrade(Book book)
		{
			char grade;
			do
			{
				Console.WriteLine("Enter a grade or 'q' to quit: ");
				var charIn = Console.ReadLine();

				var validChar = char.TryParse(charIn, out grade);
				if (!validChar || grade == 'q')
				{
					Console.WriteLine(validChar);
					break;
				}
				book.AddLetterGrade(grade);
			} while (grade != 'q');
			return grade;
		}

		static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Grade Was added");
        }

    }
}
