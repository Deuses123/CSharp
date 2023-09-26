using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{
    struct Student
    {
        public string FullName;
        public string GroupNumber;
        public int[] Grades;

        public Student(string fullName, string groupNumber, int[] grades)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            Grades = grades;
        }
        public double GetAverageGrade()
        {
            return Grades.Average();
        }

        public bool HasOnlyGoodGrades()
        {
            return Grades.All(grade => grade == 4 || grade == 5);
        }

    }
}
