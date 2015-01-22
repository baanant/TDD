using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBagImplementation
{
    public interface IMoneyBag
    {

        IMoney GetLatestDeposit();

        decimal WithdrawMoney(IMoney money);

        bool DepositMoney(IMoney money);
        

    }
}
