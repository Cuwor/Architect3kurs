using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee: IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public bool Accepted { get; set; }
        public int Salary { get; set; }

        public virtual List<Project> Projects { get; set; }
    }
}
