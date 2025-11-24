using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Models
{
    public class EmployeeRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public bool IsVeteran { get; set; }

        public EmployeeRecord()
        {
            Name = string.Empty;
            Role = string.Empty;
            IsVeteran = false;
        }
    }
}
