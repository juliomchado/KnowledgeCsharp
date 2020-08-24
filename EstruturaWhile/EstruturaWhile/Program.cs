using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, segurar;
            Console.WriteLine("Digite o número: " );
            numero = int.Parse(Console.ReadLine());

            while(numero != 2002)
            {
                numero = 0;
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Escreva outro número: ");
                numero = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}
