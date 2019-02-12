using System;
using System.Collections.Generic;
using Employee;


namespace EmployeeLogical
{
    public class EmplLogical
    {
        public List<Empl> Empls = new List<Empl>();

        public List<string> ReturnEmplsName()
        {
            List<string> temp = new List<string>();
            foreach (var empl in Empls)
            {
                temp.Add(empl.Name);
            }

            return temp;
        }
        public void CreateFake()
        {
            Empls.Add(new Empl
            {
                Name = "Игорь",
                DateBurn = new DateTime(1998, 1, 1),
                Selery = 0,
                Status = "Worked"
            });
        }

        public void AddWorker(string name, DateTime dateBurn, int selery, string status)
        {
            var worker = new Empl
            {
                Name = name,
                DateBurn = dateBurn,
                Selery = selery,
                Status = status
            };
            Empls.Add(worker);
        }

        public void DeleteWorker(int numberEmpl)
        {
            var worker = Empls[numberEmpl];
            Empls.Remove(worker);
        }

        public List<int> CheckAge()
        {
            var ageAll = new List<int>();
            var now = DateTime.Today;
            foreach (var empl in Empls)
            {
                var age = now.Year - empl.DateBurn.Year;
                ageAll.Add(age);
            }

            return ageAll;
        }

        public void GetPremium(int numberEmpl)
        {
            var worker = Empls[numberEmpl];
            worker.Premium = 100;
        }

        public string AverageSalary()
        {
            float avS = 0;
            foreach (var i in Empls)
            {
                avS += i.Selery + i.Premium;
            }

            avS = avS / Empls.Count;
            return avS.ToString();
        }
    }
}