using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksEvaluationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Marks Evaluation System =====");

            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter details for Student #" + (i + 1));

                Student s = new Student();

                Console.Write("Enter Student Name: ");
                s.Name = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for Subject " + (j + 1) + ": ");
                    s.SubjectMarks[j] = Convert.ToInt32(Console.ReadLine());
                }

                int total;
                double average;
                string grade;

                s.CalculateResult(out total, out average, out grade);
                s.DisplayResult(total, average, grade);
            }
        }
    }
}
