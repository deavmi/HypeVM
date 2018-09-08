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
    }



}