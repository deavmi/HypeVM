namespace HypeVM
{

    using System;

    using VM.Devices;

    public class HypeVM
    {

        //Whether or not to run tests
        private static bool testsEnabled = true;

        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to hypeVM!");


            //TODO: Check whether this is a master or slave node
            //Check whether any arguments were provided
            if(args.Length > 0)
            {
                //Check what mode we are running in (master or slave)
                if(args[0].Equals("master"))
                {
                    Console.Out.WriteLine("VM mode selected: master");
                }
                else if(args[0].Equals("slave"))
                {

                }
                else
                {
                    Console.Out.WrietLine("Invalid mode \""+args[0]+"".Equals(""));
                }

            }
            else
            {
                Console.Out.WriteLine("Error: No argument specified (master or slave?)")
            }

            //TODO: remove this from here
            oldCode();
        }

        private static void oldCode()
        {
            //TODO: Implement me
            //Load the configuration of the virtual machine
            Configuration.loadConfig();
            Configuration.fff();

            //Check whether or not we need to run tests, if so run them
            if(testsEnabled)
            {
                Console.Out.WriteLine("Running tests...");
                runTests();
                Console.Out.WriteLine("All tests run.");
            }
        }

        //Run the tests
        private static void runTests()
        {
            //Testing

            //Create an array of some devices
            Device[] devices = new Device[]{new Plugins.Devices.NullDevice.NullDevice()};

            //Create a new DeviceManager for this machine (TODO: Remove null)
            DeviceManager deviceManager = new DeviceManager(devices);

            //Create a new VM
            VM.VM vm = new VM.VM(null, new VM.Memory.Memory(32767), deviceManager); //TODO: Remove null

            VM.Utils.Utils.memTest(vm);
            // while(true)
            // {

            // }





            //Code below is run once all machine tests have finished

            //Make the machine begin execution
            Console.Out.WriteLine("Beginning execution of machine...");
            vm.beginRun();
            Console.Out.WriteLine("Machine execution finished");

        }
    }
}