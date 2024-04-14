namespace csharp10
{
    /// <summary>
    /// .net6
    /// </summary>
    public class LambdaImprovements
    {
        /// <summary>
        /// Antes você tinha que falar o tipo de uma Func para poder cria-la
        /// </summary>
        public void Antes()
        {
            Func<string> welcome = () => "Welcome to Lambda Improvements";
            Console.WriteLine(welcome);
        }

        /// <summary>
        /// Agora você pode criar o tipo var sem declarar o tipo.
        /// </summary>
        public void Depois()
        {
            var welcome = () => "Welcome to Lambda Improvements";
            Console.WriteLine(welcome);
        }
    }
}