namespace csharp11
{
    /// <summary>
    /// Possibilidade de criar Patterns para validação de uma lista.
    /// Aplicando as logicas nacessarias
    /// </summary>
    public class ListPatterns
    {
        public ListPatterns()
        {
            int[] numbers = { 1, 2, 3 };

            var pattern1 = numbers is [1, 2, 3];
            var pattern2 = numbers is [1, 2];
            var pattern3 = numbers is [1, 2, _];
            var pattern4 = numbers is [1, 2, > 2];
            var pattern5 = numbers is [0 or 1, <= 2, > 3];

            Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, 3]: {pattern1}");
            Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2]: {pattern2}");
            Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, _]: {pattern3}");
            Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, >2]: {pattern4}");
            Console.WriteLine($"[{string.Join(',', numbers)}] is [0 or 1, <= 2, > 3]: {pattern5}");
        }
    }
}
