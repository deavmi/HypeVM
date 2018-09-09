/*
 * MasterManager
 *
 * Used to start the HypeVM in master mode. This is the mode whereby the machine will be the one
 * interfacing between the code and the user.
 *
 */

namespace HypeVM.Main
{

    using System;
    using System.IO;

    using HypeVM.Slave.Servers.Memory;
    using HypeVM.Master.Clients.Memory;
    using HypeVM.Master.Clients.Register;

    public class MasterManager
    {

        //Path to the config file
        private string configFilePath;

        //Create a new master node
        public MasterManager(string configFilePath)
        {
            Console.Out.WriteLine("[MasterManager] New master created with config file path: \"" + configFilePath + "\"");
            this.configFilePath = configFilePath;
        }

        //Begin the Master node
        public void run()
        {
            Console.Out.WriteLine("[MasterManager] Starting a new HypeVM instance...");
            Console.Beep();//TODO: what


            //Read the configuration file
            //TODO: Implement file reading
            TextReader textReader = new TextReader(configFilePath);
            //TODO: Implement the reading of lines
            textReader.getNextLine();
            
            //TODO: Test configuration put in place whilst I work on the TextReader module
            string memoryServerIP = "127.0.0.1";
            int memoryServerPort = 3001;

            string registerServerIP = "127.0.0.1";
            int registerServerPort = 3002;

            //Setup the relevant servers
            Console.Out.WriteLine("[MasterManager] Setting up servers...");
            
            //Setup the MemoryClient
            //TODO: Implement me
            MemoryClient memoryClient = new MemoryClient(memoryServerIP, memoryServerPort);

            //Setup anything that needs to be setup for the MemoryClient and then begin its Thread
            memoryClient.start();            

            //Setup the RegisterClient
            //TODO: Implement me
            RegisterClient registerClient = new RegisterClient(registerServerIP, registerServerPort);
            
            //Setup anything that needs to be setup for the RegisterClient and then begin its Thread
            registerClient.start();


            //Setup the managers
            Console.Out.WriteLine("[MasterManager] Setting up managers...");

            //Setup the MemoryManager
            //TODO: Implement me
            


            //Setup the RegisterManager
            //TODO: Implement me

            //Setup the DeviceManager
            //TODO: Implement me

            //Create the virtual machine
            Console.Out.WriteLine("[MasterManager] Setting up virtual machine...");
            

        

            //Virtual machine has ended
            Console.Out.WriteLine("[MasterManager] VM run completed.");

        }
    }
}