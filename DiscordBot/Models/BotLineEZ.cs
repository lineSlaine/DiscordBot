using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;


public sealed class BotLineEZ
{
    string _token;
    DiscordSocketClient client;
    IConfiguration configuration;
    public BotLineEZ(IConfiguration appConfig)
    {
        client = new DiscordSocketClient();
        client.Log += Log.LogPrint;
        configuration = appConfig;
        _token = configuration["BotSettings:Token"];
    }
    public async Task StartBot()
    {
        await client.StartAsync();
    }
    public async Task StopBot()
    {
        await client.StopAsync();
    }
    public async Task LoginBot()
    {
        await client.LoginAsync(TokenType.Bot, _token);
    }
    public async Task LogoutBot()
    {
        await client.LogoutAsync();
    }
}
