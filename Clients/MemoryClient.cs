/*
 * MemoryClient
 *
 * Represents the memory of the VM on the master node's side.
 *
 */

namespace  HypeVM.Master.Clients.Memory
{

    //Represents the connection to the slave MemoryServer node
    public sealed class MemoryClient
    {

        //IP address of the memory server
        private string memoryServerIP;

        //Port (TCP) of the memory server
        private int port;

        //The Socket connection to the memory server
        private Socket socket;

        //Construct a new MemoryClient
        public MemoryClient(string memoryServerIP, int port)
        {
            //Set the parameters of the MemoryClient
            this.memoryServerIP = memoryServerIP;
            this.port = port;

            //Output some debugging information
            Console.Out.WriteLine("[MemoryClient] New MemoryClient created with parameters <"+memoryServerIP+":"+port+">");
        }

        //Connect to the memory server
        //TODO: Figure out how to implement this

    }
}
