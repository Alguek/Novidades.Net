using csharp09;

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
            var pessoaAntes = new Antes("Jonh", "Cena");

            Assert.Equal("Jonh", pessoaAntes.Nome);
            Assert.Equal("Cena", pessoaAntes.Sobrenome);
        }

        [Fact]
        public void InicializarPessoaDepois()
        {
            var pessoaDepois = new Depois()
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
            Depois pessoaDepois = new()
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
            Depois pessoaDepois1 = new()
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
            Antes pessoaAntes1 = new("Jared", "Leto");

            Antes pessoaAntes2 = new("Jared", "Leto");

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
            Depois pessoaDepois1 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            Depois pessoaDepois2 = new()
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
            Depois pessoaDepois1 = new()
            {
                Nome = "Jared",
                Sobrenome = "Leto",
                AnoNascimento = 1971
            };

            Depois pessoaDepois2 = new()
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
            Depois2 pessoaDepois2 = new("Jared", "Leto", 1204); // positional construction
            var (nome, sobrenome, idade) = pessoaDepois2;       // positional deconstruction

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
            Depois pessoaDepois = new();

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