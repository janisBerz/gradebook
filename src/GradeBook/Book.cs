using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {

            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGarde = double.MinValue;
            var lowGarde = double.MaxValue;

            foreach (var number in grades)
            {

                highGarde = Math.Max(number, highGarde);



                lowGarde = Math.Min(number, lowGarde);

                result += number;
            }
            result /= grades.Count;

            Console.WriteLine($"--- {name} ---");
            Console.WriteLine($"The highest grade is {highGarde:N2}!");
            Console.WriteLine($"The lowest grade is {lowGarde:N2}!");
            Console.WriteLine($"The average grade is {result:N2}!");

        }
        private List<double> grades;
        private string name;

    }
}