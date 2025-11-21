using RemotingTrn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RemotingTrn.Class1;

namespace RemotingLib
{
   //write logic here 
//we are implementing the interface 
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        //marshalbyref:represents the class can be called from remote system
        public string Show(string name)
        {
            return "Hello {name} How are you!";
        }
    }
}