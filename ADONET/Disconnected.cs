using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADONET
{
    internal class Disconnected
    {
        DataTable dt = new DataTable();
        DataTable dtEmp = new DataTable();
        DataTable dtDept = new DataTable();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        SqlDataAdapter da, da1;
        public void ShowAllRecords()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from Employee", con);
            da1 = new SqlDataAdapter("select * from Department", con);
            da.Fill(ds, "emp");
            da1.Fill(ds, "dept");
            dtEmp = ds.Tables["emp"];
            dtDept = ds.Tables["dept"];
            Console.WriteLine("EMPLOYEE RECORDS");
            foreach(DataRow r in dtEmp.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]} {r[3]} {r[4]} ");
            }
            Console.WriteLine("DEPARTMENT RECORDS");
            foreach (DataRow r in dtDept.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} ");
            }
        }
        public void FilterEmployee()
        {
            Console.WriteLine("Rows after filter as follows:");
            Console.WriteLine("==================================");
            DataView dv = new DataView(dtEmp);
            dv.RowFilter = "Salary>47000 and Deptid=10 and EmpName like 'M%'";
            dv.Sort = "EmpName asc";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine($"{item[0]} {item[1]} {item[2]} {item[3]} {item[4]}");
            }
        }
        public void ShowTotalTables()
        {
            Console.WriteLine("Total number of tables in DataSet is:");
            Console.WriteLine(ds.Tables.Count);
            foreach (DataTable tb1 in ds.Tables)
            {
                Console.WriteLine(tb1.TableName);
            }
        }
        public void CopyTable()
        {
            Console.WriteLine("Copying data from SqlDataReader to DataTable");
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Department", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            Console.WriteLine("department table records");
            Console.WriteLine("department table");
            foreach (DataRow r in  dt.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]}");
            }
        }
        public void ShowCustomerOrders()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from Customers", con);
            da1 = new SqlDataAdapter("select * from Orders", con);
            da.Fill(ds1, "cus");
            da1.Fill(ds2, "ord");
            ds1.Merge(ds2);
            Console.WriteLine("Total Tables in ds1: " + ds1.Tables.Count);
            Console.WriteLine("Customers Table");
            dt = ds1.Tables["cus"];
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]}");
            }
            Console.WriteLine("Orders Table");
            dt = ds1.Tables["ord"];
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]}");

            }
        }
        public void ReadXmlData()
        {
            ds.ReadXml("C:\\CSharp\\Customer.xml");
            dt = ds.Tables["CUST1"];
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]} ");
            }
        }
    }
}

