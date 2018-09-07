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
            

            //Setup the relevant servers


            //Create the virtual machine
            VM vm
        }
    }
}