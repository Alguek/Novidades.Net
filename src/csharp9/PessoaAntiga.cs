using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9
{
    public class PessoaAntiga
    {
        public PessoaAntiga(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
    public class Teste
    {
        public Teste(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        protected string Nome { get; set; }
        protected string Sobrenome { get; set; }
    }

}
