using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChatServerExample.Models
{
    public class Group
    {
        public string GroupName { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>(); //Bu gruplara dahil olan tüm clientları tutmak için
    }
}
