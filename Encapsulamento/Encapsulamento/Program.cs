using System;
using Encapsulamento; 

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.GetNome();
            p.SetNome("Agua");

            Console.WriteLine(p);
            

        }
    }
}
