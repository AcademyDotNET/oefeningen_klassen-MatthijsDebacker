using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    class SavingsAccount : Account
    {
        public override double CalculateIntrest()
        {
            return Balance + Balance * 0.02;
        }
    }
}
