
public sealed class Log
{
    public static Task LogPrint(string message)
    {
        Console.WriteLine(message);
        return Task.CompletedTask;
    }
}
