namespace HypeVM.VM
{

    using System;

    using Bytecode;
    using Memory;
    using Devices;

    //Represents a virtual machine
    public sealed class VM
    {

        //The machine's memory
        private Memory.Memory memory;

        //The machine's registers
        private RegisterState registers = new RegisterState();

        //The device manager of this machine (holds the connected devices)
        private DeviceManager deviceManager;

        //Create a new VM with the given program `bytecode`
        //and memory `Memory`
        public VM(Bytecode.Bytecode bytecode, Memory.Memory memory, DeviceManager deviceManager)
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: New machine being initialized...");

            //Set the bytecode to be run on this machine
            Utils.Init.bootMachine(this, bytecode);

            //Set this machine's memory
            this.memory = memory;

            //Set this machine's device manager
            this.deviceManager = deviceManager;

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Created new virtual machine.");
        }

        //Returns this machine's registers
        public RegisterState getRegisters()
        {
            return registers;
        }

        //Returns this machine's memory
        public Memory.Memory getMemory()
        {
            return memory;
        }
    }

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