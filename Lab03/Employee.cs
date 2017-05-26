using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public abstract class Employee : IToPay
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract decimal GetAmountToPay();

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, FirstName, LastName);
        }
    }
}
