using System;
using System.Collections.Generic;
using System.Text;
using ExercicioDeFixacao.Entities;

namespace ExercicioDeFixacao.Services
{
    class ServicoContrato
    {
        private IOnlineServico _iOnlineServico;

        public ServicoContrato(IOnlineServico iOnlineServico)
        {
            _iOnlineServico = iOnlineServico;
        }

        public void MeusContratos(Contratos contratos, int months)
        {
            
            double contrat = contratos.ValorTotal / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime data = contratos.Date.AddMonths(i);
                double AdicionarTaxaContrato = contrat + _iOnlineServico.TaxaDoContrato(contrat, i);
                double AdicionarTaxaPaypal = AdicionarTaxaContrato + _iOnlineServico.TaxaPaypal(contrat);
                contratos.AddPrestacao(new Prestacao(data, AdicionarTaxaPaypal));
            }
        }
    }
}
