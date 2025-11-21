using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    internal class Class1
    {
        public interface IStudentService
        {
            void ShowAllStudents();
            Student GetStudent(int id);
        }
    }
}
