using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksEvaluationSystem
{
    internal class Student
    {
        public string Name;
        public int[] SubjectMarks = new int[3];
        public void CalculateResult(out int total,out double average,out string grade)
        {
            total = 0;
            for (int i = 0;i<3; i++)
            {
                total=total+SubjectMarks[i];
            }
            average = total / 3.0;
            if (average >= 90)
                grade = "A+";
            else if (average >= 80)
                grade = "A";
            else if (average >= 70)
                grade = "B";
            else if (average >= 60)
                grade = "C";
            else
                grade = "D";
        }
        public void DisplayResult(int total, double average, string grade)
        {
            Console.WriteLine("\n Student Report");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Name          : " + Name);
            Console.WriteLine("Total Marks   : " + total);
            Console.WriteLine("Average       : " + average);
            Console.WriteLine("Grade         : " + grade);
        }
    }
}
