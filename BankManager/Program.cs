using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Account account1 = new Account();
            account1.Name = "Tom";
            account1.Balance = rand.Next(0, 5001);
            account1.AccountNumber = "BE16 2546 7824 1357";

            Account account2 = new Account();
            account2.Name = "Tim";
            account2.Balance = rand.Next(0, 5001);
            account2.AccountNumber = "BE02 4562 7468 2056";

            Account account3 = new Account();
            account3.Name = "George";
            account3.Balance = rand.Next(0, 5001);
            account3.AccountNumber = "BE10 3648 5241 3808";

            account1.PrintBalance();
            account2.PrintBalance();
            account3.PrintBalance();
            Console.WriteLine();

            account1.ChangeState(AccountState.Blocked);
            account2.ChangeState(AccountState.Valid);
            account3.ChangeState(AccountState.Valid);
            Console.WriteLine();

            account1.WithdrawFunds(500);
            account2.WithdrawFunds(100);
            account3.WithdrawFunds(2500);
            Console.WriteLine();

            account2.TransferFundsToOther(account1, 500);
            account3.TransferFundsToOther(account3, 600);
            account2.TransferFundsToOther(account3, 250);
            Console.WriteLine();

            account1.PrintBalance();
            account2.PrintBalance();
            account3.PrintBalance();
        }
    }
}
