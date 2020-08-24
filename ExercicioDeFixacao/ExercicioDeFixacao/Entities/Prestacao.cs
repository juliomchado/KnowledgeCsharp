using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioDeFixacao.Entities
{
    class Prestacao
    {
        
        public DateTime Date { get; set; }
        public double Quantia { get; set; }

        public Prestacao(DateTime date, double quantia)
        {
            Date = date;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return $"{Date.ToString("dd/MM/yyyy")} - {Quantia.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
