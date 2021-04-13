using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    public enum AccountState
    {
        Valid,
        Blocked
    }

    class Account
    {
        private AccountState _state = AccountState.Valid;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _balance;

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public int WithdrawFunds(int bedrag)
        {
            int returnV = 0;
            if (_state == AccountState.Blocked)
            {
                Console.WriteLine($"{Name}, {AccountNumber}: This account is blocked, cannot withdraw funds.");
                returnV = 0;
            }
            else
            {
                if (bedrag > _balance)
                {
                    Console.WriteLine($"{Name}, {AccountNumber}: Could not withdraw the full amount.");
                    returnV = _balance;
                    _balance = 0;
                }
                else
                {
                    _balance -= bedrag;
                    returnV = bedrag;
                }
            }
            Console.WriteLine($"{Name}, {AccountNumber}: Withdrew {returnV}.");
            return returnV;
        }

        public void PayInFunds(int bedrag)
        {
            if (_state == AccountState.Blocked)
            {
                Console.WriteLine($"{Name}, {AccountNumber}: This account is blocked, cannot pay in funds.");
            }
            else
            {
                _balance += bedrag;
                Console.WriteLine($"{Name}, {AccountNumber}: Added {bedrag}.");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void ChangeState(AccountState state)
        {
            _state = state;
            PrintState();
        }

        public void TransferFundsToOther(Account acc, int bedrag)
        {
            acc.PayInFunds(WithdrawFunds(bedrag));

            Console.WriteLine($"{Name}, {AccountNumber} transfered {bedrag:C} to {acc.Name}, {acc.AccountNumber}.");
        }

        public void PrintBalance()
        {
            Console.WriteLine($"The remaining balance of account {Name}, {AccountNumber} is {Balance:C}");
        }

        public void PrintState()
        {
            Console.WriteLine($"The state of account {Name}, {AccountNumber} is {_state}.");
        }
    }
}
