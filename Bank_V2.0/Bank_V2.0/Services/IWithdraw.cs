using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    interface IWithdraw
    {
        double Withdraw(string registry, double amount);
    }
}
