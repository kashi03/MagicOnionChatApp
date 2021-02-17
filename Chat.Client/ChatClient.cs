using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Net.Client;
using MagicOnion.Client;
using Chat.Shared;
using System.Threading.Tasks;

namespace Chat.Client
{
    class ChatClient : IChatHubReceiver
    {
        IChatHub client;
        public ChatClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            this.client = StreamingHubClient.Connect<IChatHub, IChatHubReceiver>(channel, this);
        }
        public async void OnMessage(string message)
        {
            Console.WriteLine(message);
        }
        public async Task SendMessage()
        {
            string message = Console.ReadLine();
            await this.client.SendMessage(message);
        }
        public async Task JoinRoom()
        {
            await this.client.JoinRoom();
        }
    }
}
