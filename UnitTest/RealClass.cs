using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
        public interface IMath
        {
            string Add(int x, int y);
        }
        internal class RealClass : IMath
        {
            public string Add(int x, int y)
            {
                
                return "the sum is " + (x + y);
            }
        }
}
