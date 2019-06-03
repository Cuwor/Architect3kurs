using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BL;

namespace AIS_lab1
{
    public partial class Form3 : Form
    {
        Form ChildForm = new Form();
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Project proj in ProjectLogical.GetAllProject())
            {
                ListOfProj.Items.Add(proj.Name);
            }
            ListOfProj.SelectedIndexChanged += SelectionChangedForProj;
            ListOfEmps.SelectedIndexChanged += SelectionChangedForEmp;
            AddEmpImProj.Enabled = false;
            DelEmp.Enabled = false;
            DelProj.Enabled = false;
        }

        //Обновление листа проектов
        private void UpdateData()
        {
            ListOfProj.Clear();
            foreach (Project proj in ProjectLogical.GetAllProject())
            {
                ListOfProj.Items.Add(proj.Name);
            }
        }

        private void SelectionChangedForProj(object sender, EventArgs e)
        {
            //Метод для отображения работников на проекте

            if (((ListView)sender).SelectedItems.Count>0)
            {
                AddEmpImProj.Enabled = true;
                DelProj.Enabled = true;

                List<Employee> employees = new List<Employee>();

                foreach (Project proj in ProjectLogical.GetAllProject())
                {
                    if (proj.Name.Equals(((ListView)sender).SelectedItems[0].Text))
                    {
                        employees = proj.Employees;
                    }
                }

                if (employees.Count > 0)
                {
                    ListOfEmps.Clear();
                    foreach (Employee emp in employees)
                    {
                        ListOfEmps.Items.Add(emp.Name);
                    }
                }
                else { ListOfEmps.Clear(); }
            }
            else
            {
                AddEmpImProj.Enabled = false;
                DelEmp.Enabled = false;
                DelProj.Enabled = false;
                ListOfEmps.Clear();
            }
        }

        private void AddProj_Click(object sender, EventArgs e)
        {
            Form NameOfProject = new Form();
            NameOfProject.StartPosition = FormStartPosition.CenterScreen;
            NameOfProject.Size = new Size { Width= 120, Height=100};
            NameOfProject.AutoSize = true;
            ChildForm = NameOfProject;
            Label lb = new Label { Text = "Название проекта", Location = new Point(10, 10), Width=100 };
            TextBox Name = new TextBox { Location = new Point(10, 40), Enabled=true };
            Button OK = new Button { Location = new Point(10, 70), Text="OK" };
            OK.Click += OnClick;

            NameOfProject.Controls.Add(lb);
            NameOfProject.Controls.Add(Name);
            NameOfProject.Controls.Add(OK);

            NameOfProject.Show();
        }

        private void OnClick (object sender, EventArgs e)
        {
            //Добавление нового проекта
            
            foreach (Control con in ChildForm.Controls)
            {
                if (con is TextBox)
                {
                    ProjectLogical.NewProject(((TextBox)con).Text);
                }
            }

            ChildForm.Close();
            UpdateData();
        }

        private void DelProj_Click(object sender, EventArgs e)
        {
            List<Project> Projects = ProjectLogical.GetAllProject();
            string SelectedName = ListOfProj.SelectedItems[0].Text;

            foreach (Project p in Projects)
            {
                if (p.Name.Equals(SelectedName))
                {
                    ProjectLogical.Delete(p);
                }
            }

            UpdateData();
        }

        private void DelEmp_Click(object sender, EventArgs e)
        {
            if (ListOfEmps.SelectedItems.Count>0)
            {
                List<Project> Projects = ProjectLogical.GetAllProject();
                Employee SelectedEmp = new Employee();
                Project SelectedProj = new Project();

                foreach (Project p in Projects)
                {
                    if (p.Name.Equals(ListOfProj.SelectedItems[0].Text))
                    {
                        SelectedProj = p;
                        foreach (Employee emp in p.Employees)
                        {
                            if (emp.Name.Equals(ListOfEmps.SelectedItems[0].Text))
                            {
                                SelectedEmp = emp;
                            }
                        }
                    }
                }

                ProjectLogical.DelEmployee(SelectedProj,SelectedEmp);

                List<Employee> employees = new List<Employee>();

                foreach (Project proj in ProjectLogical.GetAllProject())
                {
                    if (proj.Name.Equals(ListOfProj.SelectedItems[0].Text))
                    {
                        employees = proj.Employees;
                    }
                }

                if (employees.Count > 0)
                {
                    ListOfEmps.Clear();
                    foreach (Employee emp in employees)
                    {
                        ListOfEmps.Items.Add(emp.Name);
                    }
                }
                else { ListOfEmps.Clear(); }
            }
        }

        //Составление списка сотрудников, которых можно добавить в проект
        Employee AddEmployee = new Employee();
        Project SelectedProjForAdd = new Project();
        private void AddEmpImProj_Click(object sender, EventArgs e)
        {
            //Запоминаем выделенный проект
            List<Employee> AllEmployees = EmployeeLogical.ReturnAllEmps();

            foreach (Project p in ProjectLogical.GetAllProject())
            {
                if (p.Name.Equals(ListOfProj.SelectedItems[0].Text))
                {
                    SelectedProjForAdd = p;
                }
            }

            //Составляем форму, где будут показаны все сотрудники, которых мы можем добавить
            Form AllEmployeesForm = new Form();
            ChildForm = AllEmployeesForm;
            AllEmployeesForm.Size = new Size(100,250);
            AllEmployeesForm.StartPosition = FormStartPosition.CenterScreen;

            Label lb = new Label { Text = "Проект: " + SelectedProjForAdd.Name, Location = new Point(10,10) };
            ListView Employees = new ListView { Location = new Point(10, 40), Width = 100, Scrollable = true, View = View.List };
            Button OK = new Button { Text = "OK", Location = new Point(10, 170) };
            OK.Click += OnClick2;
            Employees.ItemSelectionChanged += SelectionChangedForEmp;

            if (SelectedProjForAdd.Employees.Count == AllEmployees.Count)
            {
                MessageBox.Show("Над этим проектом работают все сотрудники!", "Ошибка");
            }
            else
            {
                if (SelectedProjForAdd.Employees.Count > 0)
                {
                    for (int i = AllEmployees.Count - 1; i >= 0; i--)
                    {
                        foreach (Employee projEmp in SelectedProjForAdd.Employees)
                        {
                            if (projEmp.ID == AllEmployees[i].ID)
                            {
                                AllEmployees.Remove(AllEmployees[i]);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < AllEmployees.Count; i++)
                {
                    Employees.Items.Add(AllEmployees[i].Name);
                }

                AllEmployeesForm.Controls.Add(Employees);
                AllEmployeesForm.Controls.Add(OK);
                AllEmployeesForm.Controls.Add(lb);
                AllEmployeesForm.Show();
            }
        }

        private void SelectionChangedForEmp(object sender, EventArgs e)
        {
            //Запоминаем имена сотрудников
            List<string> EmpNames = new List<string>();
            foreach (Employee emp in SelectedProjForAdd.Employees)
            {
                EmpNames.Add(emp.Name);
            }

            string EmpName = "";
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                DelEmp.Enabled = true;

                EmpName = ((ListView)sender).SelectedItems[0].Text;

                //Запоминаем сотрудника, которого хотим доабвить
                foreach (Employee emp in EmployeeLogical.ReturnAcceptedEmps())
                {
                    if (emp.Name.Equals(EmpName))
                    {
                        AddEmployee = emp;
                    }
                }
            }
            else
            {
                DelEmp.Enabled = false;
            }
        }

        private void OnClick2(object sender, EventArgs e)
        {
            // Добавляем сотрудника в проект

            if (!AddEmployee.Equals(null))
            {
                ProjectLogical.AddEmployee(SelectedProjForAdd,AddEmployee);
                ChildForm.Close();
            }

            List<Employee> employees = new List<Employee>();

            foreach (Project proj in ProjectLogical.GetAllProject())
            {
                if (proj.Name.Equals(ListOfProj.SelectedItems[0].Text))
                {
                    employees = proj.Employees;
                }
            }

            if (employees.Count > 0)
            {
                ListOfEmps.Clear();
                foreach (Employee emp in employees)
                {
                    ListOfEmps.Items.Add(emp.Name);
                }
            }
            else { ListOfEmps.Clear(); }
        }
    }
}
