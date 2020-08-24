using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercicioDeFixacao.Entities;
using ExercicioDeFixacao.Services;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double valueC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contratos contract = new Contratos(number, date, valueC);

            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPaypal());
            servicoContrato.MeusContratos(contract, numberInstallments);

            Console.WriteLine("Installments: ");
            foreach(Prestacao obj in contract.Prestacao)
            {
                Console.WriteLine(obj);
            }



        }

    }
}
