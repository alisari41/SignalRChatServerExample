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

        public async Task SendMessageAsync(string message, string clientName)
        { //Clientlara mesaj göndericez

            clientName = clientName.Trim();//Hem sağındaki hemde solunda boşlukları temizler
            Client senderClient = ClientSource.Clients.FirstOrDefault(c => c.ConnectionId == Context.ConnectionId);
            if (clientName == "Tümü")
            {//Eğer "tümü" seceneğiniz seçtiyse herkese iletmek gerekir
                await Clients.Others.SendAsync("receiveMessage", message, senderClient.NickName);
            }
            else
            {
                Client client = ClientSource.Clients.FirstOrDefault(c => c.NickName == clientName);
                await Clients.Client(client.ConnectionId).SendAsync("receiveMessage", message, senderClient.NickName);
            }

        }

        public async Task AddGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName); //Grubu oluşturan client gruba eklensin
            GroupSource.Groups.Add(new Group{GroupName = groupName});

            await Clients.All.SendAsync("groups", GroupSource.Groups);


        }
    }
}
