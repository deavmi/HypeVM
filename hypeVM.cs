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

            //Create a new DeviceManager for this machine (TODO: Remove null)
            DeviceManager deviceManager = new DeviceManager(null);

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