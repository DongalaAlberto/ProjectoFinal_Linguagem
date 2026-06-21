using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
    public class Voto
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public int EleitorId { get; set; }

        public int CandidaturaId { get; set; }
    }
}
