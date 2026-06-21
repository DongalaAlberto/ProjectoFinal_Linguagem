using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Exceptions
{
    public class VotoDuplicadoException : Exception
    {
        public VotoDuplicadoException()
            : base("O Eleitor já votou.")
        {
        }
    }
}
