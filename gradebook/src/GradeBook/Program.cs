using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> booklist = new List<Book>();
            double sum = 0.0;
            int count = 0;

            // for (int i = 0; i < 10; i++)
            // {
            //     Book newBook = new Book($"Book {i}");

            //     Random rd = new Random();
            //     int rand_base_grade = rd.Next(1, 6);

            //     newBook.AddGrade(rand_base_grade + (i/10));
            //     booklist.Add(newBook);
            // }
            
            // foreach (var book in booklist)
            // {
            //     Console.WriteLine($"Book_title:{book.get_book_title()}");
            //     var grades = book.get_grades(); 
            // }

            var title = "title";
            var book = new Book(title);
            book.GradeAdded += OnGradeAdded;

            char grade = 'Z';

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

            var stats = book.getStatistics();

            Console.WriteLine($"Book: {book.Book_title}");

            Console.WriteLine($"Book High:    {stats.High}");
            Console.WriteLine($"Book low :    {stats.Low}");
            Console.WriteLine($"Book Avarage: {stats.Avarage}");
            Console.WriteLine($"Book Letter : {stats.Letter}");
            // Console.WriteLine($"Avarage = {sum / count}");
        }
    
        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Grade Was added");
        }

    }
}
