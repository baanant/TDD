using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBagImplementation;
using NUnit.Framework;
using FluentAssertions;
using Moq;

namespace TDDTesting
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void MoneyBag_DepositMoney_Success()
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
            decimal withdrawed = bag.WithdrawMoney(money);
        }


        [Test]
        public void MoneyBag_CalculateMoneyInCurrency_Success()
        {
            //Let's utilize MOQ here. Let's bypass CalculateMoneyInCurrency method's IsRateAcceptable line.
            var mockedCurr = new Mock<ICurrency>();
            mockedCurr.Setup(x => x.IsRateAcceptable()).Returns(true);

            IMoneyBag bag = new MoneyBag(); //Empty MoneyBag.

            //Now, while using mocked Currency object, its IsRateAcceptableMethod should not throw NotImplementedException.
            bag.CalculateMoneyInCurrency(mockedCurr.Object).Should().BeOfType<Money>().Which.Amount.Should().Be(0.00m);          
        }

        [Test]
        public void MoneyBag_CalculateMoneyInCurrency_Failure()
        {
            IMoneyBag bag = new MoneyBag();
            IMoney money = new Money();
            ICurrency currency = new Currency("EUR", "Euro");
            bag.Invoking(x => x.CalculateMoneyInCurrency(currency)).ShouldThrow<NotImplementedException>().WithMessage("This is not implemented yet!");
            
        }

        [Test]
        public void MoneyBag_GetLatestDeposit_Success()
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
