/*
 * RegisterClient
 *
 * Represents the registers of the VM on the master node's side.
 *
 */

namespace  HypeVM.Master.Clients.Register
{

    //Represents the connection to the slave RegisterServer node
    public sealed class RegiserClient
    {

        //IP address of the register server
        private string registerServerIP;

        //Port (TCP) of the register server
        private int port;

        //The Socket connection to the register server
        private Socket socket;

        //Construct a new MemoryClient
        public RegiserClient(string registerServerIP, int port)
        {
            //Set the parameters of the RegisterClient
            this.registerServerIP = registerServerIP;
            this.port = port;

            //Output some debugging information
            Console.Out.WriteLine("[RegiserClient] New RegiserClient created with parameters <"+registerServerIP+":"+port+">");
        }

        //Connect to the register server
        //TODO: Figure out how to implement this

    }
}
