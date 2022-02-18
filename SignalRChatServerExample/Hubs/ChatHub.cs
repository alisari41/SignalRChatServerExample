using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRChatServerExample.Data;
using SignalRChatServerExample.Models;

namespace SignalRChatServerExample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task GetNickName(string nickName)
        {
            Client client = new Client
            {
                ConnectionId = Context.ConnectionId,
                NickName = nickName
            };
            ClientSource.Clients.Add(client);//Clientlarımı depoluyorum
            await Clients.Others.SendAsync("clientJoined", nickName);
            await Clients.All.SendAsync("clients", ClientSource.Clients);//Giriş yapan clientları bir listede tutmak için
        }
    }
}
