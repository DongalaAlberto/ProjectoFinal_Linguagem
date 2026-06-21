using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleicoesEstudantis.Models
{
       public class Eleitor : Pessoa
       {
           private string matricula;
           private bool votou;

           public string Matricula
           {
               get { return matricula; }
               set { matricula = value; }
           }

           public bool Votou
           {
               get { return votou; }
               set { votou = value; }
           }

           public override string ExibirDados()
           {
               return Nome + " - " + Matricula;
           }
       }
}
