using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Services
{
    class ServicoPaypal : IOnlineServico
    {
        public const double TaxaMensal = 0.01;

        public const double Porcentage = 0.02;


        public double TaxaDoContrato(double amount, int months)
        {
            return amount * TaxaMensal * months;
        }

        public double TaxaPaypal(double amount)
        {
            return  amount * Porcentage;
        }
    }
}
