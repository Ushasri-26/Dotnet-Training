using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary,finalsalary, bonus,yearsofservice;
            Console.Write("Enter your current salary:");
            salary=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter years of service:");
            yearsofservice= Convert.ToDouble(Console.ReadLine());
            if (yearsofservice>10)
            {
                bonus = salary * 0.2;
            }
            else if(yearsofservice>=5 && yearsofservice <=10)
            {
                bonus = salary * 0.1;
            }
            else
            { 
                bonus = salary * 0.05;
            }
            finalsalary = salary + bonus;
            Console.WriteLine($"Bonus amount: {bonus}");
            Console.WriteLine($"Final Salary after adding the bonus: {finalsalary}");
            Console.ReadLine();
        }
    }
}
