using System;

namespace MoneyMoneyMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AddMoney(2500);
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.AddMoney(20000);
            ProAccount proAccount = new ProAccount();
            proAccount.AddMoney(20000);

            Console.WriteLine(bankAccount);
            Console.WriteLine(savingsAccount);
            Console.WriteLine(proAccount);
        }
    }
}
