﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRDemo
{
    public class ChatHub: Hub
    {
        public Task SendMessage(string user, string message)
        {
            string timestamp = DateTime.Now.ToShortTimeString();
            return Clients.All.SendAsync("ReceiveMessage", timestamp, user, message);
        }
    }
}
