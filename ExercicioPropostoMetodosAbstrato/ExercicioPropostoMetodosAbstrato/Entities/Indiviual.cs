using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPropostoMetodosAbstrato.Entities
{
    sealed class Indiviual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Indiviual(string name, double annualIncome, double healtExpenditures) : base(name, annualIncome)
        {
            HealtExpenditures = healtExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealtExpenditures * 0.5;
                
            }
            else
            {
                return AnnualIncome * 0.25 - HealtExpenditures * 0.5;
            }
        }
    }
}
