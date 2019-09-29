using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {


            var book = new Book("JB's book");
            book.AddGrade(10);
            book.AddGrade(10);
            book.AddGrade(10.4);
            book.ShowStatistics();

        }
    }
}
