using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
        public abstract class Pessoa
        {
            private int id;
            private string nome;
            private string email;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public abstract string ExibirDados();
        }
}
