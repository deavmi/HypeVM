namespace HypeVM.VM.Devices
{
    //Manages the devices
    public sealed class DeviceManager
    {
        //The devices attached to this machine
        private Device[] devices;

        //Create a new DeviceManager with the given devices
        //to be attached
        public DeviceManager(Device[] devices)
        {
            //Add the given devices to the machine
            this.devices = devices;
        }

        //Returns the number of devices
        public //TODO: as well

        //Executes the `poll()` method on each device
        public void pollDevices()
        {
            foreach(Device device in devices)
            {
                Console.Out.WriteLine("DevicePoll[ID: "+devices)
                device.poll();
            }
        }
    }
}