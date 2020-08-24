using System;
using System.Collections.Generic;
using System.Text;

namespace BankException
{
    class BankExceptions : Exception
    {
        public BankExceptions(string messege) : base(messege)
        {

        }
    }
}
    