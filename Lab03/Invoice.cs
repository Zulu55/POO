using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Invoice : IToPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetAmountToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return string.Format(@"{0} {1}
                Quantity........: {2,18:N2}
                Price...........: {3,18:C2}
                To Pay..........: {4,18:C2}", 
                Id, Description, Quantity, Price, GetAmountToPay());
        }
    }
}
