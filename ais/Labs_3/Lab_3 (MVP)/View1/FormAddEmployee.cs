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
    public partial class FormAddEmployee : Form
    {
        

        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private string GetParseInt(string sOld)
        {
            string sNew = "";
            foreach (var c in sOld)
            {
                if (new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }.Contains(c))
                {
                    sNew += c;
                }
            }

            return sNew;
        }


        private void TextBoxAge_TextChanged(object sender, EventArgs e)
        {
            TextBoxAge.Text = GetParseInt(TextBoxAge.Text);
        }

        private void TextBoxSalary_TextChanged(object sender, EventArgs e)
        {
            TextBoxSalary.Text = GetParseInt(TextBoxSalary.Text);
        }

        private void TextBoxPrize_TextChanged(object sender, EventArgs e)
        {
            TextBoxPrize.Text = GetParseInt(TextBoxPrize.Text);
        }
    }
}
