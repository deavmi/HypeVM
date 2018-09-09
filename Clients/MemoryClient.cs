/*
 * MemoryClient
 *
 * Represents the memory of the VM on the master node's side.
 *
 */

namespace  HypeVM.Master.Clients.Memory
{

    using System.Net.Sockets;
    using System.Threading;
    using System;
    using System.Net;
    using Utils;

    //Represents the connection to the slave MemoryServer node
    public sealed class MemoryClient
    {

        //IP address of the memory server
        private string memoryServerIP;

        //Port (TCP) of the memory server
        private int port;

        //The size of the VM's memory
        private short memorySize;

        //The Socket connection to the memory server
        private Socket socket;

        //Construct a new MemoryClient
        public MemoryClient(string memoryServerIP, int port, short memorySize)
        {
            //Set the parameters of the MemoryClient
            this.memoryServerIP = memoryServerIP;
            this.port = port;
            this.memorySize = memorySize;

            //Output some debugging information
            Console.Out.WriteLine("[MemoryClient] New MemoryClient created with parameters <"+memoryServerIP+":"+port+">");
        }

        //Connect to the memory server and begin
        //TODO: Figure out how to implement this
        public void start()
        {
            //Output some information
            Console.Out.WriteLine("[MemoryClient] Configuring and starting thread for MemoryClient...");

            //TODO: Add stuff to setup stuff here

            //TODO: Begin the thread now with everything setup with the given delegate function `run`
            Thread thread = new Thread(run);
            thread.Start();

            Console.Out.WriteLine("[MemoryClient] Configured and thread started.");
        }

        //The code to be run by the thread
        private void run()
        {
            Console.Out.WriteLine("[MemoryClient] Beginning of thread");

            //The ipAddress and port (TCP ) we are connecting to
            EndPoint endPoint = new IPEndPoint(IPAddress.Parse(memoryServerIP),port);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Connect to the the given memoryServerIP and port
            socket.Connect(endPoint);

            //TODO: from here now

            //Now send accross the parameters
            string memorySizeString = "" + memorySize + "\n"; 
            byte[] encodedASCIIMessage = Utils.encodeASCII(memorySizeString);
            socket.Send(encodedASCIIMessage); //TODO: continue work here, UTF 16 is compatible with ASCII it has be as I said, lol

            loop();
        }

        private void loop()
        {
            while(true)
            {

            }
        }

    }
}
