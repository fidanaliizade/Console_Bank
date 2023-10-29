using Console_Bank.Enums;
using Console_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Models
{
    internal class Bank
    {
        private BankAccount[] Accounts;
        private bool checkId = false;
        public Bank()
        {
            Accounts = new BankAccount[0];
        }
        public void CreateAccount(string name, string surname, AccountType accountType, CurrencyType currencyType)
        {
            BankAccount account = new BankAccount(accountType, currencyType, name, surname);
            Array.Resize(ref Accounts, Accounts.Length + 1);
            Accounts[Accounts.Length - 1] = account;
            Console.WriteLine($"Account created successfully.  Name : {name}   Surname : {surname}   Account ID : {account.AccountId}");
        }
        private bool FindAccountById(int accountID)
        {
            bool checkId = false;
            try
            {
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountID)
                    {
                        checkId = true;
                        break;
                    }
                }
                if (!checkId)
                {
                    throw new AccountNotFoundException();
                }
                else
                {
                    return true;
                }
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void DepositMoney(int accountId, decimal amount)
        {
            bool checkUser = FindAccountById(accountId);
            if (checkUser)
            {
                try
                {
                    if (amount > 0)
                    {
                        BankAccount bankAccount = null;
                        for (int i = 0; i < Accounts.Length; i++)
                        {
                            if (Accounts[i].AccountId == accountId)
                            {
                                bankAccount = Accounts[i];
                                break;
                            }
                        }
                        Console.WriteLine("Which kind of deposite type do you want?");
                        Console.WriteLine("1. AZN");
                        Console.WriteLine("2. USD");
                        Console.WriteLine("3. EUR");
                        Console.Write("User choice: ");
                        string userChoice = Console.ReadLine();

                        if (userChoice == "1")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Deposit(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Deposit(amount * (decimal)0.59);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Deposit(amount * (decimal)0.55);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                        if (userChoice == "2")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Deposit(amount * (decimal)1.7);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Deposit(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Deposit(amount * (decimal)0.94);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                        if (userChoice == "3")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Deposit(amount * (decimal)1.8);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Deposit(amount * (decimal)1.06);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Deposit(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                    }
                    else
                    {
                        throw new InvalidAmountException();
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void WithdrawMoney(int accountId, decimal amount)
        {
            bool checkUser = FindAccountById(accountId);
            if (checkUser)
            {
                try
                {
                    if (amount > 0)
                    {
                        BankAccount bankAccount = null;
                        for (int i = 0; i < Accounts.Length; i++)
                        {
                            if (Accounts[i].AccountId == accountId)
                            {
                                bankAccount = Accounts[i];
                                break;
                            }
                        }
                        Console.WriteLine("Which kind of deposite type do you want?");
                        Console.WriteLine("1. AZN");
                        Console.WriteLine("2. USD");
                        Console.WriteLine("3. EUR");
                        Console.Write("User choice: ");
                        string userChoice = Console.ReadLine();

                        if (userChoice == "1")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Withdraw(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Withdraw(amount * (decimal)0.59);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Withdraw(amount * (decimal)0.55);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                        if (userChoice == "2")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Withdraw(amount * (decimal)1.7);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Withdraw(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Withdraw(amount * (decimal)0.94);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                        if (userChoice == "3")
                        {
                            if (bankAccount.CurrencyType == CurrencyType.AZN)
                            {
                                bankAccount.Withdraw(amount * (decimal)1.8);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.USD)
                            {
                                bankAccount.Withdraw(amount * (decimal)1.06);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                            if (bankAccount.CurrencyType == CurrencyType.EUR)
                            {
                                bankAccount.Withdraw(amount);
                                Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                            }
                        }
                    }
                    else
                    {
                        throw new InvalidAmountException();
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void TransferMoney(int fromAccountid, int toAccountid, decimal amount)
        {
            bool checkUser1 = FindAccountById(fromAccountid);
            bool checkUser2 = FindAccountById(toAccountid);
            if (checkUser1 && checkUser2)
            {
                try
                {
                    if (amount > 0)
                    {
                        BankAccount fromBankAccount = null;
                        BankAccount toBankAccount = null;
                        for (int i = 0; i < Accounts.Length; i++)
                        {
                            if (Accounts[i].AccountId == fromAccountid)
                            {
                                fromBankAccount = Accounts[i];
                            }
                        }
                        for (int i = 0; i < Accounts.Length; i++)
                        {
                            if (Accounts[i].AccountId == toAccountid)
                            {
                                toBankAccount = Accounts[i];
                            }
                        }

                        if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.AZN)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.USD)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)0.59);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.EUR)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)0.56);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.USD)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.AZN)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)1.7);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.EUR)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)0.94);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.EUR)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.AZN)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)1.8);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                        else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.USD)
                        {
                            if (fromBankAccount.Balance < amount)
                            {
                                Console.WriteLine("Invalid amount entered.");
                                return;
                            }
                            fromBankAccount.Withdraw(amount);
                            toBankAccount.Deposit(amount * (decimal)1.06);
                            Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                            Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                        }
                    }
                    else
                    {
                        throw new InvalidAmountException();
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public BankAccount[] GetAllAccounts()
        {
            return Accounts;
        }
        public void TransactionList(int accountId)
        {
            bool chekcId = FindAccountById(accountId);
            if (chekcId)
            {
                BankAccount bankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountId)
                    {
                        bankAccount = Accounts[i];
                        break;
                    }
                }
                Console.WriteLine($"\n\t{bankAccount.Name} {bankAccount.Surname} Transaction List\n");
                foreach (var item in bankAccount.GetTransactionList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"Transaction amount: {item.Amount}");
                    Console.WriteLine($"Transaction date time: {item.TransactionDate}");
                    Console.WriteLine($"Transaction type: {item.TransactionType}");
                    Console.WriteLine();
                }
            }
        }
        public void CurrencyConversion(int accountId)
        {
            bool checkUser = FindAccountById(accountId);
            if (checkUser)
            {
                BankAccount bankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountId)
                    {
                        bankAccount = Accounts[i];
                        break;
                    }
                }

                Console.WriteLine($"Which currency type do you want to change(Your currency type: {bankAccount.CurrencyType}):");
                if (bankAccount.CurrencyType == CurrencyType.AZN)
                {
                    Console.WriteLine("2. USD");
                    Console.WriteLine("3. EUR");
                    Console.Write("User choice: ");
                    string userChoice = Console.ReadLine();
                    if (CurrencyType.TryParse(userChoice, out CurrencyType newCurrencyType))
                    {
                        switch (newCurrencyType)
                        {
                            case CurrencyType.USD:
                                bankAccount.CurrencyType = CurrencyType.USD;
                                decimal newBalance = bankAccount.Balance * (decimal)0.59;
                                bankAccount.Balance = newBalance;
                                break;
                            case CurrencyType.EUR:
                                bankAccount.CurrencyType = CurrencyType.EUR;
                                decimal newBalance2 = bankAccount.Balance * (decimal)0.55;
                                bankAccount.Balance = newBalance2;
                                break;
                        }
                    }
                }
                else if (bankAccount.CurrencyType == CurrencyType.USD)
                {
                    Console.WriteLine("1. AZN");
                    Console.WriteLine("3. EUR");
                    Console.Write("User choice: ");
                    string userChoice2 = Console.ReadLine();
                    if (CurrencyType.TryParse(userChoice2, out CurrencyType newCurrencyType2))
                    {
                        switch (newCurrencyType2)
                        {
                            case CurrencyType.AZN:
                                bankAccount.CurrencyType = CurrencyType.AZN;
                                decimal newBalance = bankAccount.Balance * (decimal)1.7;
                                bankAccount.Balance = newBalance;
                                break;
                            case CurrencyType.EUR:
                                bankAccount.CurrencyType = CurrencyType.EUR;
                                decimal newBalance2 = bankAccount.Balance * (decimal)0.94;
                                bankAccount.Balance = newBalance2;
                                break;
                        }
                    }
                }
                else if (bankAccount.CurrencyType == CurrencyType.EUR)
                {
                    Console.WriteLine("1. AZN");
                    Console.WriteLine("2. USD");
                    Console.Write("User choice: ");
                    string userChoice3 = Console.ReadLine();
                    if (CurrencyType.TryParse(userChoice3, out CurrencyType newCurrencyType3))
                    {
                        switch (newCurrencyType3)
                        {
                            case CurrencyType.AZN:
                                bankAccount.CurrencyType = CurrencyType.AZN;
                                decimal newBalance = bankAccount.Balance * (decimal)1.8;
                                bankAccount.Balance = newBalance;
                                break;
                            case CurrencyType.EUR:
                                bankAccount.CurrencyType = CurrencyType.EUR;
                                decimal newBalance2 = bankAccount.Balance * (decimal)1.06;
                                bankAccount.Balance = newBalance2;
                                break;
                        }
                    }
                }
            }
        }
    }
}
