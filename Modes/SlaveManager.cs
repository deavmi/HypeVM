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

    public class SlaveManager
    {
        //Create a new slave node
        public SlaveManager()
        {
            Console.Out.WriteLine("[SlaveManager] New slave created");
        }

        //Begin the Slave node
        public void run()
        {
            Console.Out.WriteLine("[MasterManager] New master created");
        }
    }
}