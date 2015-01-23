using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public class Currency:ICurrency 
    {

        public Currency() { }

        public Currency(string identifier, string description)
        {
            this.Identifier = identifier;
            this.Description = description;
        }

        public string Identifier { get; set; }

        public string Description { get; set; }




        public bool IsRateAcceptable()
        {
            throw new NotImplementedException("This is not implemented yet!");
        }
    }
}
