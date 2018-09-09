namespace HypeVM.Master.VM
{

    using System;

    using Master.Memory;
    using Master.Registers;
    using Master.Devices;

    //Represents a virtual machine
    public sealed class VM
    {

        //The machine's MemoryManager
        private MemoryManager memoryManager;

        //The machine's RegisterManager
        private RegisterManager registerManager;

        //The device manager of this machine (holds the connected devices)
        private DeviceManager deviceManager;

        //Create a new VM with the given program `bytecode`
        //and memory `Memory`
        public VM(MemoryManager memoryManager, RegisterManager registerManager, DeviceManager deviceManager)
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: New machine being initialized...");

            //Set the bytecode to be run on this machine (TODO: move this to a non-static initialization block)
            // Utils.Init.bootMachine(this, bytecode);

            //Set this machine's MemoryManager
            this.memoryManager = memoryManager;

            //Set this machine's RegisterManager
            this.registerManager = registerManager;

            //Set this machine's DeviceManager
            this.deviceManager = deviceManager;

            //Print out information about the VM's configuration now
            outputVMInfo();

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Created new virtual machine.");
        }

        //Output information about the VM's configuration
        public void outputVMInfo()
        {
            //TODO: Implement me
            Console.Out.WriteLine();
        }

        //Begin running of code
        public void beginRun()
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Code running begin");

            //Code loop here
            while (true)
            {
                //TODO: implement me

                //Execute a machine cycle
                Executor.cycle(this);

                break;
            }

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Machine code run completed, now halted.");
        }

        //Returns this machine's devices (DeviceManager)
        public DeviceManager getDeviceManager()
        {
            return deviceManager;
        }

        //Returns this machine's registers (RegisterManager)
        public RegisterManager getRegisters()
        {
            return registerManager;
        }

        //Returns this machine's memory (MemoryManager)
        public MemoryManager getMemory()
        {
            return memoryManager;
        }

        //Boot the machine with the given init image
        public void bootMachine(string initImagePathname)
        {
            Console.Out.WriteLine("Booting machine with image \""+initImagePathname + "\"...");

            //TODO: Implement me

            //Read all the bytes from the file into an array of bytes
            ByteReader byteReader = new ByteReader(initImagePathname);
            byte[] codeBytes = byteReader.readBytes();

            Console.Out.WriteLine("Code loaded into memory size (bytes): " + codeBytes.Length);

            //Memory addresses
            short startingAddress = 0; //The starting address for code is at the beginning of memory
            short currentByteAddress = 0; //The current address we are at in memory, will point to the last
            //byte of the code loaded into memory

            //Now load all the bytes into memory
            for(short byteIndex = 0; byteIndex < codeBytes.Length; byteIndex++)
            {
                //Now via the memory manager load each byte into the correct address
                currentByteAddress = (short)(startingAddress + byteIndex);
                memoryManager.setByte(currentByteAddress, codeBytes[byteIndex]);
            }

            //Set the registers to hold to the correct addresses
            short codeFirst = startingAddress; //First byte of code address
            short codeLast = currentByteAddress; //Last byte of code address

            //Set the instruction pointer to the first byte of the code
            short instructionPointer = codeFirst;

            //TODO: Add code to set the registers here

            //This code will use the properties to assign values to them but in actual fact will be communicating via the RegisterManeger
            //and via it to the RegisterClient which will send the data over to the RegisterSever.
            registerManager.codeFirst = codeFirst;
            registerManager.codeLast = codeLast;
            registerManager.instructionPointer = instructionPointer;

            //Output information on the values to assign to the registers
            Console.Out.WriteLine("CodeFirst value: " + codeFirst);
            Console.Out.WriteLine("CodeLast value: " + codeLast);
            Console.Out.WriteLine("InstructionPointer value: " + instructionPointer);
            
            
        }


        //TODO: Abstract lolwot (is there OOP up in this property shit)
        public byte valueOgdsgfdsdne
        {
            get
            {
                return 1;
            }

            set
            {
                Console.Out.Write("");
                value = 1; //Ah this is the internally tracked value
            }
        }

    }
}