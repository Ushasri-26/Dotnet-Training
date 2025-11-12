using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOverloading_Demo
{
    public class
        EmployeeDirectory
    {
        private string[] EmpNames = { "Usha", "Monika", "Anvith", "Uday" };
        private int[] EmpIDs = { 101, 102, 103, 104 };
        public string this[int index]
        {
            get { return EmpNames[index]; }
            set { EmpNames[index] = value; }
        }
        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < EmpIDs.Length; i++)
                {
                    if (EmpIDs[i].ToString() == Empid)
                        return EmpNames[i];
                }
                return "Employee Not Found";
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                EmployeeDirectory empDirectory = new EmployeeDirectory();
                Console.WriteLine(empDirectory[0]);
                Console.WriteLine(empDirectory["102"]);
                Console.WriteLine(empDirectory[2]);
                Console.WriteLine(empDirectory["104"]);
                //Console.WriteLine(empDirectory[1]);
                //Console.WriteLine(empDirectory["101"]);
                //Console.WriteLine(empDirectory[3]);
                //Console.WriteLine(empDirectory["102"]);
                Console.ReadLine();
            }
        }
    }
}
