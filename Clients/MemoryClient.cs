/*
 * MemoryClient
 *
 * Represents the memory of the VM on the master node's side.
 *
 */

namespace  HypeVM.Master.Clients.Memory
{
    public sealed class MemoryClient
    {

        //IP address of the memory server
        private string memoryServerIP;

        //Port (TCP) of the memory server
        private int port;

        //Construct a new MemoryClient
        public MemoryClient(string memoryServerIP, int port)
        {
            //Set the parameters of the MemoryClient
            this.memoryServerIP = memoryServerIP;
            this.port = port;

            //Output some debugging information
            Console.Out.WriteLine("[MemoryClient] New MemoryClient created with parameters <"+memoryServerIP+":"+port+">");
        }
    }
}
