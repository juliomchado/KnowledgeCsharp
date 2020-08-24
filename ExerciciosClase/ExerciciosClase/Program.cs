using System;
using ExerciciosClase;
using System.Globalization;
namespace ExerciciosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Exercicio1
            Pessoas Pessoa1, Pessoa2;
            Pessoa1 = new Pessoas();
            Pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira Pessoa: ");
            Console.Write("Nome: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa: ");
            Console.Write("Nome: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            if (Pessoa1.Idade > Pessoa2.Idade)
            {
                Console.WriteLine($"A mais velha é a : {Pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"A mais velha é a : {Pessoa2.Nome}");
            }
            */

            /*//Exercicio2
            Funcionarios Func1, Func2;
            Func1 = new Funcionarios();
            Func2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Func1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Func2.Nome = Console.ReadLine() ;
            Console.Write("Idade: ");
            Func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Func1.Salario + Func2.Salario) / 2;
            Console.WriteLine($"Salária médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            */
        }
    }
}
