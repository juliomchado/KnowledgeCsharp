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
            double porcentagem, Salario;


            Console.Write("Quantos empregados será registrados? ");
            QuantidadeEmpregados = int.Parse(Console.ReadLine());

            List<Empregado> lista = new List<Empregado>();

            for (int empregados = 1; empregados <= QuantidadeEmpregados; empregados++)
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

            Console.Write("Entre com o id para incrementar o salario: ");
            pesquisarId = int.Parse(Console.ReadLine());
            Empregado pesquisa = lista.Find(x => x.Id == pesquisarId);

            if (pesquisa != null)
            {
                Console.Write("Entre com a porcentagem: ");
                porcentagem = double.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Esse id não existe! ");
                Console.WriteLine();
            }


            
            Console.WriteLine("Lista atualizada: ");
            foreach (Empregado obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}