using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Exceptions
{
    public class EleitorInelegivelException : Exception
    {
        public EleitorInelegivelException()
            : base("Eleitor não elegível.")
        {
        }
    }
}
