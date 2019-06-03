using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SqlDAL
{
    public class ProjectRepository: CRUD<Project>
    {
        public List<Employee> GetProjectEmplyees(int proj)
        {
            var result = new List<Employee>();
            var projEmployees = new List<Employee>();
            var connection = new SqlConnection(new DbContext().connectionString);
            var employees = new DataTable();
            var command = new SqlCommand(String.Format(
                @"SELECT * FROM Employee
                  WHERE Employee_Id IN (
	                SELECT Employee_Project_IdEmployee FROM Employee_Peoject
                    WHERE Employee_Project_IdProject = '{0}');", proj));
            var reader = command.ExecuteReader();
            employees.Load(reader);
            foreach (DataRow row in employees.Rows)
            {
                var Employee = new Employee()
                {
                    ID = int.Parse(row["Employee_Id"].ToString()),
                    Name = (string)row["Employee_Name"],
                    Birth = (DateTime)employees.Rows[0]["Employee_Birth"],
                    Salary = int.Parse(employees.Rows[0]["Employee_Salary"].ToString())
                };
                result.Add(Employee);
            }
            return result;
        }

        public override Project Get(int id)
        {
            var projTable = new DataTable();
            var command = new SqlCommand(String.Format(
                @"
                SELECT * FROM Project
                WHERE Project_Id = '{0}');", id));
            var reader = command.ExecuteReader();
            projTable.Load(reader);
            if (projTable.Rows.Count != 1)
                return null;
            var project = new Project()
            {
                ID = int.Parse(projTable.Rows[0]["Project_Id"].ToString()),
                Name = (string)projTable.Rows[0]["Project_Name"]
            };
            project.Employees = GetProjectEmplyees(project.ID);
            return project;
        }

        public override ICollection<Project> GetAll()
        {
            var result = new List<Project>();
            var projTable = new DataTable();
            var command = new SqlCommand(String.Format(
                @"
                SELECT * FROM Project);"));
            var reader = command.ExecuteReader();
            projTable.Load(reader);
            if (projTable.Rows.Count < 1)
                return null;
            foreach (DataRow row in projTable.Rows)
            {
                var project = new Project()
                {
                    ID = int.Parse(projTable.Rows[0]["Project_Id"].ToString()),
                    Name = (string)projTable.Rows[0]["Project_Name"]
                };

                project.Employees = GetProjectEmplyees(project.ID);
                result.Add(project);
            }
            return result;
        }

        public override void Add(Project proj)
        {
            var AddProj = string.Empty;
            // Формирование полей
            var addFields = string.Format("(Project_Name)");
            // Формирование значений
            var addValues = string.Format("( \"{0}\"",
                    proj.Name);
            addValues = addValues.Remove(addValues.Length - 1, 1);
            // Формирование шаблона
            AddProj = string.Format("INSERT INTO `{0}` {1} VALUES {2};",
                "Project",
                addFields,
                addValues);

            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var command = new SqlCommand(AddProj, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public override void Delete(Project emp)
        {
            var DelProj = string.Empty;
            DelProj = string.Format("DELETE FROM `{0}` WHERE `{1}` IN ({2});",
                    "Project",
                    "Project_Id",
                    emp.ID);

            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var command = new SqlCommand(DelProj, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public override void Update(Project proj)
        {
            var result = new DataTable();
            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var UpdProj = new SqlCommand(string.Format("DELETE FROM Employee_Project WHERE Employee_Project_IdProject = '{0}'", proj.ID));
                UpdProj.ExecuteNonQuery();
                foreach (var emp in proj.Employees)
                {
                    UpdProj = new SqlCommand(string.Format("INSERT INTO Employee_Project VALUES ('{0}', '{1}')", proj.ID, emp.ID));
                    UpdProj.ExecuteNonQuery();
                }
            }
        }

    }
}
