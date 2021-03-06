/*
 * Memory
 *
 * The internals used by the MemoryServer to keep track of the VM's memory.
 *
 */

namespace HypeVM.Slave.Servers.Memory
{

    using System;

    //Represents the VM's memory
    public sealed class Memory
    {

        //The actual memory (0 indexed) hence the addresses will range from
        //[0, size-1]
        //Valid example for the maximum Memory size of `32767` would be addresses
        //in the range [0,32766]
        private byte[] memory;

        //Create a new Memory with the given size `size` in bytes
        public Memory(short size)
        {
            //Create an array of bytes (memory) of size:
            //If `size` is 0 then it means no bytes (bascially no memory then)
            //However valid memory sizes are elements of the range [1,32767]
            memory = new byte[size];

            //TODO: Throw error on size==0 as this symbolises no bytes for memory
            //TODO: Throw error on size <= 0 as this symbolises no memory or negative which makes no sense (for the latter)
            
            //Check if the size given is zero or neggative and then throw an error
            if(size <= 0)
            {
                Console.Out.WriteLine("Size cannot be 0 bytes or negative");
            }
            else
            {
                Console.Out.WriteLine("Size given is fine");
            }
        }

        //Return the size of this memory in bytes (TODO: Lekker revision for alles)
        public short getSize()
        {
            return (short)memory.Length;
        }

        //Return the byte at the given address
        public byte getByte(short address)
        {
            //TODO: Throw error when `address` is negative or not in range of [0,nonZeroSize-1]
            if(address > getSize()-1)
            {
                //If the given address is higher than the memory's highest address
            }
            else if(address < 0)
            {
                //If the given address is less than zero (negative) then give an error
            }

            //The value at that address
            byte valueAtAddress = 0;

            valueAtAddress = memory[address];

            return valueAtAddress;
        }

        

    }
}