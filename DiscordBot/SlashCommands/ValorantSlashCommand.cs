using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;

internal class ValorantSlashCommand : ApplicationCommandModule
{
    [SlashCommand("gettiersgun", "shows all weapon tiers")]
    public async Task GetTierGun(InteractionContext interactionContext)
    {
       var selectTier = new DiscordEmbedBuilder
        {
            Title = "Select",
            Color = DiscordColor.CornflowerBlue,
        };
        await interactionContext.CreateResponseAsync(
           InteractionResponseType.ChannelMessageWithSource,
           new DiscordInteractionResponseBuilder().AddEmbed(selectTier));
        //await Log.LogPrint(interactionContext.User.Id.ToString());
        var deluxeTier = new DiscordEmbedBuilder
        {
            Title = "Deluxe",
            Color = DiscordColor.Aquamarine,
        };
        await interactionContext.Channel.SendMessageAsync(embed: deluxeTier);
        var premiumTier = new DiscordEmbedBuilder
        {
            Title = "Premium",
            Color = DiscordColor.HotPink,
        };
        await interactionContext.Channel.SendMessageAsync(embed: premiumTier);
        var ultraTier = new DiscordEmbedBuilder
        {
            Title = "Ultra",
            Color = DiscordColor.Yellow,
        };
        await interactionContext.Channel.SendMessageAsync(embed: ultraTier);
        var exclusiveTier = new DiscordEmbedBuilder
        {
            Title = "Exclusive",
            Color = DiscordColor.Orange,
        };
        await interactionContext.Channel.SendMessageAsync(embed: exclusiveTier);
    }
}
