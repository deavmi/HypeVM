/*
 * Executor
 *
 * Runs the actual execution cycle of the machine.
 *
 */

 namespace HypeVM.Master.VM
 {

     using System;

     public sealed class Executor
     {

        //Execute a machine cycle on the given machine
        public bool cycle(VM vm)
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle begin.");

            //TODO: Implement me
            //1. Add exeuction and management of code
            Console.Out.WriteLine("[Executor]: Code execution cycle begin.");
            
            
            //TODO: Implement me (The execution of the machine code)
            short instructionPointerAddress = vm.getRegisters().instructionPointer;
            Console.Out.WriteLine("Current instruction pointer value (an address): " + instructionPointerAddress);

            //TODO: Continue here

            //The OPCode of the instruction
            byte opCode = 0;

            //Check what instruction it is
            if(opCode == 0) //Halt instructuction
            {
                //Halt the machine when this instruction is encountered
            }


            Console.Out.WriteLine("[Executor]: Code execution cycle end.");
            //2. poll all devices via devicemanager
            Console.Out.WriteLine("[Executor]: Poll devices begin.");
            //TODO: Implement me
            //vm.getDeviceManager().pollDevices(); Disabled for now
            Console.Out.WriteLine("[Executor]: Poll devices end.");

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle end.");
        }

     }
 }