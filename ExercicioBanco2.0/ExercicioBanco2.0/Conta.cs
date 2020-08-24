using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Globalization;

namespace Principais
{
    class Conta
    {

        Cliente cliente = new Cliente();
        public void CadastroCliente()
        {

        }

        public void Sacar()
        {

        }

        public void Depositar(string cpf, double saldo)
        {
            cliente.Saldo += saldo;
        }

        public void MostrarSaldo()
        {

        }
    }
}
