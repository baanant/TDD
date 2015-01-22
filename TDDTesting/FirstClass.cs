using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDTesting
{
    
    public class FirstClass
    {

        [Test,ExpectedException(typeof(NotImplementedException))]
        public void MoneyBag_AddMoneyToMoneyBag_Success()
        {
            throw new NotImplementedException();
        }


        [Test,Ignore]
        public void MoneyBag_WithdrawMoneyFromMoneyBag_Success()
        {
            
        }


        [Test]
        public void MoneyBag_WithdrawMoneyFromMoneyBag_Failure()
        {
            if (true) Assert.Fail("Money withdrawal did not succeed.");
        }

    }
}
