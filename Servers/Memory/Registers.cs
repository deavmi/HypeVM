/*
 * Registers
 *
 * The internals used by the RegisterServer to keep track of the VM's registers.
 *
 */

namespace HypeVM.Slave.Servers.Registers
{
    //Represents the state of the machine's registers
    public sealed class RegisterState
    {

        //The general purpose registers

        //Byte-sized registers
        public byte bsA = 0;
        public byte bsB = 0;
        public byte bsC = 0;
        public byte bsD = 0;
        

        //Short (word) sized registers
        public short ssA = 0;
        public short ssB = 0;
        public short ssC = 0;
        public short ssD = 0;

        //The specified registers

        //Holds the address of the base of the code loaded into memory
        public short codeBasePointer; 

        //Holds the address of the beginning of the code loaded into memory
        public short codePointer;

        //Holds the address of the intruction in memory currently being executed
        public short instructionPointer;

        public RegisterState()
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[RegisterState]: Created new virtual machine register set.");
        }
    }
}