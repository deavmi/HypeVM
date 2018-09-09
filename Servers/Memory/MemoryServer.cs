/*
 * MemoryServer
 *
 * This module is used if this HypeVM instance is being used as a slave node for holding memory.
 *
 */

 namespace HypeVM.Slave.Servers.Memory
 {

    using System;
    using System.Net.Sockets;
    using System.Net;

    //Creates a new MemoryServer bound to the given IP Address and Port (TCP)
    public class MemoryServer
    {

        //The internal Memory of this MemoryServer use for the master node
        private Memory memory;

        //The ipAddress to bind to for this MemoryServer
        private string ipAddress;

        //The port (TCP) to bind to for this MemoryServer
        private int port;

        public MemoryServer(string ipAddress, int port)
        {  
            //Output information
            Console.Out.WriteLine("[MemoryServer] New memory server created");

            //Set the ipAddress and port of this MemoryServer
            this.ipAddress = ipAddress;
            this.port = port;
        }

        //Start the MemoryServer
        public void run()
        {
            //Output information
            Console.Out.WriteLine("[MemoryServer] Starting memory server on " + ipAddress + " on port " + port + " ...");

            //Listen on the ipAddress and port
            EndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress),port);

            //Create a new Socket to listen for incoming connections on
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Bind the  Socket to the address ipAddress and port port
            serverSocket.Bind(endPoint);

            //TODO: fix me
            serverSocket.Listen(0);

            //Now accept a connection from the master node
            Socket clientSocket = serverSocket.Accept();

            //Enter the read/write socket loop
            loop();
        }

        //The read/write sockect loop
        private void loop()
        {
            //Now do a loop
            while(true)
            {
                
            }
        }
    }

 }