using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacaoOrientacaoaObjeto
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nPerímetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nDiagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture); 
            
        }
    }
}
