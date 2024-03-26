using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;


public sealed class TestCommand : BaseCommandModule
{
    //[Command("Hello")]
    //public async Task HelloAsync(CommandContext commandContext)
    //{

    //    await commandContext.Channel.SendMessageAsync($"Hello, {commandContext.User.Username}");
    //}

    [Command ("myguns")]
    public async Task MyGuns(CommandContext commandContext)
    {
        var firstGunEmber = new DiscordEmbedBuilder
        {
            Title = "First Gun",
            Description = "Cost",
            Color = DiscordColor.CornflowerBlue,
        };
        await commandContext.Channel.SendMessageAsync(embed: firstGunEmber);
        var secondGunEmber = new DiscordEmbedBuilder
        {
            Title = "Second Gun",
            Description = "Cost",
            Color = DiscordColor.Aquamarine,
        };
        await commandContext.Channel.SendMessageAsync(embed: secondGunEmber);
        var thirdGunEmber = new DiscordEmbedBuilder
        {
            Title = "Third Gun",
            Description = "Cost",
            Color = DiscordColor.HotPink,
        };
        await commandContext.Channel.SendMessageAsync(embed: thirdGunEmber);
        var fourthGunEmber = new DiscordEmbedBuilder
        {
            Title = "Fourth Gun",
            Description = "Cost",
            Color = DiscordColor.Yellow,
        };
        await commandContext.Channel.SendMessageAsync(embed: fourthGunEmber);
        var fifthGunEmber = new DiscordEmbedBuilder
        {
            Title = "Fifth Gun",
            Description = "Cost",
            Color = DiscordColor.Orange,
        };
        await commandContext.Channel.SendMessageAsync(embed: fifthGunEmber);
    }
}
