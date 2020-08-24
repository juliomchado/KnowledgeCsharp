using System;
using ExercicioFixacaoOrientacaoaObjeto;
using System.Globalization;

namespace ExercicioFixacaoOrientacaoaObjeto
{
    class Program
    {

        static void Main(string[] args)
        {
            /* //Exercicio1
                Retangulo a = new Retangulo();

                Console.WriteLine("Entre com a largura e altura do retângulo: ");
                a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(a);
                */

            /*//Exercicio2
            double porcentagem;
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {func}");


            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            func.AumentoSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {func}");
            */
            /*//Exercicio3
            Aluno al = new Aluno();

            Console.Write("Nome do Aluno: ");
            al.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(al);

            if (al.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram: {al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} Pontos");
            }
            */
        }
    }
}
