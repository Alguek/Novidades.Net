using csharp9.Init_only_properties;

namespace Csharp9_Tests
{
    /// <summary>
    /// net.5
    /// </summary>
    public class Teste
    {
        [Fact]
        public void InicializarPessoaAntes()
        {
            //Error
            //var pessoaAntes = new PessoaAntes();
            var pessoaAntes = new PessoaAntiga("Jonh", "Cena");

            Assert.Equal("Jonh", pessoaAntes.Nome);
            Assert.Equal("Cena", pessoaAntes.Sobrenome);
        }

        [Fact]
        public void InicializarPessoaDepois()
        {
            var pessoaDepois = new PessoaNova()
            {
                Nome = "Jonh",
                Sobrenome = "Cena"
            };

            //Error
            //pessoaAntes.Sobrenome = "Sena";

            Assert.Equal("Jonh", pessoaDepois.Nome);
            Assert.Equal("Cena", pessoaDepois.Sobrenome);
        }

        #region
        /// <summary>
        /// Podemos iniciar uma instancia agora só com o new.
        /// Mas, é necessario falar qual o tipo antes.
        /// </summary>
        #endregion
        [Fact]
        public void InicializarPessoaDepoisNew()
        {
            PessoaNova pessoaDepois = new()
            {
                Nome = "Jonh",
                Sobrenome = "Cena"
            };

            Assert.Equal("Jonh", pessoaDepois.Nome);
            Assert.Equal("Cena", pessoaDepois.Sobrenome);
        }

        #region
        /// <summary>
        /// Podemos iniciar uma instancia com with onde só os valores passados no with seram diferentes.
        /// </summary>
        #endregion
        [Fact]
        public void InicializarPessoaDepoisWith()
        {
            PessoaNova pessoaDepois1 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            var pessoaDepois2 = pessoaDepois1 with { Nome = "Luciano", Sobrenome = "Hulk" };

            Assert.NotEqual(pessoaDepois1.Nome, pessoaDepois2.Nome);
            Assert.NotEqual(pessoaDepois1.Sobrenome, pessoaDepois2.Sobrenome);
            Assert.Equal(pessoaDepois1.AnoNascimento, pessoaDepois2.AnoNascimento);
        }

        #region
        /// <summary>
        /// Aqui o Equals compara a instancia do objeto
        /// Por mais que as propriedades tenham os mesmos valores, o equals retorna falso
        /// </summary>
        #endregion
        [Fact]
        public void DuasInstanciasComMesmoValorSemRecordDeveRetornarFalso()
        {
            PessoaAntiga pessoaAntes1 = new("Jared", "Leto");

            PessoaAntiga pessoaAntes2 = new("Jared", "Leto");

            Assert.False(pessoaAntes1.Equals(pessoaAntes2));
        }

        #region
        /// <summary>
        /// Aqui o Equals compara não a instancia do objeto e sim as propriedades
        /// </summary>
        #endregion
        [Fact]
        public void DuasInstanciasComMesmoValorComRecordDeveRetornarVerdadeiro()
        {
            PessoaNova pessoaDepois1 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            PessoaNova pessoaDepois2 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            Assert.True(pessoaDepois1.Equals(pessoaDepois2));
        }

        [Fact]
        public void EqualsPessoaDepoisRecord2()
        {
            PessoaNova pessoaDepois1 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            PessoaNova pessoaDepois2 = new()
            {
                Nome = "Luciano",
                Sobrenome = "Hulk",
                AnoNascimento = 1971
            };

            Assert.False(pessoaDepois1.Equals(pessoaDepois2));
        }

        [Fact]
        public void InicializarPessoaDepois2_positionalRecord()
        {
            PessoaNovaConstrucao pessoaDepois2 = new("Jared", "Leto"); // positional construction
            var (nome, sobrenome) = pessoaDepois2;              // positional deconstruction

            Assert.Equal("Jared", pessoaDepois2.Nome);
            Assert.Equal("Leto", pessoaDepois2.Sobrenome);

            Assert.Equal("Jared", nome);
            Assert.Equal("Leto", sobrenome);
        }

        #region
        //Podemos ao invez de utilizar ! is null podemos utilizar o is not null
        #endregion
        [Fact]
        public void IsNot()
        {
            PessoaNova pessoaDepois = new();

            // Antes
            if (!(pessoaDepois is null))
            {
                Console.WriteLine("Objeto Válido");
            }

            // Depois
            if (pessoaDepois is not null)
            {
                Console.WriteLine("Objeto Válido");
            }

        }

        #region
        //Temos a Possibildiade de usar operadores lógicos (NOT, AND, OR) e operadores relacionais (<, >, >=, <=, ==) no switch
        #endregion
        [Fact]
        public void RelationalPatterns()
        {
            var nota = 10;
            var resultado = nota switch
            {
                < 5 => "quase",

                <= 6 => "media",

                <= 9 => "muito bom",

                10 => "Exelente",

                _ => throw new ArgumentException("Nota inválida!")
            };

            Assert.Equal("Exelente", resultado);
        }
    }
}