/*
 * MemoryManager
 *
 * This module manages the memory of the VM on the master node's side.
 *
 */

namespace HypeVM.Master.Memory
{

    using HypeVM.Master.Clients.Memory; //TODO: Look at how this can be shortened and why

    //Manager for the virtual machine's memory
    public sealed class MemoryManager
    {
        //Construct a new MemoryManager with the given MemoryClient and memory size
        public MemoryManager(MemoryClient memoryClient, short memorySize)
        {
            //TODO: Implement me
        }

        //Set the value (byte) of at an address
        public void setByte(short address, byte value)
        {
            //TODO: Implement me
        }

        //gets the value (byte) at the given address
        public byte getByte(short address)
        {
            //TODO: Implement me
            return 1;
        }
    }

}