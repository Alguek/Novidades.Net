using Conta = (string, int);

namespace csharp12
{
    public class UsingAliasesForAnyType
    {
        public UsingAliasesForAnyType()
        {
            var conta = new Conta("Mateus", 0);
            //conta.Item1;
            var (nome, valor) = conta;
            Console.WriteLine($"{nome}, {valor}");
        }
    }
}
