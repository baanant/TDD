using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public class MoneyBag : IMoneyBag
    {
        private List<IMoney> moneyBag;

        private IMoney lastAdded;

        public MoneyBag()
        {
            this.moneyBag = new List<IMoney>();
            this.lastAdded = null;
        }

        public MoneyBag(IEnumerable<IMoney> moneys)
        {
            this.moneyBag = moneys.ToList<IMoney>();
            this.lastAdded = moneys.ToList().Last();
        }






        public IMoney GetLatestDeposit()
        {
            return this.lastAdded;
        }


        


        public bool DepositMoney(IMoney money)
        {
            try
            {

                if (money.Currency != null && money.Amount != 0.0m)
                {
                    this.moneyBag.Add(money);
                    this.lastAdded = money;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Could not deposit money.", ex);
            }

        }


        public decimal WithdrawMoney(IMoney money)
        {
            throw new NotImplementedException();
        }
    }
}
