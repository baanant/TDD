using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public interface IMoney
    {
        ICurrency Currency { get; set; }

        decimal Amount { get; set; }
    }
}
