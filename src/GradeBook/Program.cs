using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {


            var book = new Book("JB's book");
            book.AddGrade(55.6);
            book.AddGrade(10);
            book.AddGrade(10.4);

            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High:N2}!");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}!");
            Console.WriteLine($"The average grade is {stats.Average:N2}!");



        }
    }
}
