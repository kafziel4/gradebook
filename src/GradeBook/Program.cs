using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string nameInput = GetBookName();
                IBook book = new InMemoryBook(nameInput);
                AccessGradebook(book);
            }
            else
            {
                try
                {
                if (args[0] == "disk")
                {
                    string nameInput = GetBookName();
                    IBook book = new DiskBook(nameInput);
                    AccessGradebook(book);
                }
                else
                {
                    throw new ArgumentException ("Invalid argument");
                }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static string GetBookName()
        {
            Console.WriteLine("Enter a book name");
            var nameInput = Console.ReadLine();
            return nameInput;
        }

        private static void AccessGradebook(IBook book)
        {
            var readWrite = new GradesReadWrite();

            book.GradeAdded += readWrite.OnGradeAdded;

            readWrite.EnterGrades(book);
            readWrite.WriteStatistics(book);
        }
    }
}
