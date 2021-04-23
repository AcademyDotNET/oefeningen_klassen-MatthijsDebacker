using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    abstract class Account
    {
        private double balance = 0.0;

        public double Balance
        {
            get 
            { 
                return balance; 
            }
        }

        public void AddMoney(double amount)
        {
            balance += amount;
        }

        public void TakeMoney(double amount)
        {
            balance += amount;
        }

        public abstract double CalculateIntrest();

        public override string ToString()
        {
            return $"{this.GetType()} Balance: {Balance} | Balance with Interest: {CalculateIntrest()}";
        }
    }
}
