using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioLista
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100.00;
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
