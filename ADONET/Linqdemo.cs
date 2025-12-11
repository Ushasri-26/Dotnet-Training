using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADONET
{ 
    internal class Linqdemo
    {
        List<Movies> li = new List<Movies>()
        {
            new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas",
            Actress="Tamanna", YOR=2015 },
            new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas",
            Actress="Anushka", YOR=2017 },
            new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini",
            Actress="Aish", YOR=2010 },
            new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir",
            Actress="kareena", YOR=2009 },
            new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas",
            Actress="shraddha", YOR=2019 },
        };
        //1. 1. display list of movienames acted by prabhas
        public void MoviesbyPrabhas()
        {
            var res = from m in li
                      where m.Actor == "Prabhas"
                      select m.MovieName;
            Console.WriteLine("Movies acted by Prabhas:");
            foreach (var r in res)
                Console.WriteLine(r);
        }
        //2. display list of all movies released in year 2019
        public void MovieRelease()
        {
            var res = from m in li
                      where m.YOR==2019
                      select m.MovieName;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movies released in 2019:");
            foreach(var r in res)
                Console.WriteLine(r);
        }
        //3. display the list of movies who acted together by prabhas and anushka
        public void MWPA()
        {
            var res = from m in li
                      where m.Actor=="Prabhas" && m.Actress=="Anushka"
                      select m.MovieName;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movies with Prabhas and Anushka:");
            foreach( var r in res)
                Console.WriteLine(r);
        }
       //4. display the list of all actress who acted with prabhas
       public void ActressWP()
        {
            var res = (from m in li
                       where m.Actor == "Prabhas"
                       select m.Actress).Distinct();
            Console.WriteLine("=============================================");
            Console.WriteLine("Actress who acted with Prabhas:");
            foreach (var actress in res)
                Console.WriteLine(actress);
        }
       //5. display the list of all moves released from 2010 - 2018
       public void Movies10to18()
       {
            var res = from m in li
                      where m.YOR>=2010 && m.YOR<=2018
                      select m.MovieName;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movies released from 2010-2018");
            foreach(var r in res)
                Console.WriteLine(r);
        }
        //6. sort YOR in descending order and display all its records
        public void Sortbyyear()
        {
            var res = from m in li
                      orderby m.YOR descending
                      select m;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movies Sorted by Year desc:");
            foreach(var m in res)
                Console.WriteLine($"{m.YOR}-{m.MovieName}");
        }
        //7. display max movies acted by each actor
        public void MaxMovies()
        {
            var res = from m in li
                      group m by m.Actor into g
                      select new { Actor = g.Key, Movies = g.Count() };
            Console.WriteLine("=============================================");
            Console.WriteLine("Max of movies:");
            foreach (var r in res) 
                Console.WriteLine($"{r.Actor} {r.Movies}");
        }
        //8. display the name of all movies which is 5 characters long
        public void Movieslen()
        {
            var res = from m in li
                      where m.MovieName.Length ==5
                      select m.MovieName;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movies with 5 Characters long:");
            foreach (var r in res)
                Console.WriteLine(r);
        }
       //9.display names of actor and actress where movie released in
       //year 2017, 2009 and 2019
       public void Movierel()
       {
            int[] years = { 2017, 2009, 2019 };
            var res = from m in li
                      where years.Contains(m.YOR)
                      select m;
            Console.WriteLine("=============================================");
            Console.WriteLine("Actors and Actress released years are:");
            foreach(var r in res)
                Console.WriteLine($"{r.YOR}: {r.Actor}, {r.Actress}");
        }
      //10.display the name of movies which start with 'b' and ends with 'i'
      public void StartsBEndsI()
      {
            var res = from m in li
                      let s=m.MovieName.ToLower()
                      where s.StartsWith("b")&&s.EndsWith("i")
                      select m.MovieName;
            Console.WriteLine("=============================================");
            Console.WriteLine("Movie Starts with b and Ends with i:");
            foreach ( var r in res)
                Console.WriteLine(r);
      }
        //11.display name of actress who not acted with Rajini and print in descending
        //order
        public void ANWR()
        {
            var res = (from m in li
                       where m.Actor != "Rajini"
                       select m.Actress).Distinct();
            var sorted = from a in res
                         orderby a descending
                         select a;
            Console.WriteLine("=============================================");
            Console.WriteLine("Actress not acted with Rajini:");
            foreach (var r in sorted)
                Console.WriteLine(r);
        }
        //12. display records in following format
        //eg:
       //movie name cast
      //Bahubali prabhas-tammann
      public void MovieCast()
      {
            var res12 = from m in li
                        select new { Moviename = m.MovieName, Cast = m.Actor + "-" + m.Actress };
            Console.WriteLine("=============================================");
            Console.WriteLine("Moviename and Cast:");
            foreach (var r12 in res12)
                Console.WriteLine($"{r12.Moviename}  {r12.Cast}");
        }
    }
}
