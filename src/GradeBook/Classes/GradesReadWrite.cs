using System;

namespace GradeBook
{
    public class GradesReadWrite
    {
        public void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var gradeInput = Console.ReadLine();

                if (gradeInput == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(gradeInput);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

        public void WriteStatistics(IBook book)
        {
            var stats = book.GetStatistics();

            if(stats.Count > 0)
            {
                Console.WriteLine($"For the book named {book.Name}");
                Console.WriteLine($"The lowest grade is {stats.Low:N1}");
                Console.WriteLine($"The highest grade is {stats.High:N1}");
                Console.WriteLine($"The average grade is {stats.Average:N1}");
                Console.WriteLine($"The letter grade is {stats.Letter}");
            }
            else
            {
                Console.WriteLine("There are no grades");
            }
        }
    }
}