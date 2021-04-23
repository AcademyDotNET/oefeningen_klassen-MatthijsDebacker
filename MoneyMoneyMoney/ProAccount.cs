using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    class ProAccount : SavingsAccount
    {
        public override double CalculateIntrest()
        {
            return base.CalculateIntrest() + (Math.Floor(Balance / 1000) * 10.0);
        }
    }
}
