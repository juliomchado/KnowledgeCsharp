using System;
using System.Globalization;

namespace ExercicioSemOrientadoaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa, xb, xc, ya, yb, yc, p, areax, areay;
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (xa + xb + xc) / 2;

            areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2;

            areay = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));


            Console.WriteLine($"Area de X: {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de X: {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areax > areay)
            {
                Console.WriteLine("Maior area é do triângulo X");
            }
            else if(areax == areay)
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
