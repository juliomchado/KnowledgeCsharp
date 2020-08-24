using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPropostoMetodosAbstrato.Entities
{
    sealed class Company : TaxPayer
    {
        public int NumberOfEmplooyes { get; set; }

        public Company(string name, double annualIncome, int numberOfEmplooyes) :base(name, annualIncome)
        {
            NumberOfEmplooyes = numberOfEmplooyes;
        }

        public override double Tax()
        {
            if (NumberOfEmplooyes > 10)
                return AnnualIncome * 0.14;
            else
                return AnnualIncome * 0.16;
        }
    }
}
