using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace EFDAL
{
    public class EmployeeRepository:IRepository<Employee>
    {
        private AISContext _aisContext;

        public void Add(Employee emp)
        {
            _aisContext.Employees.Add(emp);
        }

        public void Delete(Employee emp)
        {
            _aisContext.Employees.Remove(emp);
        }

        public Employee Get(int id)
        {
            return _aisContext.Employees.First(o => o.ID == id);
        }

        public ICollection<Employee> GetAll()
        {
            return _aisContext.Employees.ToList();
        }

        public void Update(Employee emp)
        {
            _aisContext.SaveChanges();
        }

        internal EmployeeRepository(AISContext aisContext)
        {
            _aisContext = aisContext;
        }
    }
}
