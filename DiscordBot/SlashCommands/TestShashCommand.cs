using DSharpPlus.SlashCommands;
using DSharpPlus.Entities;
using DSharpPlus;

public sealed class TestShashCommand : ApplicationCommandModule
{
    [SlashCommand("Hello", "The bot will reply hello to you")]
    public async Task HelloAsync(InteractionContext interactionContext, [Option("option","anything")] string option)
    {
        await interactionContext.CreateResponseAsync(
            InteractionResponseType.ChannelMessageWithSource,
            new DiscordInteractionResponseBuilder().WithContent($"Hello, {interactionContext.User.Username}! {option}")
            );
    }
}
