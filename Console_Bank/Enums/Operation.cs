using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Enums
{
    internal enum Operation
    {
        CreateAccount = 1,
        DepositMoney,
        WithdrawMoney,
        ListTransactions,
        ListAccounts,
        TransferMoney,
        CurrencyConversion,
        Exit
    }
}
