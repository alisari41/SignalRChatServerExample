using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRChatServerExample.Models;

namespace SignalRChatServerExample.Data
{
    public static class GroupSource
    {//inmemory de tutabilmek için
        public static List<Group> Groups { get; } = new List<Group>();
    }
}
