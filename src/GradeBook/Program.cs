using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kevin's Grade Book");
            book.AddGrade(8.9);
            book.AddGrade(9.1);
            book.AddGrade(7.7);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
