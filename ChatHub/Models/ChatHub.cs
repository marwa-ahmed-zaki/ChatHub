using Microsoft.AspNetCore.SignalR;

namespace ChatHub
{
    public class ChatHubClass:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
