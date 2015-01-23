using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public class Money : IMoney
    {


        public Money()
        {
            this.Currency = null;
            this.Amount = 0.0m;
        }

        public Money(ICurrency curr, decimal amount)
        {
            this.Currency = curr;
            this.Amount = amount;
        }

        public ICurrency Currency { get; set; }

        public decimal Amount { get; set; }
    }
}
