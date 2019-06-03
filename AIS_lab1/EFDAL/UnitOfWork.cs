using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace EFDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private AISContext _aisContext;
        private EmployeeRepository _employees;
        private ProjectRepository _projects;

        public IRepository<Employee> Employees { get { return _employees; } }
        public IRepository<Project> Projects { get { return _projects; } }

        public void SaveChanges()
        {
            _aisContext.SaveChanges();
        }

        public UnitOfWork()
        {
            _aisContext = new AISContext();
            _employees = new EmployeeRepository(_aisContext);
            _projects = new ProjectRepository(_aisContext);
        }
    }
}
