using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MainModel
    {
        public EmployeeLogical BLogical { get; set; } =new EmployeeLogical();

        public ObservableCollection<Employee> ListEmployee { get; set; } 

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Oklad { get; set; }

        public int Prize { get; set; }

        public EnumеStatus SelectStatus { get; set; }

        public ObservableCollection<EnumеStatus> ListStatus { get; set; }

        public Employee SelectEmployee { get; set; }

        public MainModel()
        {
            ListStatus = new ObservableCollection<EnumеStatus>(BLogical.GetListStatuses());
            ListEmployee = new ObservableCollection<Employee>(BLogical.ListEmployees);
        }

        public void UpdateTable()
        {
            ListEmployee = new ObservableCollection<Employee>(BLogical.ListEmployees);
        }

        public void AddEmployee()
        {
            BLogical.AddEmployee(Age,Name,Prize,Oklad,SelectStatus,Surname);
            UpdateTable();
        }
        public void DeleteEmployee()
        {
            BLogical.DelleteEmployee(SelectedIds());
            UpdateTable();
        }

        private List<int> SelectedIds()
        {
            var ids = new List<int>();
            
            ids.Add(SelectEmployee.ID);
            return ids;
        }
    }
}
