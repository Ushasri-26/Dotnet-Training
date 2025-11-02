using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string firstName,lastName, gender, email;
            //int age;
            //char grade;
            //int score1, score2, score3;
            //Console.WriteLine("Enter the FirstName,lastname,gender,email,age,grade,score1,score2,score3");
            //firstName = Console.ReadLine();
            //lastName = Console.ReadLine();
            //gender = Console.ReadLine();
            //email = Console.ReadLine();
            //age = Convert.ToInt16(Console.ReadLine());
            //grade = Convert.ToChar(Console.ReadLine());
            //score1= Convert.ToInt16(Console.ReadLine());
            //score2= Convert.ToInt32(Console.ReadLine());
            //score3= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Student Info");
            //Console.WriteLine($"Full name = {firstName} {lastName}");
            //Console.WriteLine($" Gender={gender} \n Email = {email} \n Age= {age} \n Grade={grade}");
            //Console.WriteLine($"Score1={score1} \n Score2={score2} \n Score3={score3}");
            //Console.ReadLine();
            //int num = 26;
            //double value = num; //implicit type conversion
            //Console.WriteLine($"num = {num} \n value={value}");

            //double pi = 3.14;
            //int intPi = (int) pi; //explicit type conversion
            //Console.WriteLine($"pi={pi} \n intPi={(int)pi}");
            /*
              *Converting value type to object type is called as Boxing
              *Converting Object type to value type is called as Unboxing
              * */

            //object obj = num; //Boxing
            //int myval = (int)obj; //Unboxing
            //Console.WriteLine($"obj={num} \n myval={(int)pi}");

            //int a = 100;
            //int b = a;
            //Console.WriteLine($"A value is {a} \t b value is ={b}");
            //b = 26;
            //Console.WriteLine($"A value is {a} \t b value is ={b}");

            //string[] names = { "Usha", "sri" };
            //string[] copyNames = names;
            //Console.WriteLine($"names [0] {names[0]} \t names[1] value is ={names[1]}");//value type
            //copyNames[0] = "Uday";
            //Console.WriteLine($"names [o] {names[0]} \t names[1] value is ={names[1]}"); // Reference Type

            //int num = 20;          // Value type stored in stack
            //object obj = num;      // BOXING - value copied to heap
            //int newNum = (int)obj; // UNBOXING - value copied back to stack

            //Console.WriteLine($"num = {num}, obj = {obj}, newNum = {newNum}");
            //int employeeId;
            //string employeeName, designation;
            //decimal salary;
            //Console.WriteLine("Enter Employee Id,Name,Designation and salary");
            //employeeId = Convert.ToInt32(Console.ReadLine());
            //employeeName = Console.ReadLine();
            //designation = Console.ReadLine();
            //salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"Employee Details");
            //Console.WriteLine($"Employee Id : {employeeId} \n Name : {employeeName} \n Designation = {designation} \n salary : {salary}");
            //Console.ReadLine();

            //int num1, num2, num3;
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2=Convert.ToInt32(Console.ReadLine());
            //num3=Convert.ToInt32(Console.ReadLine());
            //if (num1 >= num2 && num1 >= num3)
            //    Console.WriteLine("Num1 is greatest");
            //else if (num2 >= num1 && num2 >= num3)
            //    Console.WriteLine("num2 is greatest");
            //else
            //    Console.WriteLine("num3 is greatest");

            //Switch
            //Console.WriteLine("Choose the options 1.add \n 2.subtract \n 3.Multiplication \n 4.Division");
            //double n1, n2;
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter first number");
            //n1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter 2nd number");
            //n2 = Convert.ToDouble(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine(n1 + n2);
            //        break;
            //    case 2:
            //        Console.WriteLine(n1 - n2);
            //        break;
            //    case 3:
            //        Console.WriteLine(n1 * n2);
            //        break;
            //    case 4:
            //        if (n2 != 0)
            //            Console.WriteLine(n1 / n2);
            //        else
            //            Console.WriteLine("Error:Division by zero is not allowed");
            //        break;
            //    default:
            //        Console.WriteLine("Not valid choice");
            //        break;
            //}
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numberArray[0]);
            foreach (int number in numberArray)
                Console.WriteLine(number);

            string[] employeeNames = new string[5];
            for (int i = 0; i < employeeNames.Length; i++)
                employeeNames[i] = Console.ReadLine();
            foreach (string employeeName in employeeNames)
                Console.WriteLine(employeeName);
            Console.ReadLine();

        }
    }
}
