using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class StudentService : MarshalByRefObject, IStudentService
    {
        private Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            {1, new Student {Name="Usha", Class="ECE", TotalMarks=450, Gender='F'}},
            {2, new Student {Name="Ravi", Class="CSE", TotalMarks=280, Gender='M'}},
            {3, new Student {Name="Geetha", Class="EEE", TotalMarks=520, Gender='F'}},
        };

        public void ShowAllStudents()
        {
            foreach (var s in students)
                Console.WriteLine($"{s.Key} => {s.Value}");
        }

        public Student GetStudent(int id)
        {
            if (id == 0)
                return new Student { Name = "Default", Class = "None", TotalMarks = 0, Gender = '-' };

            if (students.TryGetValue(id, out Student stu))
            {
                if (stu.TotalMarks < 300)
                {
                    try { throw new Exception("Marks less than 300"); }
                    catch (Exception ex) when (ex.Message.Contains("less"))
                    {
                        Console.WriteLine("Exception Filter: Marks < 300");
                    }
                }

                return stu;
            }

            return null;
        }
    }
}
