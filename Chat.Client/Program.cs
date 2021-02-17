using System;
using System.Threading.Tasks;
using Chat.Client;


namespace Chat.Client
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new ChatClient();
            await client.JoinRoom();
            while (true)
            {
                await client.SendMessage();
            }
        }
    }
}
