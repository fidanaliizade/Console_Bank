using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank.Exceptions
{
    internal class InvalidAmountException:Exception
    {
        public InvalidAmountException() : base("Invalid amount entered.")
        {

        }
    }
}
