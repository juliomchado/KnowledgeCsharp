using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    interface IServiceRegistryBrazil
    {
        public void RegisterClients(string name, string registry, double saldo = 0);
    }
}
