namespace HypeVM
{

    using System;

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
            //Create a new VM
            VM.VM vm = new VM.VM(null, new VM.Memory.Memory(32767));

            VM.Utils.Utils.memTest(vm);
            // while(true)
            // {

            // }
        }
    }
}