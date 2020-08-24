using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    interface IDeposit
    {
        double Deposit(string registry, double amount);
    }
}
