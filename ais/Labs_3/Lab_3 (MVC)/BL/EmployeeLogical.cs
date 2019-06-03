using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using View1;

//using Model;
//using Employee = Model.Employee;

namespace BL
{
    public class EmployeeLogical
    {
        private BDEmployeesDataContext _dataBase = new BDEmployeesDataContext();

        public FormEmployee View { get; set; }

        public EmployeeLogical()
        {
            View = new FormEmployee(UpdateTable);
        }

        private List<string> _listFirstname =new List<string>()
        {
            "Алена",
            "Елена",
            "Елизваета",
            "Юлия",
            "Вероника",
            "Лев",
            "Николай",
            "Александр",
            "Максим",
            "Андрей"
        }; 

        private List<string> _listSurname = new List<string>()
        {
            "Штефан",
            "Сокол",
            "Ежак",
            "Овчаренко",
            "Божко",
            "Фоменко",
            "Пиун",
            "Тищенко",
            "Рощенко",
            "Карпенко",
            "Бутенко"
        };

        private Random r = new Random();
        
        public List<Employee> ListEmployees
        {
            get
            {
                List<Employee> list = new List<Employee>(from employee in _dataBase.Employee select employee);
                return list;
            }
        }
        
        public void SetFakeDataEmployee(Employee employee)
        {
            int k = _listFirstname.Count();

            employee.Firstname = _listFirstname[r.Next(k)];

            k = _listSurname.Count();
            employee.Surname = _listSurname[r.Next(k)];

            employee.Age = r.Next(20, 40);

            employee.Salary = r.Next(250, 400)*100;

            employee.Prize = r.Next(100, 200) * 100;

            employee.Status = ((EnumеStatus)r.Next(0, 2)).ToString();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> listeEmployees=new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                
                Employee employee = new Employee();
                SetFakeDataEmployee(employee);
                _dataBase.Employee.InsertOnSubmit(employee);
                _dataBase.SubmitChanges();
            }

            return listeEmployees;
        }
        
        public double GetAverageSalary()
        {
            double sum = 0;
            foreach (var employee in ListEmployees)
            {
                if (employee.Salary != null) sum += int.Parse(employee.Salary.ToString());
            }

            return sum / ListEmployees.Count;
        }

        public double GetAverageAge()
        {
            double sum = 0;
            foreach (var employee in ListEmployees)
            {
                if (employee != null) sum += int.Parse(employee.Age.ToString());
            }

            return sum / ListEmployees.Count;
        }

        public void ModifyEmloyeeStatus(Employee employee, EnumеStatus newEnumеStatus)
        {
            employee.Status = newEnumеStatus.ToString();

        }

        public void ModifyEmloyeePrize(Employee employee, int newPrize)
        {
            employee.Prize = newPrize;
        }

        public void AddEmployee(int age, string firstname, int prize,int salary, EnumеStatus status,string surname)
        {
            Employee employee =new Employee()
            {
                Age = age,
                Firstname = firstname,
                Prize =prize,
                Salary = salary,
                Status = status.ToString(),
                Surname = surname
            };

            _dataBase.Employee.InsertOnSubmit(employee);
            _dataBase.SubmitChanges();
        }

        public void UpdateEmployee(int id, int age, string firstname, int prize, int salary, EnumеStatus status, string surname)
        {
            Employee employee = ListEmployees.Find(x => x.ID == id);
            employee.Age = age;
            employee.Firstname = firstname;
            employee.Prize = prize;
            employee.Salary = salary;
            employee.Status = status.ToString();
            employee.Surname = surname;
        }
        
        public List<EnumеStatus> GetListStatuses()
        {
            List<EnumеStatus> list =new List<EnumеStatus>();
            int enumCount = Enum.GetNames(typeof(EnumеStatus)).Length;
            for (int i = 0; i < enumCount; i++)
            {
                list.Add((EnumеStatus)i);
            }

            return list;
        }

        public EnumеStatus GetEnumеStatus(object enumеStatus)
        {
            return (EnumеStatus) enumеStatus;
        }

        public EnumеStatus GetEnumеStatus(string enumеStatus)
        {
            return (EnumеStatus)Enum.Parse(typeof(EnumеStatus), enumеStatus);
        }

        public List<Employee> GetEmployeesEnumeStatusAccept()
        {
            return ListEmployees.FindAll(x => x.Status == "Принятый");
        }

        public List<Employee> GetEmployeesEnumeStatusFire()
        {
            return ListEmployees.FindAll(x => x.Status == "Уволенный");
        }

        public void DelleteEmployee(List<int> idEmployee)
        {
            var query = from e in _dataBase.Employee
                where idEmployee.Contains(e.ID)
                select e;
            foreach (var q in query)
            {
                _dataBase.Employee.DeleteOnSubmit(q);
            }
            _dataBase.SubmitChanges();
        }

        private void UpdateTable(FormEmployee view)
        {
            view.DataGridViewEmployee.DataSource = null;
            view.DataGridViewEmployee.DataSource = ListEmployees;
        }
        
    }

}
