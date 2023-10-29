using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Exceptions
{
    internal class AccountNotFoundException:Exception
    {
        public AccountNotFoundException() : base("Account not found.")
        {

        }
    }
}
