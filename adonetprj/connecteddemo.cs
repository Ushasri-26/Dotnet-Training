using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;

namespace adonetprj
{
    internal class connecteddemo
    {
        public void ShowEmployee()
        {
            //display all records from employee table
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open(); // creates a new connection
            //writes a command
            SqlCommand cmd = new SqlCommand("select * from employee", con);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read()) // run the loop only if record is found
            {
                // it reads row by row
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}"); //prints empid
            }
            con.Close();


        }
        public void AddEmployee()
        {
            //Add records to employee table
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open(); // creates a new connection
            //writes a command
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining (yyyy-mm-dd):");
            string doj = Console.ReadLine();
            Console.WriteLine("Enter DeptID:");
            int deptid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"insert into Employee  values ('{name}',{salary} , '{doj}' , {deptid}  )", con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Inserted is: " +  rowaffected);
            con.Close();
        }
        public void DeleteEmployee()
        {
            //Delete records from employee table
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open(); // creates a new connection
            //writes a command
            Console.WriteLine("Enter Employee Id to Delete:");
            int empid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"delete from Employee where EmpId= {empid}");
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records Delete is " + rowaffected);
            con.Close();
        }
        public void UpdateEmployee()
        {
            //Update to employee table
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open(); // creates a new connection
            //writes a command
            Console.WriteLine("Enter Employee Id to update:");
            int empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            int salary= Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"update newEmployee set Salary = {salary}  where Empid= {empid}", con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Total Records  is " + rowaffected);
            con.Close();
        }
        public void ShowProcedure()
        {
            //display all records from employee table
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open(); // creates a new connection
            //writes a command
            SqlCommand cmd = new SqlCommand("sp_getemp", con);
            SqlParameter p1 = new SqlParameter("@d", 10); //create a parameter
            SqlParameter p2 = new SqlParameter("@sal",45000);
            cmd.Parameters.Add(p1); //attaching parameter to procedure
            cmd.Parameters.Add(p2);
            cmd.CommandType = System.Data.CommandType.StoredProcedure; //represents type of command u are trying to execute
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // run the loop only if record is found
            {
                // it reads row by row
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}"); //prints empid
            }
            con.Close();
        }
        public void EmpTransaction()
        {
            SqlTransaction tr = null;
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
                con.Open(); // creates a new connection
                tr = con.BeginTransaction();
                //writes a command
                SqlCommand cmd1 = new SqlCommand("insert into one values(2,'Bhavya')", con);
                SqlCommand cmd2 = new SqlCommand("insert into two values(2,'Anurag')", con);
                cmd1.Transaction = tr;
                cmd2.Transaction = tr;
                int rowaffected1 = cmd1.ExecuteNonQuery();
                int rowaffected2 = cmd2.ExecuteNonQuery();
                Console.WriteLine("Total Records inserted is " + rowaffected1);
                Console.WriteLine("Total records inserted is " + rowaffected2);
                tr.Commit();
                con.Close();
            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("Could not complete...try again..");
            }
        }
    }
}
