using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciples
{
    public abstract class EmployeeBase
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDept { get; set; }
    }
    public interface IBonusEligible
    {
        decimal GetBonus(decimal salary);
    }
    public class PermanentEmployee : EmployeeBase, IBonusEligible
    {
        public decimal GetBonus(decimal salary)
        {
            return salary * 0.20m;
        }
    }
    public class ContractEmployee : EmployeeBase
    {
        
    }
    internal class LSP
    {
        public static void Main(string[] args)
        {
            PermanentEmployee perm = new PermanentEmployee { EmpId = 1, EmpName = "Usha", EmpDept = "HR" };
            ContractEmployee contract = new ContractEmployee { EmpId = 2, EmpName = "Moni", EmpDept = "IT" };

            decimal salary = 50000;

            IBonusEligible bonusEmp = perm; 
            WriteLine($"Permanent Employee Bonus: {bonusEmp.GetBonus(salary)}");

            
            WriteLine("Contract Employee: No Bonus");
            ReadLine();
        }
    }
}
