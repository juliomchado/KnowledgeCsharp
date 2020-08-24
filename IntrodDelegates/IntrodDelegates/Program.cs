using System;
using IntrodDelegates.Services;

namespace IntrodDelegates
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            
            BinaryNumericOperation op = CalculationService.Sum;
            

            //Sintaxe Alternativa

            /*
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            */

            /*
             * double result = op.Invoke(a, b);
            */
            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
