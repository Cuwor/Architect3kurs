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
    public class EmployeeRepository: CRUD<Employee>
    {
        public List<Project> GetEmployeeProjects(int emp)
        {
            var result = new List<Project>();
            var connection = new SqlConnection(new DbContext().connectionString);
            var projects = new DataTable();
            var command = new SqlCommand(String.Format(
                @"
                SELECT * FROM Project
                WHERE Project_Id IN (
	                SELECT Employee_Project_IdProject FROM Employee_Peoject
                    WHERE Employee_Project_IdEmployee = '{0}');",emp));
            var reader = command.ExecuteReader();
            projects.Load(reader);
            foreach (DataRow row in projects.Rows)
            {
                var project = new Project()
                {
                    ID = int.Parse(row["Project_Id"].ToString()),
                    Name = (string)row["Project_Name"]
                };
                result.Add(project);
            }
            return result;
        }

        public override Employee Get(int id)
        {
            //var dataTable = ExecuteSqlQuery(string.Format(Constants.GET_EMPLOYEE_BY_ID, id));
            var empTable = new DataTable();
            var command = new SqlCommand(String.Format(
                @"
                SELECT * FROM Employee
                WHERE Employee_Id = '{0}');", id));
            var reader = command.ExecuteReader();
            empTable.Load(reader);
            if (empTable.Rows.Count != 1)
                return null;
            var emp = new Employee()
            {
                ID = int.Parse(empTable.Rows[0]["Employee_Id"].ToString()),
                Name = (string)empTable.Rows[0]["Employee_Name"],
                Birth = (DateTime)empTable.Rows[0]["Employee_Birth"],
                Salary = int.Parse(empTable.Rows[0]["Employee_Salary"].ToString())
            };
            emp.Projects = GetEmployeeProjects(emp.ID);
            return emp;
        }

        public override ICollection<Employee> GetAll()
        {
            var result = new List<Employee>();
            var empTable = new DataTable();
            var command = new SqlCommand(String.Format(
                @"
                SELECT * FROM Employee);"));
            var reader = command.ExecuteReader();
            empTable.Load(reader);
            if (empTable.Rows.Count < 1)
                return null;
            foreach (DataRow row in empTable.Rows)
            {
                var emp = new Employee()
                {
                    ID = int.Parse(empTable.Rows[0]["Employee_Id"].ToString()),
                    Name = (string)empTable.Rows[0]["Employee_Name"],
                    Birth = (DateTime)empTable.Rows[0]["Employee_Birth"],
                    Salary = int.Parse(empTable.Rows[0]["Employee_Salary"].ToString())
                };
                
                emp.Projects = GetEmployeeProjects(emp.ID);

                result.Add(emp);
            }
            return result;
        }

        public override void Add(Employee emp)
        {
            var AddEmp = string.Empty;
            // Формирование полей
            var addFields = string.Format("( `{0}`, `{1}`, `{2}`)",
                "Employee_Name",
                "Employee_Birth",
                "Employee_Salary");
            // Формирование значений
            var addValues = string.Format("( \"{0}\", \"{1}\", \"{2}\")",
                    emp.Name,
                    emp.Birth.Year + "." + emp.Birth.Month + "." + emp.Birth.Day,
                    emp.Salary);
            addValues = addValues.Remove(addValues.Length - 1, 1);
            // Формирование шаблона
            AddEmp = string.Format("INSERT INTO `{0}` {1} VALUES {2};",
                "Employee",
                addFields,
                addValues);

            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var command = new SqlCommand(AddEmp,connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public override void Delete(Employee emp)
        {
            var DelEmp = string.Empty;
            DelEmp = string.Format("DELETE FROM `{0}` WHERE `{1}` IN ({2});",
                    "Employee",
                    "Employee_Id",
                    emp.ID);

            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var command = new SqlCommand(DelEmp, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public override void Update(Employee emp)
        {
            var result = new DataTable();
            var connection = new SqlConnection(new DbContext().connectionString);
            using (connection)
            {
                connection.Open();
                var UpdEmps = new List<Employee>();
                var empTable = new DataTable();
                var command = new SqlCommand(string.Format(@"
                UPDATE Employee
                SET Employee_Name = '{0}',
	            Employee_Birth = '{1}',
	            Employee_Salary = '{2}',
                WHERE Employee_Id = '{3}';",
                emp.Name,
                emp.Birth.Year + "." + emp.Birth.Month + "." + emp.Birth.Day,
                emp.Salary,
                emp.ID));
                var UpdEmp = new SqlCommand(string.Format("DELETE FROM Employee_Project WHERE Employee_Project_IdEmployee = '{0}'", emp.ID));
                UpdEmp.ExecuteNonQuery();
                foreach (var project in emp.Projects)
                {
                    UpdEmp = new SqlCommand(string.Format("INSERT INTO Employee_Project VALUES ('{0}', '{1}')", emp.ID, project.ID));
                    UpdEmp.ExecuteNonQuery();
                }
            }
        }
        
    }
}
