using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Manipulations;

namespace Service
{
    class Services : IServiceRegistryBrazil, IDeposit, IWithdraw
    {
        public void RegisterClients(string name, string registry, double saldo = 0)
        {
          
            ServicesManipulations.VerifyAccExists(1,name, registry);          
        }

        public  double Deposit(string registry, double amount)
        {
            throw new NotImplementedException();
        }


        public double Withdraw(string registry, double amount)
        {
            throw new NotImplementedException();
        }

        public void SearchBalance(string registry)
        {

        }
    }
}
