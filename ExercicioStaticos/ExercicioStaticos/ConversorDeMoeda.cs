using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioStaticos
{
    class ConversorDeMoeda
    {
        static public double iof = 6.0;

        static public double RealParaDolar(double quantia, double quantidade)
        {
            double total = quantia * quantidade;
            return total + total * (iof / 100);
        }
    }
}
