using System;
using System.Globalization;

namespace ExercicioEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Exercicio 1

             int numero, r = 0;

             Console.WriteLine("Escreva o número: ");
             numero = int.Parse(Console.ReadLine());

             if (numero < 0)
             {
                 Console.WriteLine("NEGATIVO ");
             }
             else
             {
                 Console.WriteLine("NÃO NEGATIVO ");
             } */

            /* //Exercicio 2
            int numero;

            Console.WriteLine("Escreva o número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */
            /* //Exercicio 3

            int A, B;
            Console.WriteLine("Digite o número A e o número B: ");
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não São Multiplos");
            }
            */

            /* //Exercicio 4
            int hrInicial, hrFinal, maxima = 24, hora;

            Console.Write("Escreva a hora inicial e a hora final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');
            hrInicial = int.Parse(vet[0]);
            hrFinal = int.Parse(vet[1]);

            
            if (hrInicial < hrFinal) {
                hora = hrFinal - hrInicial;

            }
            else
            {
                hora = maxima - hrInicial + hrFinal;
            }
            Console.WriteLine($"O jogo durou {hora} Hora(s) ");
            */
            /* //Exercicio 5
            Console.WriteLine("Escreva o codigo do item e a quantidade ");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /* //Exercicio 6
            double valor;

            Console.WriteLine("Escreva um valor: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor > 25 && valor < 50)
            {
                Console.WriteLine("Intervalo (25,50] ");
            }
            else if (valor > 0 && valor <= 25) {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */
            /* //Exercicio 7

            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
            */
            double renda;

            Console.WriteLine("Escreva sua renda: ");
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (renda <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (renda <= 3000.0)
            {
                imposto = (renda - 2000.0) * 0.08;
            }
            else if (renda <= 4500.0)
            {
                imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
