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

            for (int i = 0; i < 10; i++)
            {
                Book newBook = new Book($"Book {i}");

                Random rd = new Random();
                int rand_base_grade = rd.Next(1, 6);

                newBook.AddGrade(rand_base_grade + (i/10));

                booklist.Add(newBook);
            }
            
            foreach (var book in booklist)
            {
                Console.WriteLine($"Book_title:{book.get_book_title()}");
                var grades = book.get_grades();

                foreach (var grade in grades)
                {
                    sum += grade;
                    count += 1;
                    Console.WriteLine($"Grade: {grade}");
                }
            }

            Console.WriteLine($"Avarage = {sum / count}");
        }
    }
}
