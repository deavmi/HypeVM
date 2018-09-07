namespace HypeVM.Main
{

    using System;

    using VM.Devices;

    public class HypeVM
    {

        //Whether or not to run tests
        private static bool testsEnabled = true;

        //Start the hypeVM in a given mode
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to hypeVM!");

            //Check whether any arguments were provided
            if(args.Length > 0)
            {
                //Check what mode we are running in (master or slave)

                //If we are running in master mode
                if(args[0].Equals("master"))
                {
                    Console.Out.WriteLine("VM mode selected: master");

                    //Create a new MasterManager that will kick off the execution of the respective code
                    MasterManager masterManager = new MasterManager(); //TODO : test

                    //Start the respective code
                    masterManager.run();
                }
                //If we are ruinning in slave mode
                else if(args[0].Equals("slave"))
                {
                    Console.Out.WriteLine("VM mode selected: slave");

                    //Create a new SlaveManager that will kick off the execution of the respective code
                    SlaveManager slaveManager = new SlaveManager(); //TODO : test

                    //Start the respective code
                    slaveManager.run();
                }
                //If the mode provided is not a mode actually
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