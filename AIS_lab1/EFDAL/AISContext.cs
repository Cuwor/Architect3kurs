using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Model;

namespace EFDAL
{
    public class AISContext: DbContext
    {
        public AISContext(): 
            base(@"Data Source=DESKTOP-2EPAEHP\SQLEXPRESS;Initial Catalog=AIS;Integrated Security=True")
        { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
    }
}
