using System;
using System.Globalization;
using ExercicioStaticos;

namespace ExercicioStaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, quantidade;
            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.RealParaDolar(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
