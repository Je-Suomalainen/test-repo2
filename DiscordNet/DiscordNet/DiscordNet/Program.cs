using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordNet
{
    class Program
    {
        public DiscordSocketClient Client;
        public CommandHandler Handler;
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            new Program().Start().GetAwaiter().GetResult();
        }

        public async Task Start()
        {
            Client = new DiscordSocketClient();
            Handler = new CommandHandler();

            await Client.LoginAsync(Discord.TokenType.Bot, "NjQ2Njc5MjU3ODE2NDk4MTg2.XdUpkQ.zo6xgiRotRdstunYMkhin4mIco8");

            await Client.StartAsync();

            await Handler.Install(Client);

            Client.Ready += Client_Ready;

            await Task.Delay(-1);

        }
        private async Task  Client_Ready()
        {
            Console.WriteLine("***JESBot is online!***");
            
            
            return;

    }
}}
