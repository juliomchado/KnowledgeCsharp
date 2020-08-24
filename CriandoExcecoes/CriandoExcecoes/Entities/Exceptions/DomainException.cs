using System;
using System.Collections.Generic;
using System.Text;

namespace CriandoExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string messege) : base(messege)
        {

        }
    }
}
