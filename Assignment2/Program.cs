using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String student_name;
            double marks;
            String grade;
            Console.Write("Enter student name:");
            student_name = Console.ReadLine();
            Console.Write("Enter marks:");
            marks = Convert.ToDouble(Console.ReadLine());
            if (marks >= 90)
                grade = "A+";
            else if (marks > 80 && marks <= 89)
                grade = "A";
            else if (marks > 70 && marks <= 79)
                grade = "B";
            else if (marks > 60 && marks <= 69)
                grade = "C";
            else if (marks > 50 && marks <= 59)
                grade = "D";
            else
                grade = "F";
            Console.WriteLine($"Grade:{grade}");
            Console.ReadLine();


        }
    }
}
