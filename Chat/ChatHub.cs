using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicOnion.Server.Hubs;
using Chat.Shared;

namespace Chat
{
    public class ChatHub : StreamingHubBase<IChatHub, IChatHubReceiver>, IChatHub
    {
        IGroup room;
        public async Task JoinRoom()
        {
            room = await Group.AddAsync("test_group");
        }
        public async Task SendMessage(string message)
        {
            Broadcast(room).OnMessage(message);
        }
    }
}
