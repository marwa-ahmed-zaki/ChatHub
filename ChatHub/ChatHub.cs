﻿using Microsoft.AspNetCore.SignalR;

namespace ChatHub
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("SendMessage", user, message);
        }
    }
}
