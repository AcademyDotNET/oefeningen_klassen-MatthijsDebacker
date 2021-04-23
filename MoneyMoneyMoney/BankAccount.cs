using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    class BankAccount : Account
    {
        public override double CalculateIntrest()
        {
            if (Balance > 100)
            {
                return Balance + Balance * 0.05;
            }
            else return Balance;
        }
    }
}
