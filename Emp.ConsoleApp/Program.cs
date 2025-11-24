using Emp.DataReader;
using Emp.Models;
using Emp.Payroll;


class Program
{
    static void Main()
    {
        IEmployeeDataReader reader = new MockEmployeeDataReader();
        var payroll = new PayrollProcessor(reader);

        int[] demoIds = { 101, 102, 103, 104, 105, 106, 999 };

        foreach (var id in demoIds)
        {
            var record = reader.GetEmployeeRecord(id);
            var total = payroll.CalculateTotalCompensation(id);

            
            Console.WriteLine(
                $"Employee ID: {record.Id}, Name: {record.Name}, Total Compensation: Rs: {total:N2}"
            );
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
