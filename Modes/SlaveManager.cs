/*
 * SlaveManager
 *
 * Used to start the HypeVM in slave mode. This is the mode whereby theis machine will be the one
 * manage the master node's resources (memory, registers etc.).
 *
 */

namespace HypeVM.Main
{
    using System;
    using HypeVM.Slave.Servers.Memory;

    public class SlaveManager
    {
        //Create a new slave node
        public SlaveManager()
        {
            Console.Out.WriteLine("[SlaveManager] New slave created");
        }

        //Begin the Slave node
        public void run(string slaveType, string ipBind, string portBind)
        {
            Console.Out.WriteLine("[MasterManager] New master created");

            //TODO: Remove this testing code

            if(slaveType.Equals("memory"))
            {
                Console.Out.WriteLine("This slave is a memory slave");

                //Setup the memory slave
                MemoryServer memoryServer = new MemoryServer(ipBind, int.Parse(portBind));


            }
            else if(slaveType.Equals("registers"))
            {
                Console.Out.WriteLine("This slave is a registers slave");
            }

        }
    }
}