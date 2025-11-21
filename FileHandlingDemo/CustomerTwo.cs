using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
    internal class CustomerTwo
    {
    }
}
