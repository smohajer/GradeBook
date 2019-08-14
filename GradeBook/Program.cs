using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Shabars book");

            while (true)
            {
            Console.WriteLine("Please Input grade (or q for quit):");
            var input = Console.ReadLine();
                if (input=="q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            var stats=book.GetStatistics();
            Console.WriteLine($"The average of the grades are {stats.Average} with a lettergrade of {stats.Letter}, with {stats.High} as the highest and {stats.Low} as the lowest");
        }
    }
}
