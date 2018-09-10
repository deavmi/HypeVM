namespace HypeVM.Main
{

    using System;
    using System.IO;

    // using VM.Devices;
    // using Slave.Servers.MemoryServer;


    public class hypeVM
    {

        //Whether or not to run tests
        private static bool testsEnabled = true;

        //Start the hypeVM in a given mode
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to hypeVM!");

            //This is UTF 16 and hence with this encoding
            //It encodes characters with 1 16bit cde unit
            //a.k.a. 2 bytes. Hence two characters here is 2bytes*2=4
            Console.Out.WriteLine(new System.Text.UnicodeEncoding().GetByteCount("aA"));

            //Let's try UTF-8 (the widely used encoding scheme)
            //UTF 8 should say 1 byte for this
            //unlike 16-bit utf 16 which is fixed length in the case of ASCII characters
            //UTF 8 will be from 1 to 4 bytes but the ASCII characters are 1 bytes
            Console.Out.WriteLine(new System.Text.UTF8Encoding().GetByteCount("a"));

            //Ah I see it is a 16 bit charwe are using.
            //Just discovered it in the `Char` struct
            char g;

            //More testing
            System.Text.UnicodeEncoding j = new System.Text.UnicodeEncoding();

            //We provide it the neede two bytes which UTF-16 uses to encode characters
            byte[] bytes = new byte[2];

            //We now encode the character 'A'
            int byteCount = j.GetEncoder().GetBytes(new char[] { 'A' }, 0, 1, bytes, 0, false);

            Console.Out.WriteLine("Got bytes: " + byteCount); //2
            Console.Out.WriteLine(bytes[0] + " " + bytes[1]); //65 and 0

            //More testing
            j = new System.Text.UnicodeEncoding(false, false);

            //We provide it the neede two bytes which UTF-16 uses to encode characters
            bytes = new byte[2];

            //We now encode the character 'A'
            byteCount = j.GetEncoder().GetBytes(new char[] { 'A' }, 0, 1, bytes, 0, false);

            Console.Out.WriteLine("Got bytes: " + byteCount); //2
            Console.Out.WriteLine(bytes[0] + " " + bytes[1]); //65 and 0

            Console.Out.WriteLine(BitConverter.IsLittleEndian); //true (for x86 and x86_64)
            ushort d = BitConverter.ToUInt16(bytes); //This will give me 65
            Console.Out.WriteLine("Unsigned short from 2 bytes: " + d); //65

            //Now if we extract the byte from here it would be the first byte
            byte firstByteOfShort = (byte)d; //65
            Console.Out.WriteLine("FirstByteOfShort: " + firstByteOfShort); //65

            //If we have ushort
            ushort test1 = 65535; //16 1 bits
            short test2 = (short)test1; //Now this means that it will be -1
            Console.Out.WriteLine("Signed short from highest unsigned short: " + test2); //-1

            int test3 = test1; //We are copying the value 65535 into an integer which can represent
            //the unsigned value of 65535 as UNSIGNED
            int test4 = test2; //We are coying the signed value -1 into an integer which can represent
            //the signed value of -1 as SIGNED
            
            Console.Out.WriteLine("test3: " + test3); //65535
            Console.Out.WriteLine("test4: " + test4); //-1

            return;

            //Check whether any arguments were provided
            if (args.Length > 0)
            {
                //Check what mode we are running in (master or slave)

                //If we are running in master mode
                if (args[0].Equals("master"))
                {
                    Console.Out.WriteLine("VM mode selected: master");

                    //TODO: Now check for the required arguments

                    //Check if a second argument was provided for the path to the init image
                    if (args.Length > 1)
                    {
                        //Init image file path
                        string initImageFilePath = args[1];

                        //Check if the file exists
                        if (File.Exists(initImageFilePath))
                        {
                            //Create a new MasterManager that will kick off the execution of the respective code
                            MasterManager masterManager = new MasterManager(initImageFilePath); //TODO : namespace works as expected

                            //Start the respective code
                            masterManager.run();
                        }
                        else
                        {
                            Console.Out.WriteLine("The path to the init image does not exist");
                        }
                    }
                    //If not init image was provided
                    else
                    {
                        Console.Out.WriteLine("No init image was provided");
                    }
                }
                //If we are ruinning in slave mode
                else if (args[0].Equals("slave"))
                {
                    Console.Out.WriteLine("VM mode selected: slave");

                    //Create a new SlaveManager that will kick off the execution of the respective code
                    SlaveManager slaveManager = new SlaveManager(); //TODO : namespace works as expected

                    //TODO: Remove this for later and then make it rely on config file data

                    string typeOfSlave = args[1];
                    string ipBind = args[2];
                    string portBind = args[3];

                    //Start the respective code
                    slaveManager.run(typeOfSlave, ipBind, portBind);
                }
                //If the mode provided is not a mode actually
                else
                {
                    Console.Out.WriteLine("Invalid mode \"" + args[0] + "".Equals(""));
                }
            }
            else
            {
                Console.Out.WriteLine("Error: No argument specified (master or slave?)");
            }

            //TODO: remove this from here
            //oldCode(); //Currently disabled
        }

        // private static void oldCode()
        // {
        //     //TODO: Implement me
        //     //Load the configuration of the virtual machine
        //     Configuration.loadConfig();
        //     Configuration.fff();

        //     //Check whether or not we need to run tests, if so run them
        //     if (testsEnabled)
        //     {
        //         Console.Out.WriteLine("Running tests...");
        //         runTests();
        //         Console.Out.WriteLine("All tests run.");
        //     }
        // }

        //Run the tests
        // private static void runTests()
        // {
        //     //Testing

        //     //Create an array of some devices
        //     Device[] devices = new Device[] { new Plugins.Devices.NullDevice.NullDevice() };

        //     //Create a new DeviceManager for this machine (TODO: Remove null)
        //     DeviceManager deviceManager = new DeviceManager(devices);

        //     //Create a new VM
        //     VM.VM vm = new VM.VM(null, new Memory(32767), deviceManager); //TODO: Remove null

        //     VM.Utils.Utils.memTest(vm);
        //     // while(true)
        //     // {

        //     // }





        //     //Code below is run once all machine tests have finished

        //     //Make the machine begin execution
        //     Console.Out.WriteLine("Beginning execution of machine...");
        //     vm.beginRun();
        //     Console.Out.WriteLine("Machine execution finished");

        // }
    }
}