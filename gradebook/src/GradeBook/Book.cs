using System;
using System.Collections.Generic;

namespace GradeBook {
  public class Book {
    private string book_title;
    private List<double> grades;

    public Book(string title) {
      this.book_title = title;
      this.grades = new List<double>();
    }

    public void AddGrade(double grade) 
    {
      grades.Add(grade);
    }

    public string get_book_title() {
      return book_title;
    }

    public List<double> get_grades() {
      return grades;
    }

    public Statistics getStatistics() {

      var result = new Statistics();
      result.Avarage = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach (var grade in grades)
      {
        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Avarage += grade;
      }

      result.Avarage /= grades.Count;

      return result;
    }
  }

}