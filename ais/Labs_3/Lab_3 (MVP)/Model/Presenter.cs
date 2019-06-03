using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using View1;


namespace Presenter
{
    public class Presenter
    {
        public EmployeeLogical EmployeeLogical { get; set; }
        public FormEmployee View { get; set; }

        public Presenter()
        {
            EmployeeLogical=new EmployeeLogical();
            View=new FormEmployee(UpdateTable);
            View.AddEmployee += Add_Click;
            View.DeleteEmployee += Delete_Click;
            View.ChangeEmployee += Change_Click;
            View.InfoEmployee += Information_Click;
            View.ShowDialog();
        }
        
        private void Change_Click(FormEmployee view)
        {
            if (View.SelectedIds().Count == 1)
            {
                int idE = View.SelectedIds()[0];
                FormAddEmployee form = new FormAddEmployee();
                form.ComboBoxStatus.DataSource = EmployeeLogical.GetListStatuses();
                form.TextBoxAge.Text = EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Age.ToString();
                form.TextBoxSalary.Text = EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Salary.ToString();
                form.TextBoxPrize.Text = EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Prize.ToString();
                form.ComboBoxStatus.SelectedItem = EmployeeLogical.GetEnumеStatus(EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Status);
                form.TextBoxFirstname.Text = EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Firstname.ToString();
                form.TextBoxSurname.Text = EmployeeLogical.ListEmployees.Find(x => x.ID == idE).Surname.ToString();

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
                
            }
        }

        private void Information_Click(FormEmployee view)
        {
            FormInformationEmployees form = new FormInformationEmployees();
            form.label6.Text = EmployeeLogical.ListEmployees.Count.ToString();
            form.label7.Text = EmployeeLogical.GetEmployeesEnumeStatusAccept().Count.ToString();
            form.label8.Text = EmployeeLogical.GetEmployeesEnumeStatusFire().Count.ToString();
            form.label9.Text = EmployeeLogical.GetAverageAge().ToString();
            form.label10.Text = EmployeeLogical.GetAverageSalary().ToString();
            form.ShowDialog();
        }

        private void Delete_Click(FormEmployee view)
        {
            EmployeeLogical.DelleteEmployee(View.SelectedIds());
            
        }

        private void Add_Click(FormEmployee view)
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

            
        }

        private void UpdateTable(FormEmployee view)
        {
            view.DataGridViewEmployee.DataSource = null;
            view.DataGridViewEmployee.DataSource = EmployeeLogical.ListEmployees;
        }


    }
    
}
