using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOverloading_Demo
{
    internal class AgeException: ApplicationException
    {
        string message;
        public AgeException(int msg)
        {
            message = msg + "is invalid age. Age should be 21 to 80";
        }
        public override string ToString()
        {
            return message;
        }
    }
}
