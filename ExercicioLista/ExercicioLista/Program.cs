using System;
using System.Globalization;
using ExercicioLista;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id, pesquisarId, QuantidadeEmpregados;
            string Nome;
            double Salario , porcentagem;

            List<Empregado> lista = new List<Empregado>();

            Console.Write("Quantos empregados será registrados? ");
            QuantidadeEmpregados = int.Parse(Console.ReadLine());

            for(int empregados = 1; empregados <= QuantidadeEmpregados; empregados++)
            {
                Console.WriteLine($"Empregado: #{empregados}");

                Console.Write("Id: ");
                Id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                Nome = Console.ReadLine();

                Console.Write("Salário: ");
                Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Empregado(Id, Nome, Salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o id para incrementar o salario: ");
            pesquisarId = int.Parse(Console.ReadLine());
            lista.Find(x => x.Id == pesquisarId);

            if(pesquisarId != null)
            {
                Console.Write("Entre com a porcentagem: ");
                porcentagem = double.Parse(Console.ReadLine());

            }
            else
                Console.Write("Esse id não existe! ");

            Console.WriteLine();
            Console.WriteLine("Lista atualizad");
            foreach(Empregado obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
