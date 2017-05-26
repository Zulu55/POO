using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var employess = new List<Employee>();

            var emp1 = new SalariedEmployee(1010, "Celia", "Cruz", 1300000);
            employess.Add(emp1);
            var emp2 = new SalariedEmployee(2020, "Hector", "Lavoe", 2700000);
            employess.Add(emp2);
            var emp3 = new CommissionedEmployee(3030, "Natalia", "Paris", 250000000, 0.023);
            employess.Add(emp3);
            var emp4 = new CommissionedEmployee(4040, "Esperanza", "Gomez", 340000000, 0.027);
            employess.Add(emp4);
            var emp5 = new HourlyEmployee(5050, "Freddy", "Mercury", 167, 13500);
            employess.Add(emp5);
            var emp6 = new HourlyEmployee(6060, "Liv", "Taylor", 245, 45000);
            employess.Add(emp6);
            var emp7 = new CommisionedBaseEmployee(7070, "Tatiana", "De Los Rios", 32000000, 0.012, 670000);
            employess.Add(emp7);

            decimal paySheet = 0;
            foreach (var employee in employess)
            {
                Console.WriteLine(employee);
                paySheet += employee.CalculateSalary();
            }

            Console.WriteLine("                              ==================");
            Console.WriteLine("Pay sheet...................: {0,18:C2}", paySheet);
            Console.ReadKey();
        }
    }
}
