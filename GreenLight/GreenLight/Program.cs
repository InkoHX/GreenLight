using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace GreenLight
{
    class Program
    {
        private DiscordSocketClient client;

        static void Main(string[] args)
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        public async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.Log += LogAsync;
            client.Ready += ReadyAsync;
            string token = "Token";
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();
            await Task.Delay(-1);
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            return Task.CompletedTask;
        }
    }
}
