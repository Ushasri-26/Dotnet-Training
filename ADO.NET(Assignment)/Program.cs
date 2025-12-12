using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedArchitecture c = new ConnectedArchitecture();
            c.ShowCourses();
            c.AddNewStudent();
            c.SearchStudByDept();
            c.DisplayEnrolledCourses();
            c.UpdateGrade();
            c.getstoredprocedure();
            DisconnectedArchitecture d = new DisconnectedArchitecture();
            d.LoadData();
            d.ModifyCourseCredits();
            d.InsertNewCourse();
            d.DeleteStudent();
        }
    }
}
