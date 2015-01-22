using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBagImplementation;
using NUnit.Framework;
using FluentAssertions;

namespace TDDTesting
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void MoneyBag_DepositMoneyToMoneyBag_Success()
        {
            
            IMoneyBag bag = new MoneyBag();
            IMoney toDeposit = new Money();
            bag.DepositMoney(toDeposit).Should().BeFalse();

        }




        [Test,ExpectedException(typeof(NotImplementedException))]
        public void MoneyBag_WithdrawMoney_Success()
        {
            IMoneyBag bag = new MoneyBag();
            IMoney money = new Money();
            bag.WithdrawMoney(money);
        }


        [Test,Ignore]
        public void MoneyBag_CalculateMoneyInEur_Success()
        {
           
        }

        [Test]
        public void MoneyBag_GetLatestAddedMoney_Success()
        {
            ICurrency eur = new Currency("EUR","Euro");
            ICurrency usd = new Currency("USD", "US dollar");


            Money[] deposits = { new Money(eur, 114.2m), new Money(usd,21.3m), new Money(eur,13.44m)};
            IMoneyBag bag = new MoneyBag(deposits);
            IMoney actual = bag.GetLatestDeposit();

            actual.Should().BeOfType<Money>().Which.Currency.Identifier.Should().Be("EUR");
            actual.Amount.Should().Be(13.44m);
        }

    }
}
