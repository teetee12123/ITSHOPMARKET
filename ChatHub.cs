using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace OnlineShop
{
    public class ChatHub : Hub
    {
        public void BroadCastMessage()
        {
            Clients.All.Message(DateTime.Now);
        }
        public void MessageGET(string name,string message)
        {
            Clients.All.MessageSend(name, message);
        }
    }
}