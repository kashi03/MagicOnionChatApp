using System;
using System.Collections.Generic;
using System.Text;
using Chat.Shared;
using MagicOnion;

namespace Chat.Shared
{
    public interface IPlayerHub : IStreamingHub<IPlayerHub, IPlayerHubReceiver>
    {
    }
}
