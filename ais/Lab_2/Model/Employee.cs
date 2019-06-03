using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public EnumеStatus Status { get; set; }

        public int Prize { get; set; }
    }
}
