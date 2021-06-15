using System;
using System.Collections.Generic;

namespace GradeBook {


  public delegate void GradeAddedDelegate(object sender, EventArgs args);
  
  public class TiteledObject
  {
		public TiteledObject(string title)
		{
      this.title = title;
		}

		public string title  {
        get;
        set;
     }
  }

  
  public class Book : TiteledObject {
    private List<double> grades;

    // events
    public event GradeAddedDelegate GradeAdded;


    public Book(string title): base(title) {
      this.grades = new List<double>();
    }


    public void AddLetterGrade(char lettergrade) {
      switch (lettergrade)
      {
        case 'A':
          AddGrade(90);
          break; 

        case 'B':
          AddGrade(80);
          break; 
        
        default:
          AddGrade(0);
          break;
      }
    }

    public void AddGrade(double grade) 
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
        if (GradeAdded != null)
        {
          GradeAdded(this, new EventArgs());
        }
        return;
      } 
      throw new ArgumentException($"Invalid Argument {nameof(grade)}, {grade}");
    }

    public string Book_title
    {
      get {
        return title;
      }
      set
      {
        if (!String.IsNullOrEmpty(value))
        {
          title = value;
        }
      }
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

      switch (result.Avarage)
      {
        case var d when d >= 90.0:
          result.Letter = 'A';
          break;

        case var d when d >= 80.0:
          result.Letter = 'B';
          break;

        case var d when d >= 60.0:
          result.Letter = 'C';
          break;

        case var d when d >= 50.0:
          result.Letter = 'D';
          break;

        case var d when d >= 40.0:
          result.Letter = 'E';
          break;

        default:
          result.Letter = 'F';
          break;
      }

      return result;
    }


    static void OnGradeAdded(object sender, EventArgs args)
    {
      Console.WriteLine("Grade added");
    }




  }

}