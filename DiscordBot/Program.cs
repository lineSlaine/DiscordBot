using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using Microsoft.Extensions.Configuration;

namespace DiscordBot
{
    internal class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();
        private BotLineEZ? bot;
        private IConfiguration? configuration;
        
        private async Task MainAsync()
        {
            try
            {
                configuration = new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appsettings.json")).Build();
            }
            catch(Exception ex)
            {
                await Log.LogPrint("The configuration file is missing!\n" + ex);
                ProgramClose();
            }
            try
            {
                bot = new BotLineEZ(configuration);

                var slashCommandsConfig = bot.GetClient().UseSlashCommands();
                slashCommandsConfig.RegisterCommands<TestShashCommand>();
                slashCommandsConfig.RegisterCommands<ValorantSlashCommand>();

                await bot.StartBot();
            }
            catch (Exception ex)
            {
                await Log.LogPrint("the configuration file is broken!\n" + ex);
                if (bot != null) await bot.StopBot(); 
                ProgramClose();
            }

            await Task.Delay(-1);
        }
        public void ProgramClose()
        {
            Environment.Exit(0);
        }

    }
}
