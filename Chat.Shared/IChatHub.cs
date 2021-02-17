using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicOnion;

namespace Chat.Shared
{
    public interface IChatHubReceiver
    {
        void OnMessage(string message);
    }
    public interface IChatHub : IStreamingHub<IChatHub, IChatHubReceiver>
    {
        Task JoinRoom();
        Task SendMessage(string message);
    }
}
