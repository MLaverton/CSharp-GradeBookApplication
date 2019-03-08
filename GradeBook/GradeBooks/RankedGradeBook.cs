using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    using GradeBook.Enums;

    class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) :base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
            IsWeighted = isWeighted;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            var studentCount = Students.Count;
          
            if (studentCount < 5)
            {
                throw (new InvalidOperationException("Ranked-grading requires a minimum of 5 students"));
            }

            var thresh = (int)Math.Ceiling(studentCount * 0.2);
            var studentAveragesList = Students.OrderByDescending(x => x.AverageGrade).Select(l => l.AverageGrade).ToList();


            if (studentAveragesList[thresh-1] <= averageGrade)
            {
                return 'A';
            }
            if (studentAveragesList[thresh*2-1] <= averageGrade)
            {
                return 'B';
            }
            if (studentAveragesList[thresh * 3 - 1] <= averageGrade)
            {
                return 'C';
            }
            if (studentAveragesList[thresh * 4 - 1] <= averageGrade)
            {
                return 'D';
            }

            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }

    }
}
