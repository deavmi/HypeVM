/*
 * Executor
 *
 * Runs the actual execution cycle of the machine.
 *
 */

 namespace HypeVM.VM
 {

     using System;

     public sealed class Executor
     {

        //Execute a machine cycke
        public static void cycle(VM vm)
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle begin.");

            //TODO: Implement me
            //1. Add exeuction and management of code
            Console.Out.WriteLine("[Executor]: Code execution cylce begin.");
            //TODO: Implement me
            Console.Out.WriteLine("[Executor]: Code execution cylce end.");
            //2. poll all devices via devicemanager
            Console.Out.WriteLine("[Executor]: Poll devices begin.");
            //TODO: Implement me
            vm.getDeviceManager().pollDevices(); //lol continue here this that
            Console.Out.WriteLine("[Executor]: Poll devices end.");

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle end.");
        }

     }
 }