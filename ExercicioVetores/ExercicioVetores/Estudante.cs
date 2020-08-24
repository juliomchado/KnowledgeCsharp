using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores
{
    class Estudante
    {
        private string Nome { get; set; }
        private string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
