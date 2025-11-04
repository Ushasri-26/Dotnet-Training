using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array declaration and initialization
            //int[] numArray = new int[5] { 10, 20, 30, 40, 50 };

            ////array declaration
            //int[] myArray2 = new int[5];
            ////myArray2[0] = 100;
            ////myArray2[1] = 120;
            ////myArray2[2] = 130;
            ////myArray2[3] = 140;
            ////myArray2[4] = 150;

            //Console.WriteLine("Enter 5 numbers:");
            ////for loop
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    myArray2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\n Array Elements are \n -------");
            //foreach (var item in myArray2)
            //{
            //    Console.WriteLine(item);
            //}

            //array declarations and initialization
            //int[,] marks = new int[2, 5] { { 60, 70, 80, 80, 50 }, { 70, 80, 90, 80, 80 } };

            //for (int i = 0; i < marks.GetLength(0); i++) // rows
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++) // columns
            //    {
            //        Console.Write(marks[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Example of Dynamic Array size
            //int rowSize, colSize, total;
            //Console.WriteLine("Enter number of rows (or) studemts:");
            //rowSize=Convert.ToInt32(Console.ReadLine());
            //colSize = 5;//fixed no.of subjects
            //int[,] StudentMarks =new int[rowSize, colSize];
            //for (int i = 0; i < rowSize; i++)
            //{
            //    Console.WriteLine($"Enter the marks for Student {i + 1}");
            //    for (int j = 0; j < colSize; j++)
            //    {
            //        Console.WriteLine($"Enter the marks for Subject {j + 1}");
            //        StudentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Dispalying the Marks of Students");
            //for (int i = 0;i < rowSize; i++)
            //{ 
            //    total = 0;
            //    Console.WriteLine("\nStudent 1 Marks are \n");
            //    for (int j = 0;j < colSize; j++)
            //    {
            //        Console.Write(StudentMarks[i, j] + "\t");
            //        total += StudentMarks[i, j];
            //    }
            //    Console.WriteLine($"\nTotal Marks of student {i + 1} is {total} \n");
            //}

            //Example for an Array with reverse
            //Array Reverse is used for only 1D not for 2D or multi dimensional
            //int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (int item in myArray)
            //{
            //    Console.WriteLine(item + "\t");
            //}
            //Array.Reverse(myArray);
            //Console.WriteLine("reverse of array:");
            //foreach (int item in myArray)
            //{
            //    Console.WriteLine(item + "\t");
            //}

            //Jagged Array-These are array of arrays
            //In jagged array columns are not fixed
            //Declare the array of four elements
            //int[][] jaggedArray = new int[4][];

            //jaggedArray[0] = new int[2] { 7, 9 };
            //jaggedArray[1] = new int[4] { 1, 2, 3, 4 };
            //jaggedArray[2] = new int[6] { 1, 2, 3, 4, 5, 6 };
            //jaggedArray[3] = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ////display the elements
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine("Element {0}", i + 1);
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Using string
            //string[][] Members = new string[4][]{
            //   new string[]{"Rocky", "Sam", "Alex"},
            //   new string[]{"Peter", "Sonia", "Prety", "Ronnie", "Dino"},
            //new string[]{"Yomi", "John", "Sandra", "Alex", "Tim", "Shaun"},
            //new string[]{"Teena", "Mathew", "Arnold", "Stallone", "Goddy", "Samson", "Linda"},
            //    };

            //for (int i = 0; i < Members.Length; i++)
            //{
            //    System.Console.Write("Name List ({0}): ", i + 1);

            //    for (int j = 0; j < Members[i].Length; j++)
            //    {
            //        System.Console.Write(Members[i][j] + "\t");
            //    }
            //    System.Console.WriteLine();
            //}
            //Console.ReadKey();
            //Calculator
            //int num1, num2;
            //Calculator calculator = new Calculator(); //instance or object declaartion and initialization

            //Calculator calculator2; //object declaration
            //calculator2 = new Calculator(); //object initialization
            //Console.WriteLine("Enter the First Number:");
            //num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second Number:");
            //num2=Convert.ToInt32(Console.ReadLine());
            //calculator.Addition(num1, num2);
            //calculator.Subtraction(num1, num2);

            //Employee employee = new Employee();
            //employee.AcceptEmployeeDetails();
            //Employee employee2 = new Employee();
            //employee2.AcceptEmployeeDetails();
            //employee.DisplayEmployeeDetails();
            //employee2.DisplayEmployeeDetails();
            //Console.ReadLine();

            //Employee employee = new Employee();
            //int empId;
            //string empName;
            //string designation;
            //Console.WriteLine("Enter the EmployeeId,name,Designation");
            //empId=Convert.ToInt32(Console.ReadLine());
            //empName=Console.ReadLine();
            //designation=Console.ReadLine();
            //employee.AcceptEmployeeDetails(empId, empName, designation);
            //employee.DisplayEmployeeDetails();

            //employee.AcceptEmployeeDetails(id: empId, designation: designation, name: empName); //named parameters
            //employee.DisplayEmployeeDetails();

            //employee.AcceptEmployeeDetails(designation, empName, empId);//named parameters ;

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Addition(b: 20, a: 10));
            //int additionResult = calculator.Addition(15, 45);
            //Console.Write($"addition result is {additionResult} \n average={additionResult / 2}");

            //Calculator calculator = new Calculator();
            //calculator.Calculate(20, 10, out int addResult, out int difference, out int ProductResult, out int divisonResult);
            //Console.WriteLine($"addidition is {addResult} and diif is {difference} and pro is {ProductResult} and div is {divisonResult}");

            Employee employee = new Employee();
            employee.AcceptEmployeeDetails(101, "Usha sri");
            employee.DisplayEmployeeDetails();

            employee.AcceptEmployeeDetails(102, "Monika", "GE");
            employee.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
