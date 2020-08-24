using System;
using System.Globalization;
using ExercicioComOrientadaaObjeto;

namespace ExercicioSemOrientadoaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double areax, areay;
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

            p = (xa + xb + xc) / 2;

            areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2;

            areay = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));


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