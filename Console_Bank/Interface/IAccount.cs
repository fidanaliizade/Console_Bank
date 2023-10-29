using Console_Bank.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Interface
{
    internal interface IAccount
    {
        public int AccountId { get; }
        public decimal Balance { get; }
        public AccountType AccountType { get; }
        public CurrencyType CurrencyType { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
