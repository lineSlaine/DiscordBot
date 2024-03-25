using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

internal class TestCommand : BaseCommandModule
{
    [Command("Hello")]
    public async Task HelloAsync(CommandContext commandContext)
    {
        
        await commandContext.Channel.SendMessageAsync($"Hello, {commandContext.User.Username}");
    }
}
