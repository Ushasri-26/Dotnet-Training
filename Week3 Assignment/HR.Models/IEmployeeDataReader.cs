using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Models
{
    public interface IEmployeeDataReader
    {
        EmployeeRecord GetEmployeeRecord(int employeeId);
    }
}
