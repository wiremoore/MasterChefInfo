﻿using MCI_Common.Communication;
using MCI_Common.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimulationKitchen.Model
{
    public class SocketCom
    {
        public Socket Cnx { get; set; }

        public Socket Handler { get; set; }

        public event EventHandler NewMenuDemand;

        public string IpAddress { get; set; }

        public int Port { get; set; }

        public string Datas { get; set; }

        /// <summary>
        /// Create a connection 
        /// </summary>
        public SocketCom(string server, int port)
        {
            this.IpAddress = server;
            this.Port = port;
        }

        public void StartListening()
        {
            new Thread(() =>
            {
                // Data buffer for incoming data.  
                byte[] bytes = new Byte[1024];

                // Establish the local endpoint for the socket.  
                // Dns.GetHostName returns the name of the   
                // host running the application.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse(this.IpAddress);
                Console.WriteLine(ipAddress.ToString());
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, this.Port);

                // Create a TCP/IP socket.  
                Socket listener = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Bind the socket to the local endpoint and   
                // listen for incoming connections.  
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(10);

                    // Start listening for connections.  
                    while (true)
                    {
                        LogWriter.GetInstance().Write("Kitchen Listenning on "+listener.LocalEndPoint.ToString()+", waiting for connection ...");
                        // Program is suspended while waiting for an incoming connection.  
                        this.Handler = listener.Accept();
                        this.OnNewMenuDemand(EventArgs.Empty);
                        // An incoming connection needs to be processed.  

                        while (true)
                        {
                            int bytesRec = this.Handler.Receive(bytes);
                            this.Datas += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            if (this.Datas.IndexOf("<EOF>") > -1)
                            {
                                this.ProcessRecieveData(this.Datas);
                                this.Datas = "";
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    LogWriter.GetInstance().Write(e.ToString());
                }
            }).Start();
        }

        private void ProcessRecieveData(string data)
        {
            data = data.Substring(0, data.Length - 5);
            if(data == "<END>")
            {
                this.Handler.Close();
            }
            else if (data == "<MENU>")
            {
                this.OnNewMenuDemand(EventArgs.Empty);
            }

            //Ingredient result = (Ingredient)Serialization.DeSerializeAnObject(data, typeof(Ingredient));
        }

        /// <summary>
        /// Send an object in the socket
        /// </summary>
        /// <param name="server"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public bool Send(string msg)
        {
            msg += "<EOF>";
            LogWriter.GetInstance().Write("Program send " + msg);
            // Get the socket connection
            using (this.Handler)
            {
                if (this.Handler == null)
                    return false;

                byte[] bytes = Encoding.ASCII.GetBytes(msg);

                // Send request to the server.
                this.Handler.Send(bytes);
            }
            return true;
        }

        protected virtual void OnNewMenuDemand(EventArgs e)
        {
            NewMenuDemand?.Invoke(this, e);
        }
    }
}
