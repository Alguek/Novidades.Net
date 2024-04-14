/// <summary>
/// .net6
/// </summary>
class Program
{
    static void Main()
    {
        var statusCode200 = HttpStatusCode.OK;
        var names = new[] { "Prasad", "Praveen", statusCode200.ToString() };
        var serialized = JsonSerializer.Serialize(names);
        Console.WriteLine(serialized);
    }
}