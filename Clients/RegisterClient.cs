/*
 * RegisterClient
 *
 * Represents the registers of the VM on the master node's side.
 *
 */

namespace HypeVM.Master.Clients.Register
{

    using System.Net.Sockets;
    using System.Threading;
    using System;

    //Represents the connection to the slave RegisterServer node
    public sealed class RegisterClient
    {

        //IP address of the register server
        private string registerServerIP;

        //Port (TCP) of the register server
        private int port;

        //The Socket connection to the register server
        private Socket socket;

        //Construct a new MemoryClient
        public RegisterClient(string registerServerIP, int port)
        {
            //Set the parameters of the RegisterClient
            this.registerServerIP = registerServerIP;
            this.port = port;

            //Output some debugging information
            Console.Out.WriteLine("[RegiserClient] New RegiserClient created with parameters <"+registerServerIP+":"+port+">");
        }

        //Connect to the register server and begin
        //TODO: Figure out how to implement this
        public void start()
        {
            //Output some information
            Console.Out.WriteLine("[RegisterClient] Configuring and starting thread for RegisterClient...");

            //TODO: Add stuff to setup stuff here

            //TODO: Begin the thread now with everything setup with the given delegate function `run`
            Thread thread = new Thread(run);
            thread.Start();

            Console.Out.WriteLine("[RegisterClient] Configured and thread started.");
        }

        //The code to be run by the thread
        private void run()
        {
            Console.Out.WriteLine("[RegisterClient] Beginning of thread");
        }

    }
}
