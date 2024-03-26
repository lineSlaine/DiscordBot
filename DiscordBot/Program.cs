using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using Microsoft.Extensions.Configuration;

namespace DiscordBot
{
    internal class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();
        private BotLineEZ bot;
        private IConfiguration configuration;
        private static CommandsNextExtension commands;
        
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
                await ProgramClose();
            }
            try
            {
                bot = new BotLineEZ(configuration);



                var commandConfig = new CommandsNextConfiguration()
                {
                    StringPrefixes = [configuration["BotSettings:Prefix"]],
                    EnableMentionPrefix = true,
                    EnableDms = true,
                    EnableDefaultHelp = false
                };
                commands = bot.GetClient().UseCommandsNext(commandConfig);
                commands.RegisterCommands<TestCommand>();
                var slashCommandsConfig = bot.GetClient().UseSlashCommands();
                slashCommandsConfig.RegisterCommands<TestShashCommand>();


                await bot.StartBot();
            }
            catch (Exception ex)
            {
                await Log.LogPrint("the configuration file is broken!\n" + ex);
                await ProgramClose();
            }


            await Task.Delay(-1);
        }
        async Task ProgramClose()
        {
            await bot.StopBot();
            Environment.Exit(0);
        }

    }
}
