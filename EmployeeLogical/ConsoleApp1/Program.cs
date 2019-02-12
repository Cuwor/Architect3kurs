using System;
using EmployeeLogical;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var emplLogical = new EmplLogical();
            emplLogical.CreateFake();
            emplLogical.CreateFake();
            emplLogical.CreateFake();
            emplLogical.GetPremium(0);

            
            emplLogical.DeleteWorker(2);
            emplLogical.AddWorker("Vasya", new DateTime(1992, 2, 2), 400, "Worker");
            WriteLine("Средний доход: "+ emplLogical.AverageSalary());
            foreach (var i in emplLogical.CheckAge()) WriteLine(i);
            foreach (var empl in emplLogical.ReturnEmplsName()) WriteLine(empl);
            ReadKey();
        }
    }
}