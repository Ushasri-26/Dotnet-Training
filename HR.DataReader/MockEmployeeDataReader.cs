using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emp.Models;

namespace Emp.DataReader
{
    public class MockEmployeeDataReader : IEmployeeDataReader
    {
        // Avoid new() target-typed and index initializers.
        private static readonly Dictionary<int, EmployeeRecord> _mock = new Dictionary<int, EmployeeRecord>
        {
            { 101, new EmployeeRecord { Id = 101, Name = "Usha sri", Role = "Developer", IsVeteran = false } },
            { 102, new EmployeeRecord { Id = 102, Name = "Uday", Role = "Manager", IsVeteran = true } },
            { 103, new EmployeeRecord { Id = 103, Name = "Bhavya", Role = "Intern", IsVeteran = false } },
            { 104, new EmployeeRecord { Id = 104, Name = "Monika", Role = "Manager", IsVeteran = false } },
            { 105, new EmployeeRecord { Id = 105, Name = "Ravi", Role = "Developer", IsVeteran = true } },
            { 106, new EmployeeRecord { Id = 106, Name = "Naveen", Role = "Intern", IsVeteran = false } },

        };

        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            EmployeeRecord rec;
            if (_mock.TryGetValue(employeeId, out rec))
                return rec;

            return new EmployeeRecord
            {
                Id = employeeId,
                Name = "Unknown",
                Role = "Contractor",
                IsVeteran = false
            };
        }
    }
}
