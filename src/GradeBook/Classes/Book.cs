using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
            while(String.IsNullOrEmpty(name)) 
            {
                try{
                    if(String.IsNullOrEmpty(name))
                    { 
                        throw new ArgumentException("Book name can't be empty");
                    }
                }
                catch(ArgumentException ex )
                {
                    Console.WriteLine(ex.Message);
                }
                name = Console.ReadLine();
            }

            Name = name;
        }

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    }
}