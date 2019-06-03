using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
    public class EmployeeLogical
    {

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

        private int _kId = 1;


        public List<Employee> ListEmployees { get; set; } = new List<Employee>();


        public void SetFakeDataEmployee(Employee employee)
        {
            employee.Id = _kId;
            _kId++;

            Random r =new Random(employee.Id);
            
            int k = _listFirstname.Count();

            employee.Firstname = _listFirstname[r.Next(k)];

            k = _listSurname.Count();
            employee.Surname = _listSurname[r.Next(k)];

            employee.Age = r.Next(20, 40);

            employee.Salary = r.Next(250, 400)*100;

            employee.Prize = r.Next(100, 200) * 100;

            employee.Status = (EnumеStatus)r.Next(0, 2);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> listeEmployees=new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                Random r =new Random();
                Employee employee = new Employee();
                SetFakeDataEmployee(employee);
                listeEmployees.Add(employee);
            }

            return listeEmployees;
        }

        public List<Employee> GetEmployees(int k)
        {
            List<Employee> listeEmployees = new List<Employee>();

            for (int i = 0; i < k; i++)
            {
                Random r = new Random();
                Employee employee = new Employee();
                SetFakeDataEmployee(employee);
                listeEmployees.Add(employee);
            }

            return listeEmployees;
        }

        public double GetAverageSalary()
        {
            double sum=0;
            foreach (var employee in ListEmployees)
            {
                sum += employee.Salary;
            }

            return sum / ListEmployees.Count;
        }

        public double GetAverageAge()
        {
            double sum = 0;
            foreach (var employee in ListEmployees)
            {
                sum += employee.Age;
            }

            return sum / ListEmployees.Count;
        }

        public void ModifyEmloyeeStatus(Employee employee, EnumеStatus newEnumеStatus)
        {
            employee.Status = newEnumеStatus;

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
                Id = _kId,
                Prize =prize,
                Salary = salary,
                Status = status,
                Surname = surname
            };
            _kId++;
            ListEmployees.Add(employee);
        }

        public void UpdateEmployee(int id, int age, string firstname, int prize, int salary, EnumеStatus status, string surname)
        {
            Employee employee = ListEmployees.Find(x => x.Id == id);
            employee.Age = age;
            employee.Firstname = firstname;
            employee.Prize = prize;
            employee.Salary = salary;
            employee.Status = status;
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

        public List<Employee> GetEmployeesEnumeStatusAccept()
        {
            return ListEmployees.FindAll(x => x.Status == EnumеStatus.Принятый);
        }

        public List<Employee> GetEmployeesEnumeStatusFire()
        {
            return ListEmployees.FindAll(x => x.Status == EnumеStatus.Уволенный);
        }
    }

}
