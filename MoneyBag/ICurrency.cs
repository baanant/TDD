using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public interface ICurrency
    {
        string Description { get; set; }

        string Identifier { get; set; }
    }
}
