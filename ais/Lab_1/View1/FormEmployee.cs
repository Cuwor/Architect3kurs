using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;


namespace View1
{
    public partial class FormEmployee : Form
    {
        public EmployeeLogical EmployeeLogical { get; set; }


        public FormEmployee()
        {
            InitializeComponent();
            EmployeeLogical = new EmployeeLogical();
        }

        private void ButtonFakeDataEmployees_Click(object sender, EventArgs e)
        {
            EmployeeLogical.ListEmployees.AddRange(EmployeeLogical.GetEmployees());
            UpdateTable();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if(SelectedIds().Count==1)
            {
                int idE = SelectedIds()[0];
                FormAddEmployee form = new FormAddEmployee();
                form.ComboBoxStatus.DataSource = EmployeeLogical.GetListStatuses();
                form.TextBoxAge.Text = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Age.ToString();
                form.TextBoxSalary.Text = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Salary.ToString();
                form.TextBoxPrize.Text = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Prize.ToString();
                form.ComboBoxStatus.SelectedItem = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Status;
                form.TextBoxFirstname.Text = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Firstname.ToString();
                form.TextBoxSurname.Text = EmployeeLogical.ListEmployees.Find(x => x.Id == idE).Surname.ToString();

                bool b;
                do
                {
                    b = false;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int age, salary, prize;
                        bool bAge = int.TryParse(form.TextBoxAge.Text, out age);
                        bool bSalary = int.TryParse(form.TextBoxSalary.Text, out salary);
                        bool bPrize = int.TryParse(form.TextBoxPrize.Text, out prize);
                        if (bAge && bSalary && bPrize)
                        {

                            EmployeeLogical.UpdateEmployee(idE, bAge ? age : 0, form.TextBoxFirstname.Text, bPrize ? prize : 0,
                                bSalary ? salary : 0, EmployeeLogical.GetEnumеStatus(form.ComboBoxStatus.SelectedItem),
                                form.TextBoxFirstname.Text);
                        }
                        else
                        {
                            b = true;
                            MessageBox.Show("Неправильно заполнены поля");
                        }

                    }
                    else
                    {
                        b = false;
                    }

                } while (b);
                UpdateTable();
            }
        }

        private void ButtonInformation_Click(object sender, EventArgs e)
        {
            FormInformationEmployees form = new FormInformationEmployees();
            form.label6.Text = EmployeeLogical.ListEmployees.Count.ToString();
            form.label7.Text = EmployeeLogical.GetEmployeesEnumeStatusAccept().Count.ToString();
            form.label8.Text = EmployeeLogical.GetEmployeesEnumeStatusFire().Count.ToString();
            form.label9.Text = EmployeeLogical.GetAverageAge().ToString();
            form.label10.Text = EmployeeLogical.GetAverageSalary().ToString();
            form.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (var id in SelectedIds())
            {
                EmployeeLogical.ListEmployees.Remove(EmployeeLogical.ListEmployees.Find(x => x.Id == id));
            }

            UpdateTable();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee form = new FormAddEmployee();
            form.ComboBoxStatus.DataSource = EmployeeLogical.GetListStatuses();
            bool b;
            do
            {
                b = false;
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int age, salary, prize;
                    bool bAge = int.TryParse(form.TextBoxAge.Text, out age);
                    bool bSalary = int.TryParse(form.TextBoxSalary.Text, out salary);
                    bool bPrize = int.TryParse(form.TextBoxPrize.Text, out prize);
                    if (bAge && bSalary && bPrize)
                    {

                        EmployeeLogical.AddEmployee(bAge ? age : 0, form.TextBoxFirstname.Text, bPrize ? prize : 0,
                            bSalary ? salary : 0, EmployeeLogical.GetEnumеStatus(form.ComboBoxStatus.SelectedItem),
                            form.TextBoxFirstname.Text);
                    }
                    else
                    {
                         b = true;
                        MessageBox.Show("Неправильно заполнены поля");
                    }
                    
                }
                else
                {
                    b = false;
                }

            } while (b);

            UpdateTable();
        }

        private void UpdateTable()
        {
            DataGridViewEmployee.DataSource = null;
            DataGridViewEmployee.DataSource = EmployeeLogical.ListEmployees;
        }

        private List<int> SelectedIds()
        {
            var ids = new List<int>();
            var selected = DataGridViewEmployee.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((int)row.Cells["ID"].Value);
            }
            return ids;
        }
    }
}
