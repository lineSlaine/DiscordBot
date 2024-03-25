using DSharpPlus;
using Microsoft.Extensions.Configuration;


public sealed class BotLineEZ
{
    public DiscordClient client;
    public BotLineEZ(IConfiguration configuration)
    {
        var discordConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = configuration["BotSettings:Token"],
            TokenType = TokenType.Bot,
            AutoReconnect = true
        };
        new DiscordClient(discordConfig);
        client = new DiscordClient(discordConfig);
    }
    public async Task StartBot()
    {
        await client.ConnectAsync();
    }
    public async Task StopBot()
    {
        await client.DisconnectAsync();
    }
}
