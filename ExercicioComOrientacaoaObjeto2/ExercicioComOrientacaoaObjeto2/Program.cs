using System;
using System.Globalization;
using ExercicioComOrientacaoaObjeto2;

namespace ExercicioSemOrientadoaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double areax, areay, p;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();



            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areax = x.Area();
            areay = y.Area();


            Console.WriteLine($"Area de X: {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de X: {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay)
            {
                Console.WriteLine("Maior area é do triângulo X");
            }
            else if (areax == areay)
            {
                Console.WriteLine("Os 2 tem a mesma área ");
            }
            else
            {
                Console.WriteLine("Maior area é do triângulo Y ");
            }
        }
    }
}
