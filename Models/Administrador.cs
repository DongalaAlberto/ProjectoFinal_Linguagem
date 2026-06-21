using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
    public class Administrador : Pessoa
    {
        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public override string ExibirDados()
        {
            return Nome + " - " + Cargo;
        }
    }
}
