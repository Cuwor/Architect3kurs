using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using System.Data.SqlClient;

namespace SqlDAL
{
    public class DbContext : IUnitOfWork
    {
        public string connectionString = @"Data Source=DESKTOP-2EPAEHP\SQLEXPRESS;Initial Catalog=AIS;Integrated Security=True";
        public IRepository<Employee> Employees { get; set; }
        public IRepository<Project> Projects { get; set; }
    }
}
