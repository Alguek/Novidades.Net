using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp09
{
    public class Antes
    {
        public Antes(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    /// <summary>
    /// o "data" foi substituido pelo "record" nas versoes novas do c# e como o visual studio esta atualizado ele nao reconhece mais o "data"
    /// </summary>
    public record class Depois
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }
        public int AnoNascimento { get; init; }
    }

    public record class Depois2(string Nome, string Sobrenome, int AnoNascimento);
}
