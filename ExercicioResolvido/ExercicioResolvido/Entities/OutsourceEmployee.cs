using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    sealed class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        OutsourceEmployee()
        {
        }

        public OutsourceEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
