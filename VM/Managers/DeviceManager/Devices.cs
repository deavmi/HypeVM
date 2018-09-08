namespace HypeVM.Master.Devices
{

    using System;

    //Represents a device that can be attatched to the machine
    public abstract class Device
    {
        //Information about the device (name, description)
        private DeviceInfo deviceInfo;

        //The device's memory range
        private short[] memoryRange;

        public Device(DeviceInfo deviceInfo, short[] memoryRange)
        {
            //Set the device's DeviceInfo
            this.deviceInfo = deviceInfo;

            //TODO: Throw error on dimensions != 2
            //Set the range of addresses that this device occupies
            //(its own address space within the I/O address space)
            this.memoryRange = memoryRange;

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Device]: New device created");
            Console.Out.WriteLine("[Device]: Device name:  \""+deviceInfo.getName()+"\"");
            Console.Out.WriteLine("[Device]: Device description: \""+deviceInfo.getDescription()+"\"");
            Console.Out.WriteLine("[Device]: Device I/O address space memory range: ");  //TODO: add me
        }

        //Execute the code that this device must run to check
        //whether or not it should take some sort of action
        public abstract void poll();

        //Get start address
        public short getStartAddress()
        {
            return memoryRange[0];
        }

        //Get end address
        public short getEndAddress()
        {
            return memoryRange[1];
        }
    }

    /*
     * DeviceInfo
     *
     * Represents information about the device such as
     * the device's name, description etc.
     *
     */

    public sealed class DeviceInfo
    {
        //The name of the device (TODO: make final and remove methods)
        private string deviceName;

        //The description of the device (TODO: make final and remove methods)
        private string deviceDescription;

        public DeviceInfo(string deviceName, string deviceDescription)
        {
            this.deviceName = deviceName;
            this.deviceDescription = deviceDescription;
        }

        //Returns the name of this device
        public string getName()
        {
            return deviceName;
        }

        //Returns a description of this device
        public string getDescription()
        {
            return deviceDescription;
        }

        
    }
}