using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Model;

namespace AIS_ViewConsole
{
    class Program
    {
        public static EmployeeLogical EL = new EmployeeLogical();

        public static void UpdateScreen()
        {
            Console.Clear();
            foreach (Employee emp in EL.ReturnAcceptedEmps())
            {
                Console.Write("{0} \nВозраст: {1} \nЗП: {2}", emp.Name, EL.CurrentAge(emp), emp.Salary);
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n1.Принять  2.Уволить \n3.Премировать  4.Оштрафовать \n");
        }

        public static void Fire()
        {
            if (EL.ReturnAcceptedEmps().Count>0)
            {
                Console.WriteLine("Введите номер увольняемого \n");
                int i = 0;
                foreach (Employee emp in EL.ReturnAcceptedEmps())
                {
                    Console.Write(i + ". " + emp.Name + "\n");
                    i++;
                }
                Console.WriteLine();
                int numb = int.Parse(Console.ReadLine());

                EL.Fire(EL.ReturnAcceptedEmps()[numb]);
                UpdateScreen();
            }
            else
            {
                Console.WriteLine("Уже некого увольнять");
                Console.ReadKey();
            }
        }

        public static void Accept()
        {
            if (EL.ReturnFiredEmps().Count>0)
            {
                Console.WriteLine("Введите номер принимаемого \n");
                int i = 0;
                foreach (Employee emp in EL.ReturnFiredEmps())
                {
                    Console.Write(i + ". " + emp.Name + "\n");
                    i++;
                }
                Console.WriteLine();
                int numb = int.Parse(Console.ReadLine());

                EL.Accept(EL.ReturnFiredEmps()[numb]);
                UpdateScreen();
            }
            else
            {
                Console.WriteLine("Пока некого принимать");
                Console.ReadKey();
            }
        }

        public static void GetPremium()
        {
            Console.WriteLine("Введите номер сотрудника \n");
            int i = 0;
            foreach (Employee emp in EL.ReturnAcceptedEmps())
            {
                Console.Write(i + ". " + emp.Name + "\n");
                i++;
            }
            Console.WriteLine();
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму премии \n");
            int bonus = int.Parse(Console.ReadLine());

            EL.GetPremium(EL.ReturnAcceptedEmps()[numb],bonus);
            UpdateScreen();

        }

        public static void SetFine()
        {
            Console.WriteLine("Введите номер сотрудника \n");
            int i = 0;
            foreach (Employee emp in EL.ReturnAcceptedEmps())
            {
                Console.Write(i + ". " + emp.Name + "\n");
                i++;
            }
            Console.WriteLine();
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму штрафа \n");
            int badbonus = int.Parse(Console.ReadLine());

            EL.SetFine(EL.ReturnAcceptedEmps()[numb], badbonus);
            UpdateScreen();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во сотрудников на предприятии: ");
            int count = int.Parse(Console.ReadLine());

            EL.FillCollection(count);

            while(true)
            {
                UpdateScreen();
                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        Accept();
                        break;
                    case 2:
                        Fire();
                        break;
                    case 3:
                        GetPremium();
                        break;
                    case 4:
                        SetFine();
                        break;
                }
                
            }
        }

        
    }
}
