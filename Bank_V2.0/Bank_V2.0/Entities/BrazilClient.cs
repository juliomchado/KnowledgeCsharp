using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Entities
{
    class BrazilClient
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Balance { get; set; }

        public DateTime Date { get; set; }
        public BrazilClient()
        {
        }

        public BrazilClient(string name, string cpf, double balance, DateTime date)
        {
            Name = name;
            Cpf = cpf;
            Balance = balance;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Name};{Cpf};{Balance.ToString("F2")};{Date}";
        }
    }
}
