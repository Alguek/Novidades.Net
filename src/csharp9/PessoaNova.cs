using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9
{
    /// <summary>
    /// o "data" foi substituido pelo "record" nas versoes novas do c# e como o visual studio esta atualizado ele nao reconhece mais o "data"
    /// </summary>
    public record class PessoaNova
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }
        public int AnoNascimento { get; init; }
    }

    public record class PessoaNovaConstrucao(string Nome, string Sobrenome);
}
