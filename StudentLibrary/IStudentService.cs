using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{ 
    public interface IStudentService
        {
            void ShowAllStudents();
            Student GetStudent(int id);
        }
}
