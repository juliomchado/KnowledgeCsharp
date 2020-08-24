using System;
using ExercicioFixacaoEncapsulamentoEtc;
using System.Globalization;

namespace ExercicioFixacaoEncapsulamentoEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            int numero;
            string titular;
            char resp;
            double deposito, quantia;
            
            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? ");
            resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            }
            else
                conta = new ContaBancaria(numero, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}
