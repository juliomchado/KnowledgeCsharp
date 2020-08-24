using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoException.Entities.Exception
{
    class LimitException : ApplicationException
    {
        public LimitException(string messege) : base(messege)
        {

        }
    }
}
