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
            //======= Exercicio 4 =======
            /*
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
            */
            //======= Exercicio 5 =======
            /*
            int codigo1, nPecas1, codigo2, nPecas2;
            double valor1, valor2, soma;
            Console.Write("Escreva o código, quantidade de peças e valor da 1 peça: ");
            
            string[] vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            nPecas1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.Write("Escreva do 2 peça: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            nPecas2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            soma = nPecas1 * valor1 + nPecas2 * valor2;

            Console.WriteLine($"Valor da compra: R${soma.ToString("F2", CultureInfo.InvariantCulture)}");
            */
            //======= Exercicio 5 =======

            double a, b, c, pi = 3.14159, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Escreva os valores de A, B e C para calcularmos a area: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            circulo = (c * c) * pi;
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"AREAS: \n TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}\nCIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)} \n TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)} \n" +
                $" QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)} \n RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }

    }
}