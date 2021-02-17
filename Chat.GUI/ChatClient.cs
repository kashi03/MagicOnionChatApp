using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Net.Client;
using MagicOnion.Client;
using Chat.Shared;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Client
{
    class ChatClient : IChatHubReceiver
    {
        IChatHub client;
        RichTextBox textBox;
        public ChatClient(RichTextBox textBox)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            this.client = StreamingHubClient.Connect<IChatHub, IChatHubReceiver>(channel, this);
            this.textBox = textBox;
        }
        public async void OnMessage(string message)
        {
            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(">>>"+message);
            textBox.Text += message + "\n";
        }
        public async Task SendMessage(string message)
        {
            await this.client.SendMessage(message);
        }
        public async Task JoinRoom()
        {
            await this.client.JoinRoom();
        }
    }
}
