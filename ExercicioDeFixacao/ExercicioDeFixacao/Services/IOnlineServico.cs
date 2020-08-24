using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Services
{
    interface IOnlineServico
    {
        public double TaxaDoContrato(double amount, int months);

        public double TaxaPaypal(double amount);
    }
}
