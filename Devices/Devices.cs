namespace HypeVM.VM.Devices
{
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
        //The name of the device
        private string deviceName;

        //The description of the device
        private string deviceDescription;

        public DeviceInfo(string deviceName, string deviceDescription)
        {
            this.deviceName = deviceName;
            this.deviceDescription = deviceDescription;
        }
    }
}