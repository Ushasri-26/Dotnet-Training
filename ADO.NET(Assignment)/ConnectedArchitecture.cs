using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Assignment_
{
    internal class ConnectedArchitecture
    {
        //Task 2.1 – Display all courses
        //Show: CourseId, CourseName, Credits, Semester
        public void ShowCourses()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("select CourseId, CourseName, Credits, Semester from Courses", con);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("Show Courses:");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}   {dr[3]}");
            }
            con.Close();
        }
        // Task 2.2 – Add a new student
        // Input:
        // FullName
        //• Email
        //• Department
        //• YearOfStudy
        //Insert via parameterized query
        public void AddNewStudent()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            Console.WriteLine("Enter Full name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department:");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter Year Of Study:");
            int year = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into Students(FullName, Email, Department, YearOfStudy) values(@n, @e, @d, @y)", con);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@d", dept);
            cmd.Parameters.AddWithValue("@y", year);
            int rowsaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted: " + rowsaffected);
            con.Close();
        }
        //Task 2.3 – Search students by department
        //Input example: “Computer Science”
        //Display matching students.
        public void SearchStudByDept()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            Console.WriteLine("Enter Department:");
            string dept = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select StudentId, FullName, Email, YearOfStudy from Students where Department = @dept", con);
            cmd.Parameters.AddWithValue("@dept", dept);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("Search Students by department:");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}   {dr[3]}");
            }
            con.Close();
        }
        //Task 2.4 – Display enrolled courses for a student
        //Input: StudentId
        //Output example:
        //Course Name | Credits | Enroll Date | Grad
        public void DisplayEnrolledCourses()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            Console.WriteLine("Enter Student id ");
            int id = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("select c.CourseName, c.Credits, e.EnrollDate, e.Grade from Enrollments e join Courses c on e.CourseId = c.CourseId where e.Student = @sid", con);
            cmd.Parameters.AddWithValue("@sid", id);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("Course Name | Credits | Enroll Date | Grade");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} | {dr[1]}  | {dr[2]}  | {dr[3]}");
            }
            dr.Close();
            con.Close();
        }
        //Task 2.5 – Update grade(Connected Mode)
        //Input:
        //• EnrollmentId
        //• Grade(A/B/C/D/F)
        //Update Enrollments table
        public void UpdateGrade()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            Console.WriteLine("Enter Enrollment Id:");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade (A/B/C/D/F):");
            string grade = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("update Enrollments set Grade = @g where EnrollmentId = @id", con);
            cmd.Parameters.AddWithValue("@g", grade);
            cmd.Parameters.AddWithValue("@id", eid);
            int rowsaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Updated: " + rowsaffected);
            con.Close();
        }
        public void getstoredprocedure()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            try
            {
                con.Open();
                Console.WriteLine("Enter Semester:");
                string semester = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("usp_GetCoursesBySemester", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@semester", semester);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("CourseId | CourseName | Credits | Semester");
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
