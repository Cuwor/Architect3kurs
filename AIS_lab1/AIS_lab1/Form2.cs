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
    public partial class Form2 : Form
    {
        Employee SelectedEmp = new Employee();
        Project SelectedProject = new Project();
        Form ChildForm = new Form();

        public Form2(Employee emp)
        {
            InitializeComponent();
            SelectedEmp = emp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Показываем проекты работника

            if (SelectedEmp.Projects.Count>0)
            {
                foreach (Project proj in SelectedEmp.Projects)
                {
                    ProjectOfEmp.Items.Add(proj.Name);
                }
            }
            EmpName.Text = SelectedEmp.Name;
            ProjectOfEmp.ItemSelectionChanged += SelectionChanged;
            DelProjForEmp.Enabled = false;
        }

        private void AddProjForEmp_Click(object sender, EventArgs e)
        {
            //Выводим проекты, над которыми сотрудник ещё не работает
            
            List<Project> AllProjects = ProjectLogical.GetAllProject();

            Form AllProjectForm = new Form();
            AllProjectForm.StartPosition = FormStartPosition.CenterScreen;
            ChildForm = AllProjectForm;
            AllProjectForm.Size = new Size(130,200);

            ListView Projects = new ListView {Location = new Point(10,10), Width = 100, Scrollable = true, View = View.List};
            Button OK = new Button { Text = "OK", Location = new Point(10, 120) };
            OK.Click += OnClick;
            Projects.ItemSelectionChanged += SelectionChanged;

            if (EmployeeLogical.EmployeeProjects(SelectedEmp).Count == AllProjects.Count)
            {
                MessageBox.Show("Этот сотрудник работает над всеми проектами!","Ошибка");
            }
            else
            {
                if (EmployeeLogical.EmployeeProjects(SelectedEmp).Count>0)
                {
                    for (int i = AllProjects.Count - 1; i >= 0; i--)
                    {
                        foreach (Project proj in EmployeeLogical.EmployeeProjects(SelectedEmp))
                        {
                            if (proj.ID == AllProjects[i].ID)
                            {
                                AllProjects.Remove(AllProjects[i]);
                                break;
                            }
                        }
                    }
                }

                foreach (Project p in AllProjects)
                {
                    Projects.Items.Add(p.Name);
                }

                AllProjectForm.Controls.Add(Projects);
                AllProjectForm.Controls.Add(OK);
                AllProjectForm.Show();
            }
        }

        private void OnClick (object sender, EventArgs e)
        {
            // Добавляем выбранный проект сотруднику

            if (!SelectedProject.Equals(null))
            {
                EmployeeLogical.AddProject(SelectedProject, SelectedEmp);
                ChildForm.Close();
            }

            //Обновляем данные
            ProjectOfEmp.Clear();
            foreach (Project proj in EmployeeLogical.EmployeeProjects(SelectedEmp))
            {
                ProjectOfEmp.Items.Add(proj.Name);
            }
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            //Запоминаем выбранный проект
            List<Project> AllProjects = ProjectLogical.GetAllProject();
            string ProjName="";
            if (((ListView)sender).SelectedItems.Count>0)
            {
                DelProjForEmp.Enabled = true;
                ProjName = ((ListView)sender).SelectedItems[0].Text;

                foreach (Project proj in AllProjects)
                {
                    if (proj.Name.Equals(ProjName))
                    {
                        SelectedProject = proj;
                    }
                }
            }
            else
            {
                DelProjForEmp.Enabled = false;
            }
        }

        private void DelProjForEmp_Click(object sender, EventArgs e)
        {
            //Запоминаем выбранный проект и удаляем его из списка сотрудника

            string ProjName = "";
            if (ProjectOfEmp.SelectedItems.Count > 0)
            {
                ProjName = ProjectOfEmp.SelectedItems[0].Text;

                foreach (Project proj in EmployeeLogical.EmployeeProjects(SelectedEmp))
                {
                    if (proj.Name.Equals(ProjName))
                    {
                        SelectedProject = proj;
                    }
                }
            }

            EmployeeLogical.DeleteProject(SelectedProject,SelectedEmp);

            //Обновляем данные
            ProjectOfEmp.Clear();
            foreach (Project proj in EmployeeLogical.EmployeeProjects(SelectedEmp))
            {
                ProjectOfEmp.Items.Add(proj.Name);
            }
        }
    }
}
