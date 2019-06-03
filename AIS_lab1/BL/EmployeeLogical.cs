using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
//using SqlDAL;
using EFDAL;

namespace BL
{
    public static class EmployeeLogical
    {

        // Delete all employees
        static public void RemoveCollection()
        {
            var unitOfWork = new UnitOfWork();
            
            List<Employee> emps = unitOfWork.Employees.GetAll().ToList();
            foreach (var emp in emps)
                unitOfWork.Employees.Delete(emp);
            unitOfWork.SaveChanges();
          
        }

        // Fill the collection with random employees
        static public void FillCollection(int n)
        {
            var unitOfWork = new UnitOfWork();
            Random rnd = new Random();
            for (int i=0; i<n;i++)
            {
                int year = rnd.Next(1970, 2001);
                int month = rnd.Next(1, 13);
                int day = rnd.Next(1, 30);
                Employee em = new Employee
                {
                    Accepted = true,
                    Birth = new DateTime(year, month, day),
                    Salary = rnd.Next(15000, 50001),
                    Name = Enum.GetName(typeof(Names), rnd.Next(0, 30)) + " " +
                        Enum.GetName(typeof(SecondNames), rnd.Next(0, 30)),
                    Projects = new List<Project>()
                };
                unitOfWork.Employees.Add(em);
                unitOfWork.SaveChanges();
            }
        }

        // Returns all employees
        static public List<Employee> ReturnAllEmps()
        {
            var unitOfWork = new UnitOfWork();
            return unitOfWork.Employees.GetAll().ToList();
        }

        static public List<Employee> ReturnAcceptedEmps()
        {
            var unitOfWork = new UnitOfWork();
            return ((List<Employee>)unitOfWork.Employees.GetAll()).FindAll(e => e.Accepted);
        }

        static public List<Employee> ReturnFiredEmps()
        {
            var unitOfWork = new UnitOfWork();
            return ((List<Employee>)unitOfWork.Employees.GetAll()).FindAll(e => e.Accepted == false);
        }

        static public int CurrentAge(Employee emp)
        {
            return (DateTime.Today - emp.Birth).Days/365;
        }

        static public int AverageSalary(List<Employee> employees)
        {
            int av=0;
            foreach (Employee em in employees)
            {
                av += em.Salary;
            }
            return av / employees.Count();
        }

        // Add employee to database
        static public void Accept(Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.Employees.Get(emp.ID).Accepted = true;
            unitOfWork.SaveChanges();
        }

        static public void Fire (Employee emp)
        {
            emp.Accepted = false;
            var unitOfWork = new UnitOfWork();
            unitOfWork.Employees.Get(emp.ID).Accepted = false;
            unitOfWork.SaveChanges();
        }

        static public void GetPremium (Employee emp, int bonus)
        {
            var unitOfWork = new UnitOfWork();
            var e = unitOfWork.Employees.Get(emp.ID);
            e.Salary += bonus;
            unitOfWork.SaveChanges();
        }

        static public void SetFine(Employee emp, int fine)
        {
            var unitOfWork = new UnitOfWork();
            var e = unitOfWork.Employees.Get(emp.ID);
            e.Salary -= fine;
            unitOfWork.SaveChanges();
        }

        static public List<Project> EmployeeProjects(Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            return unitOfWork.Employees.Get(emp.ID).Projects;
        }

        static public void DeleteProject(Project proj, Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            var p = unitOfWork.Projects.Get(proj.ID);
            var e = unitOfWork.Employees.Get(emp.ID);
            e.Projects.Remove(p);
            unitOfWork.SaveChanges();
        }

        static public void AddProject (Project proj, Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            var p = unitOfWork.Projects.Get(proj.ID);
            var e = unitOfWork.Employees.Get(emp.ID);
            e.Projects.Add(p);
            unitOfWork.SaveChanges();
        }
    }
}
