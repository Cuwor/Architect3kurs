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
using Model;

namespace AIS_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeLogical.RemoveCollection();
            ProjectLogical.RemoveCollection();
            ShowProjects.Enabled = false;
            AcceptedEmps.ItemSelectionChanged += SelectionChanged;
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Count.Text);
            EmployeeLogical.FillCollection(n);
            UpdateData();
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            EmployeeLogical.Fire((Employee)EmpsForFire.SelectedItem);
            UpdateData();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            EmployeeLogical.Accept((Employee)EmpsForAccept.SelectedItem);
            UpdateData();
        }

        private void Premium_Click(object sender, EventArgs e)
        {
            EmployeeLogical.GetPremium((Employee)AcceptedEmps1.SelectedItem, int.Parse(Bonus.Text));
            UpdateData();
        }

        private void Fine_Click(object sender, EventArgs e)
        {
            EmployeeLogical.SetFine((Employee)AcceptedEmps2.SelectedItem, int.Parse(BadBonus.Text));
            UpdateData();
        }

        public void UpdateData()
        {
            Count.Text = "";
            Bonus.Text = "";
            BadBonus.Text = "";
            Average.Text = "...";
            EmpsForFire.DataSource = new List<Employee>();
            AcceptedEmps1.DataSource = new List<Employee>();
            AcceptedEmps2.DataSource = new List<Employee>();
            EmpsForAccept.DataSource = new List<Employee>();
            AcceptedEmps.Items.Clear();
            List<Employee> emps = EmployeeLogical.ReturnAcceptedEmps();

            foreach (Employee emp in emps)
            {
                AcceptedEmps.Items.Add(emp.Name);
                AcceptedEmps.Items.Add("Возраст: " + EmployeeLogical.CurrentAge(emp));
                AcceptedEmps.Items.Add("ЗП: " + emp.Salary);
                AcceptedEmps.Items.Add(" ");
            }

            EmpsForFire.DataSource = EmployeeLogical.ReturnAcceptedEmps();
            EmpsForFire.DisplayMember = "Name";

            AcceptedEmps1.DataSource = EmployeeLogical.ReturnAcceptedEmps();
            AcceptedEmps1.DisplayMember = "Name";

            AcceptedEmps2.DataSource = EmployeeLogical.ReturnAcceptedEmps();
            AcceptedEmps2.DisplayMember = "Name";

            EmpsForAccept.DataSource = EmployeeLogical.ReturnFiredEmps();
            EmpsForAccept.DisplayMember = "Name";

            Average.Text = EmployeeLogical.AverageSalary(EmployeeLogical.ReturnAcceptedEmps()).ToString();
        }

        private void ShowProjects_Click(object sender, EventArgs e)
        {
            foreach(Employee emp in EmployeeLogical.ReturnAcceptedEmps())
            {
                if (AcceptedEmps.FocusedItem.Text.Equals(emp.Name))
                {
                    Form2 form2 = new Form2(emp);
                    form2.Owner = this;
                    form2.Show();
                }
            }
        }

        private void AllProjects_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.FormClosed += FormClosing;
            form3.Show();
        }

        new private void FormClosing(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (AcceptedEmps.SelectedItems.Count==0 || AcceptedEmps.SelectedItems[0].Text.Equals(" "))
            {
                ShowProjects.Enabled = false;
            }
            else
            {
                ShowProjects.Enabled = true;
                if (AcceptedEmps.SelectedItems[0].Text.Contains("Возраст: "))
                {
                    AcceptedEmps.FocusedItem = ((ListView)sender).Items[((ListView)sender).SelectedItems[0].Index - 1];
                }

                if (AcceptedEmps.SelectedItems[0].Text.Contains("ЗП: "))
                {
                    AcceptedEmps.FocusedItem = ((ListView)sender).Items[((ListView)sender).SelectedItems[0].Index - 2];
                }
            }
        }
    }
}
