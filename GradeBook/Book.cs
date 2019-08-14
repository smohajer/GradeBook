using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        #region Fields
        List<double> grades;
        public string Name;
        #endregion
         
        #region Constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }
        #endregion

        #region Methods
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <=100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        

        public Statistics GetStatistics()
        {
            var result = new Statistics
            {
                Average = 0.0,
                High = double.MinValue,
                Low = double.MaxValue
            };

            var index = 0;
            while (index<grades.Count)
            {
                result.Average += grades[index];
                result.High = Math.Max(result.High, grades[index]);
                result.Low = Math.Min(result.Low, grades[index]);
                index++;
            }

            result.Average /= grades.Count;
            switch (result.Average)
            {
                case var d when d >=90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                    default:
                    result.Letter = 'F';
                    break;
            }


            return result;
        }
        #endregion
    }
}
