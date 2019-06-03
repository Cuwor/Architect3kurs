using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace View1
{
    public delegate void EventHandler(FormEmployee form);


    public partial class FormEmployee : Form
    {
      
        public event EventHandler UpdatetTable;
        public event EventHandler DeleteEmployee;
        public event EventHandler AddEmployee;
        public event EventHandler ChangeEmployee;
        public event EventHandler InfoEmployee;

        public FormEmployee(EventHandler eventHandler)
        {
            InitializeComponent();
            UpdatetTable += eventHandler;
            if (UpdatetTable != null) UpdatetTable.Invoke(this);
        }

        private void ButtonFakeDataEmployees_Click(object sender, EventArgs e)
        {
            //EmployeeLogical.ListEmployees.AddRange(EmployeeLogical.GetEmployees());
            //UpdateTable();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (ChangeEmployee != null) ChangeEmployee.Invoke(this);
            if (UpdatetTable != null) UpdatetTable.Invoke(this);
        }

        private void ButtonInformation_Click(object sender, EventArgs e)
        {
            if (InfoEmployee != null) InfoEmployee.Invoke(this);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DeleteEmployee != null) DeleteEmployee.Invoke(this);
            if (UpdatetTable != null) UpdatetTable.Invoke(this);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (AddEmployee != null) AddEmployee.Invoke(this);
            if (UpdatetTable != null) UpdatetTable.Invoke(this);
        }
        
        public List<int> SelectedIds()
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
