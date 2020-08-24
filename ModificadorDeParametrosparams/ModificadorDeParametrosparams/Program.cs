using System;

namespace ModificadorDeParametrosparams
{
    class Program
    {
        static void Main(string[] args)
        {
            int sla = int.Parse(Console.ReadLine());
            int sla2 = int.Parse(Console.ReadLine());
            int s1 = Calculator.Soma(sla, sla2);
            int s2 = Calculator.Soma(sla2, sla, sla);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
