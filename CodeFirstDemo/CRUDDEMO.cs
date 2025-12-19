using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    //Create new console projetc
    //rightclick on project->add new item->ado.net entity model->empty code first > click finish
    internal class CRUDDEMO
    {
        Model1 dc = new Model1();
        public void Display()
        {
            var res = from t in dc.IPLs
                      select t;
            foreach (var item in res)
            {
                Console.WriteLine(item.TeamID + ":" + item.TeamName +":" + item.State + ":" + item.Captain);
            }
            
        }
        public void Insert()
        {
            IPL ob = new IPL() { TeamID = 1, TeamName = "RCB", Captain = "Virat", State = "Bangalore" };
            dc.IPLs.Add(ob);
            int i=dc.SaveChanges();
            Console.WriteLine("Total rows inserted is" + i);

        }
    }
}
