using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SqlDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeRepository _employees;
        private ProjectRepository _projects;

        public IRepository<Employee> Employees { get { return _employees; } }
        public IRepository<Project> Projects { get { return _projects; } }

        public UnitOfWork()
        {
            _employees = new EmployeeRepository();
            _projects = new ProjectRepository();
        }
    }
}
