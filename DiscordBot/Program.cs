using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace DiscordBot
{
    internal class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();
        BotLineEZ bot;
        IConfiguration configuration;
        
        private async Task MainAsync()
        {
            try
            {
                configuration = new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appsettings.json")).Build();
            }
            catch(Exception ex)
            {
                await Log.LogPrint("The configuration file is missing\n" + ex);
                ProgramClose();
            }

            try
            {
                bot = new BotLineEZ(configuration);
                await bot.LoginBot();
                await bot.StartBot();
            }
            catch (Exception ex)
            {
                await Log.LogPrint("Token is Null\n" + ex);
                ProgramClose();
            }
            


            Console.ReadLine();
        }

        void ProgramClose()
        {
            Environment.Exit(0);
        }

    }
}
