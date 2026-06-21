using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
    public class Candidatura
    {
        public int Id { get; set; }

        public string NomeLista { get; set; }

        public bool DocumentoValido { get; set; }

        public int EleicaoId { get; set; }
    }
}
