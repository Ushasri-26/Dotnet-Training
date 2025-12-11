using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace adonetprj
{
    internal class disconnected
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();// can hold the output(many output)
        SqlDataAdapter da,da1;
        public void ShowAllEmployee()
        {
            //fill : run the query+store the output in dataset
            //display all employee records
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            //no need to open and close connection

            da = new SqlDataAdapter("select * from Employee", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//it is a part of adapter class
            SqlCommandBuilder sb = new SqlCommandBuilder(da);//build the command as per the chnages happened in dataset/datatable
            //SqlDataAdapter da1 = new SqlDataAdapter("select * from Department", con);
            
            da.Fill(ds,"emp");//fill is a method of adapter.it will execute the query after the output will be stored in datasets
            //now ds contains output of employee table
            //da1.Fill(ds,"dept");//now ds contains output of emp+dept 
            dt = ds.Tables["emp"];//now dt contains the output of employee 
            for (int i = 0; i < dt.Rows.Count; i++)//count represents the total no.of rows
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
            }
            //Console.WriteLine(ds.Tables["dept"].Rows[1][1]);
        }

        public void SearchEmployee()
        {
            //Serach employee by id
            Console.WriteLine("Enter id:");
            int id=int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);//search happens from datatable not from database
            if (drr != null)
            {
                Console.WriteLine(drr[0]);
                Console.WriteLine(drr[1]);
                Console.WriteLine(drr[2]);
                Console.WriteLine(drr[3]);
                Console.WriteLine(drr[4]);
            }
            else
            {
                Console.WriteLine("No such key exists!");
            }
        }
        public void AddEmployee()
        {
            //new employee details
            //all crud operation are done by using datatable
            //dt.Rows.Count: total rows present in datatable
            //dt.Rows.Add: adding new rows
            //dt.Rows.Find: Search row by primary key
            //dt.Rows.Remove: delete existing row
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining (yyyy-mm-dd):");
            DateTime doj = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Dept ID:");
            int deptid = Convert.ToInt32(Console.ReadLine());
            dt.Rows.Add(null,name,salary,doj,deptid);
            //dt.Rows.Add(null,"Bhanu", 40000, "2020-1-12", 20);//a new rows is added to datatable
            //how to update this changes to database?
            int rowsaffected= da.Update(dt);
            Console.WriteLine("total rows inserted is:" + rowsaffected);

        }
        public void DeleteEmployee()
        {
            //search a row which u want to delete
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);//search happens from datatable not from database
            drr.Delete();//this will remove row from datatable
            int rowsaffected=da.Update(dt);
            Console.WriteLine("total rows Deleted is:" + rowsaffected);
        }
        public void UpdateEmployee()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);//search happens from datatable not from database
            drr[2] = 65000;
            int rowsaffected=da.Update(dt); 
            Console.WriteLine("total rows Updated is:" +rowsaffected);

        }
        public void FilterEmployee()
        {
            //how can u search non primary key column
            Console.WriteLine("Rows after filter is as follows");
            Console.WriteLine("=========================================");
            DataView dv = new DataView(dt);
            dv.RowFilter = "salary>50000 and Deptid=10";
            foreach(DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }
        public void StoreinXML()
        {
            //ds.ReadXml(); reads the xml file and stores in dataset
            //ds.WriteXml();creates xml file and write all the dataset records to xml
            //ds.WriteXml("C:\\CSharp\\employee.xml");
            dt.Rows.Add(null, "Ravi", 100000, "2018-11-24", 20);
            dt.Rows.Add(null, "Rakesh", 25000, "2023-09-13", 10);
            ds.WriteXml("C:\\CSharp\\employee.xml", XmlWriteMode.DiffGram);
            //shows which rows inserted,deleted or updated
            Console.WriteLine("conected sucessfully");
        }
        public void changes()
        {
            // 27 records in datatable
            // show me only those records from datatable where new changes has been taken place
            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);// a new rows is added to datatable
            Console.WriteLine("============================");
            Console.WriteLine("Following are new changes : ");
            if (ds.HasChanges())
            {
                DataSet newds = ds.GetChanges();// newds contains only 2 rows

                for (int i = 0; i < newds.Tables["emp"].Rows.Count; i++)
                {

                    Console.WriteLine(newds.Tables["emp"].Rows[i][0]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][1]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][2]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][3]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][4]);
                }

            }
            else
            {
                Console.WriteLine("No Changes has happened in datatable ");
            }
            // ds.GetChanges
        }
        public void relationship()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=infinitedb;server=ICS-LT-BXZYBB4\\SQLEXPRESS");
            //no need to open and close connection
            da = new SqlDataAdapter("select * from employee", con);
            da1 = new SqlDataAdapter("select * from department", con);
            da.Fill(ds, "emp");//Foreign key
            da1.Fill(ds, "dept");//Primary key
            dt = ds.Tables["emp"];
            dt2 = ds.Tables["dept"];
            DataRelation drr = new DataRelation("hi", dt2.Columns[0], dt.Columns[4]);
            ds.Relations.Add(drr); // now datasetknows which column is pk
            // when u enter data in foreign key table, it has to exist in primary key table
            //dt.Rows.Add(null, "Honey", 30000, "1-5-2020", 90);
            Console.WriteLine("Done");
        }
    }
    }
