using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioBancoDia2910;


namespace ExercicioBancoDia2910
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu FuncoesMenu = new Menu();
            Console.Write(FuncoesMenu.MensagensMenu());

            int Resposta = int.Parse(Console.ReadLine());
            FuncoesMenu.Opcoes(Resposta);

            Console.ReadKey();
        }

    }
}
