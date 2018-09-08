namespace HypeVM.VM
{

    using System;

    //Represents a virtual machine
    public sealed class VM
    {

        //The machine's MemoryManager
        private MemoryManager memoryManager;

        //The machine's RegisterManager
        private Registermanager registerManager;

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

            //Set this machine's memory
            // this.memory = memory;

            //Set this machine's device manager
            // this.deviceManager = deviceManager;

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Created new virtual machine.");
        }

        //Begin running of code
        public void beginRun()
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Code running begin");

            //Code loop here
            while(true)
            {
                //TODO: implement me

                //Execute a machine cycle
                Executor.cycle(this);

                break;
            }

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[VM]: Machine code run completed, now halted.");
        }

        //Returns this machine's devices (device manager)
        public DeviceManager getDeviceManager()
        {
            return deviceManager;
        }

        //Returns this machine's registers
        public RegisterState getRegisters()
        {
            return registers;
        }

        //Returns this machine's memory
        public Memory getMemory()
        {
            return memory;
        }
    }

    

}