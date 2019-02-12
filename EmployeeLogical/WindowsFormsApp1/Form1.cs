
using System;
using System.Windows.Forms;
using EmployeeLogical;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var emplLogical = new EmplLogical();
            emplLogical.CreateFake();
            emplLogical.CreateFake();
            emplLogical.CreateFake();
            emplLogical.GetPremium(0);

           
            emplLogical.DeleteWorker(2);
            emplLogical.AddWorker("Vasya", new DateTime(1992, 2, 2), 400, "Worker");
            labelSalary.Text = emplLogical.AverageSalary();
            AgeLB.DataSource = emplLogical.CheckAge();
            emplLB.DataSource = emplLogical.ReturnEmplsName();
            
            
        }
    }
}