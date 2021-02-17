using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Shared
{
    public interface IPlayerHubReceiver
    {
        void OnPlayerJoined(int id);
        void OnPlayerLeaved(int id);
    }
}
