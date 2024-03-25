using Discord;


public sealed class Log
{
    public static Task LogPrint(LogMessage message)
    {
        Console.WriteLine(message.ToString());
        return Task.CompletedTask;
    }
    public static Task LogPrint(string message)
    {
        Console.WriteLine(message);
        return Task.CompletedTask;
    }
}
