using Console_Bank.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Models
{
    internal class Transaction
    {
        private static int transactionCounter;
        public int TransactionId { get; }
        public decimal Amount { get; }
        public DateTime TransactionDate { get; }
        public TransactionType TransactionType { get; }

        public Transaction(decimal amount, TransactionType transactionType)
        {
            TransactionId = ++transactionCounter;
            Amount = amount;
            TransactionDate = DateTime.Now;
            TransactionType = transactionType;

        }
    }
}
