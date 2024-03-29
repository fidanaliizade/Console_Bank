﻿using Console_Bank.Enums;
using Console_Bank.Exceptions;
using Console_Bank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Models
{
    internal class BankAccount:IAccount
    {

        public int AccountId { get; set; }
        private static int count;
        public decimal Balance { get; set; }
        public AccountType AccountType { get; set; }
        public CurrencyType CurrencyType { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        private Transaction[] transactions;

        public BankAccount(AccountType accountType, CurrencyType currencyType, string name, string surname)
        {
            AccountId = ++count;
            Balance = 0;
            AccountType = accountType;
            CurrencyType = currencyType;
            Name = name;
            Surname = surname;
            transactions = new Transaction[0];
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidAmountException();
                }
                else
                {
                    Balance += amount;
                    Transaction transaction = new Transaction(amount, TransactionType.DepositMoney);
                    Array.Resize(ref transactions, transactions.Length + 1);
                    transactions[transactions.Length - 1] = transaction;
                }
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidAmountException();
                }
                else
                {
                    try
                    {
                        if (Balance < amount)
                        {
                            throw new InsufficientFundsException();
                        }
                        else
                        {
                            Balance -= amount;
                            Transaction transaction = new Transaction(amount, TransactionType.WithdrawMoney);
                            Array.Resize(ref transactions, transactions.Length + 1);
                            transactions[transactions.Length - 1] = transaction;
                        }
                    }
                    catch (InsufficientFundsException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Transaction[] GetTransactionList()
        {
            return transactions;
        }
    }
}
