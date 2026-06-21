using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
    public class Eleicao
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public string Estado { get; set; }

        public bool Publicada { get; set; }
    }
}
