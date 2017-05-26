using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            var debts = new List<IToPay>();

            debts.Add(new Invoice
            {
                Description = "Beer",
                Id = 1222,
                Price = 2500,
                Quantity = 46,
            });

            debts.Add(new Invoice
            {
                Description = "Hot water Blue",
                Id = 5333,
                Price = 35000,
                Quantity = 3,
            });

            debts.Add(new SalariedEmployee
            {
                FirstName = "Esperanza",
                Id = 229090,
                LastName = "Gomez",
                Salary = 300000,
            });

            decimal total = 0;
            foreach (var debt in debts)
            {
                Console.WriteLine(debt);
                total += debt.GetAmountToPay();
            }

            Console.WriteLine("                                  ==================");
            Console.WriteLine("TOTAL...........................: {0,18:C2}", total);
            Console.ReadKey();
        }
    }
}
