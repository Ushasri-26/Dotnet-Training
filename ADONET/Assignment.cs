using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADONET
{
    internal class Assignment
    {
        private SqlConnection con;
        public Assignment()
        {
            try
            {
                con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
                con.Open();
                if (con.State == ConnectionState.Open)
                    Console.WriteLine("Connection  Successfully");
                else
                    Console.WriteLine(" Connection Not sucessful");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);

            }
        }

        public void GetTransactions(DateTime d1, DateTime d2)
        {
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;server=ICS-LT-BXZYBB4\\SQLEXPRESS;database=infinitedb");
                con.Open();
                SqlCommand cmd = new SqlCommand("GetEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@startDate", d1);
                cmd.Parameters.AddWithValue("@endDate", d2);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("Employees between given dates:");

                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception: " + ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine(" Connection Closed");
            }
        }
        public void GetCommonRecords(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;server=ICS-LT-BXZYBB4\\SQLEXPRESS;database=infinitedb");
                con.Open();
                SqlCommand cmd = new SqlCommand(
            "select e.EmpId, e.EmpName, e.Salary, e.DateOfJoin, d.DeptId, d.DeptName " +
            "from Employee e inner join Department d on e.DeptID = d.DeptId " +
            "where d.DeptId = @DeptId",
            con);
                cmd.Parameters.AddWithValue("@DeptId", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}  {dr[5]}");
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
        }
        public void InsertRecordsusingtrans()
        {
            SqlTransaction tr = null;

            try
            {
                Console.WriteLine("Enter Department ID:");
                int deptId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Department Name:");
                string deptName = Console.ReadLine();

                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Date of Join (yyyy-mm-dd):");
                DateTime doj = Convert.ToDateTime(Console.ReadLine());
                tr = con.BeginTransaction();
                SqlCommand cmdDept = new SqlCommand(
                    "INSERT INTO Department (DeptID, DeptName) VALUES (@DeptID, @DeptName)",
                    con, tr);
                cmdDept.Parameters.Add(new SqlParameter("@DeptID", deptId));
                cmdDept.Parameters.Add(new SqlParameter("@DeptName", deptName));
                SqlCommand cmdEmp = new SqlCommand(
                    "INSERT INTO Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                    "VALUES (@EmpName, @Salary, @DateOfJoin, @DeptID)",
                    con, tr);
                cmdEmp.Parameters.Add(new SqlParameter("@EmpName", empName));
                cmdEmp.Parameters.Add(new SqlParameter("@Salary", salary));
                cmdEmp.Parameters.Add(new SqlParameter("@DateOfJoin", doj));
                cmdEmp.Parameters.Add(new SqlParameter("@DeptID", deptId));

                int deptRows = cmdDept.ExecuteNonQuery();
                int empRows = cmdEmp.ExecuteNonQuery();
                tr.Commit();

                Console.WriteLine("\nTransaction Successful.");
                Console.WriteLine("Department rows inserted: " + deptRows);
                Console.WriteLine("Employee rows inserted: " + empRows);
            }
            catch (SqlException ex)
            {
                if (tr != null)
                {
                    tr.Rollback();
                }
                Console.WriteLine("\nTransaction Failed. Rolled back.");
                Console.WriteLine("SQL Error in InsertRecordsusingtrans: " + ex.Message);
            }
            catch (FormatException)
            {
                if (tr != null)
                {
                    tr.Rollback();
                }
                Console.WriteLine("\nInvalid input format. Transaction rolled back.");
            }
        }
        public void InsertAndFetchIdentity()
        {
            try
            {
                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Date of Join (yyyy-mm-dd):");
                DateTime doj = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter DeptID:");
                int deptId = Convert.ToInt32(Console.ReadLine());
                string insertQuery =
                    "INSERT INTO Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                    "VALUES (@EmpName, @Salary, @DateOfJoin, @DeptID); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                cmdInsert.Parameters.Add(new SqlParameter("@EmpName", empName));
                cmdInsert.Parameters.Add(new SqlParameter("@Salary", salary));
                cmdInsert.Parameters.Add(new SqlParameter("@DateOfJoin", doj));
                cmdInsert.Parameters.Add(new SqlParameter("@DeptID", deptId));

                object result = cmdInsert.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    Console.WriteLine("Could not retrieve new identity value.");
                    return;
                }

                int newEmpId = Convert.ToInt32(result);
                Console.WriteLine($"\nNew Employee inserted with EmpID: {newEmpId}");
                string selectQuery =
                    "SELECT EmpID, EmpName, Salary, DateOfJoin, DeptID " +
                    "FROM Employee WHERE EmpID = @EmpID";

                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.Add(new SqlParameter("@EmpID", newEmpId));
                SqlDataReader dr = cmdSelect.ExecuteReader();
                Console.WriteLine("\nValidating the inserted record:\n");
                if (dr.Read())
                {
                    Console.WriteLine(
                        $"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}");
                }
                else
                {
                    Console.WriteLine("No record found for the new EmpID.");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in InsertAndFetchIdentity: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter correct values.");
            }
        }
        public void ShowEmployeesAndDepartments()
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand($"select * from Employee;select* from Department", con);
                SqlDataReader dr = cmd1.ExecuteReader();
                Console.WriteLine("Employees:");
                while (dr.Read())
                {

                    Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
                }
                if (dr.NextResult())
                {
                    Console.WriteLine("Departmetns:");
                    while (dr.Read())
                    {

                        Console.WriteLine($"{dr[0]}  {dr[1]}  ");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }

        }
        public void Getdetails()
        {
            try
            {
                Console.WriteLine("enter empid");
                int emid = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("sp_GetEmployeeDet", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@Empid", emid);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@DateofJoin", SqlDbType.Date);
                p2.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@DeptId", SqlDbType.Int);
                p3.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p3);
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.Parameters["@DateofJoin"].Value);
                Console.WriteLine(cmd.Parameters["@DeptId"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}