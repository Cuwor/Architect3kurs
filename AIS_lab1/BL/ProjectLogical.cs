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
    public static class ProjectLogical
    {
        public static void RemoveCollection()
        {
            var unitOfWork = new UnitOfWork();
            foreach (var project in unitOfWork.Projects.GetAll().ToList())
                unitOfWork.Projects.Delete(project);
            unitOfWork.SaveChanges();
        }

        public static void NewProject (string name, Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            Project proj = new Project
            {
                Name = name,
                Employees = new List<Employee>() { emp }
            };
            unitOfWork.Projects.Add(proj);
            unitOfWork.SaveChanges();
        }

        public static void NewProject(string name)
        {
            var unitOfWork = new UnitOfWork();
            Project proj = new Project
            {
                Name = name,
                Employees = new List<Employee>()
            };
            unitOfWork.Projects.Add(proj);
            unitOfWork.SaveChanges();
        }

        public static void Delete (Project proj)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.Projects.Delete(unitOfWork.Projects.Get(proj.ID));
            unitOfWork.SaveChanges();
        }

        public static List<Project> GetAllProject()
        {
            var unitOfWork = new UnitOfWork();
            return unitOfWork.Projects.GetAll().ToList();
        }

        public static void AddEmployee (Project proj, Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            var e = unitOfWork.Employees.Get(emp.ID);
            unitOfWork.Projects.Get(proj.ID).Employees.Add(e);
            unitOfWork.SaveChanges();
        }

        public static void DelEmployee(Project proj, Employee emp)
        {
            var unitOfWork = new UnitOfWork();
            //proj.Employees.Remove(emp);
            unitOfWork.Projects.Get(proj.ID).Employees.Remove(unitOfWork.Employees.Get(emp.ID));
            unitOfWork.SaveChanges();
        }
    }
}
