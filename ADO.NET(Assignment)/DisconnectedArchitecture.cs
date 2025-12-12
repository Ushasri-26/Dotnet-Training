
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Assignment_
{
    internal class DisconnectedArchitecture
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlDataAdapter da1;
        //Task 3.1 – Load Students and Courses into a DataSet
        //Show the data in tabular format.
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from Students", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1 = new SqlDataAdapter("select * from Courses", con);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "stud");
            da1.Fill(ds, "course");
            dt = ds.Tables["stud"];
            Console.WriteLine("---------------Students table---------------");
            Console.WriteLine("ID\tFullName\tEmail\tDepartment\tYearOfStudy");
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r[0]}     {r[1]}     {r[2]}    {r[3]}   {r[4]}");
            }
            dt = ds.Tables["course"];
            Console.WriteLine("---------------Courses table---------------");
            Console.WriteLine("ID\tCourseName\tCredits\tSemester");
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r[0]}     {r[1]}      {r[2]}      {r[3]}");
            }
        }
         //Task 3.2 – Modify course credits(Disconnected Mode)
         //Steps:
        //1. Load Courses into DataSet
        //2. Ask user for CourseId
       //3. Update Credits
       //4. Use SqlCommandBuilder to update D
        public void ModifyCourseCredits()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da1 = new SqlDataAdapter("SELECT * FROM Courses", con);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds, "courses");

            dt = ds.Tables["courses"];
            Console.WriteLine("Enter course id to modify credits:");
            int cid = Convert.ToInt16(Console.ReadLine());
            DataRow dr = dt.Rows.Find(cid);
            if (dr != null)
            {
                Console.WriteLine("Enter new Credits:");
                dr["Credits"] = Convert.ToInt16(Console.ReadLine());
                SqlCommandBuilder sb = new SqlCommandBuilder(da1);
                int rowsAffected = da1.Update(dt);
                Console.WriteLine("Rows updated: " + rowsAffected);
            }
            else
            {
                Console.WriteLine("No such course exists!");
            }
        }
        //Task 3.3 – Insert a new course(Disconnected Mode)
        //Add new row → Update DB.
        public void InsertNewCourse()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da1 = new SqlDataAdapter("SELECT * FROM Courses", con);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds, "courses");
            dt = ds.Tables["courses"];
            Console.WriteLine("Enter Course Name:");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter Credits:");
            int credits = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Semester:");
            string sem = Console.ReadLine();
            DataRow dr = dt.NewRow();
            dr["CourseName"] = cname;
            dr["Credits"] = credits;
            dr["Semester"] = sem;
            dt.Rows.Add(dr);
            SqlCommandBuilder sb = new SqlCommandBuilder(da1);
            int rowsAffected = da1.Update(dt);
            Console.WriteLine("Rows inserted: " + rowsAffected);
        }
        //Task 3.4 – Delete a student(Disconnected Mode)
        //Delete student record inside DataTable
        public void DeleteStudent()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from Students", con);
            da1 = new SqlDataAdapter("select * from Enrollments", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            SqlCommandBuilder cb1 = new SqlCommandBuilder(da1);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "stu");
            da1.Fill(ds, "enroll");
            dt = ds.Tables["stu"];
            dt1 = ds.Tables["enroll"];
            Console.WriteLine("Enter student id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (DataRow r in dt1.Rows)
            {
                if (Convert.ToInt32(r["Student"]) == id)
                    r.Delete();
            }
            DataRow row = dt.Rows.Find(id);
            if (row != null)
                row.Delete();
            else
            {
                Console.WriteLine("No such student exists!");
                return;
            }
            DataRow dr = dt.Rows.Find(id);
            row.Delete();
            int rowsaffected1 = da1.Update(dt1);
            int rowsaffected = da.Update(dt);
            Console.WriteLine("the no of rows affected in student table" + rowsaffected);
            Console.WriteLine("the no of rows affected in enrolment table" + rowsaffected1);
        }
    }
}

