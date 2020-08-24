using System;
using System.Globalization;
namespace ExerciciosSequencial
{
    class Program
    {
        static void Main(string[] args)
        {//======= Exercicio 1 =======
         /* 
         int n1 = int.Parse(Console.ReadLine());
         int n2 = int.Parse(Console.ReadLine());

         int soma = n1 + n2;
         Console.WriteLine($"SOMA = {soma}");*/

            //======= Exercicio 2 =======
            /*
            double pi = 3.14159, raio;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raio *= raio * pi;

            Console.WriteLine("A= " + raio.ToString("F4"));
            */
            //======= Exercicio 3 =======
            /*int A, B, C, D, diferenca;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine("Diferença = " +diferenca);
            */

            int funcionario;
            double HorasT, valorP, soma;
            Console.WriteLine("Seu número de funcionário: ");
            funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas trabalhadas: ");
            HorasT = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por horas: ");
            valorP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = HorasT * valorP;

            Console.WriteLine($"Numero = {funcionario}");
            Console.WriteLine($"Salario = U$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");



        }

    }
}
