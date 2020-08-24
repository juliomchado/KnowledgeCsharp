using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Entities
{
    class Contratos
    {
        public int Numeros { get; set; }
        public DateTime Date { get; set; }
        public double ValorTotal  { get; set; }
        public List<Prestacao> Prestacao { get; set; }

        public Contratos(int numeros, DateTime date, double valorTotal)
        {
            Numeros = numeros;
            Date = date;
            ValorTotal = valorTotal;
            Prestacao = new List<Prestacao>();
        }

        public void AddPrestacao(Prestacao prestacao)
        {
            Prestacao.Add(prestacao);
        }

        public void RemovePrestacao(Prestacao prestacao)
        {
            Prestacao.Remove(prestacao);
        }



    }
}
