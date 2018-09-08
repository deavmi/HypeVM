namespace HypeVM.Master.Devices
{

    using System;

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

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[DeviceManager]: Created new device manager with " + "" + " devices.");
        }

        //Returns the number of devices
        //public //TODO: as well

        //Executes the `poll()` method on each device
        public void pollDevices()
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[DeviceManager]: Poll devices begin.");

            //Poll each device
            foreach(Device device in devices)
            {
                //TODO: devices.lentgh or what? oh indexof
                Console.Out.WriteLine("DevicePoll[ID: "+devices);
                device.poll();
            }

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[DeviceManager]: Poll devices end.");
        }
    }

    //TODO: Setup a device server to listen for incoming connections for the device
}