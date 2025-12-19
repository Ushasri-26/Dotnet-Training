namespace CrudAssign
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Runtime.Remoting.Contexts;

    public partial class sportsdbEntities1 : DbContext
    {
        public sportsdbEntities1()
            : base("name=sportsdbEntities1")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
