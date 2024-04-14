/// <summary>
/// .net6
/// </summary>
namespace csharp10
{
    public class NullParameterChecking
    {
        void Antes(string message)
        {
            if (message is null)
                throw new ArgumentNullException(nameof(message));
            Console.WriteLine(message);
        }

        void Depois(string message)
        {
            ArgumentNullException.ThrowIfNull(message);
            Console.WriteLine(message);
        }
    }
}
